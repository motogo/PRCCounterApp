/* 
** Single page of source code illustrating running two boards on two threads.
*/
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#ifdef LINUX
#include <errno.h>
#include <termios.h>
#include <unistd.h>
#include <fcntl.h>
#include <pthread.h>
#else
#include <conio.h>
#include <process.h>
#endif
#include "gt668drv.h"

#ifdef LINUX
typedef pthread_t THREAD_HANDLE;
int pthread_timedjoin_np(pthread_t thread, void **retval, const struct timespec *abstime);
#else
typedef HANDLE THREAD_HANDLE;
#endif

#define INVALID_HANDLE ((THREAD_HANDLE)-1)

#define            ARRAY_SIZE     100000			/* total number to acquire    */

double             BoardsData[2][ARRAY_SIZE];       /* Array for time values      */

THREAD_HANDLE hThread[2] = { INVALID_HANDLE, INVALID_HANDLE };

void checkForErrors(void );

#ifdef LINUX
int _getch(void)
{
	return getchar();
}

int _kbhit(void)
{
	struct termios oldt, newt;
	int ch;
	int oldf;

	tcgetattr(STDIN_FILENO, &oldt);
	newt = oldt;
	newt.c_lflag &= ~(ICANON | ECHO);
	tcsetattr(STDIN_FILENO, TCSANOW, &newt);
	oldf = fcntl(STDIN_FILENO, F_GETFL, 0);
	fcntl(STDIN_FILENO, F_SETFL, oldf | O_NONBLOCK);

	ch = getchar();

	tcsetattr(STDIN_FILENO, TCSANOW, &oldt);
	fcntl(STDIN_FILENO, F_SETFL, oldf);

	if(ch != EOF)
	{
		ungetc(ch, stdin);
		return 1;
	}

	return 0;
}
#endif

typedef struct __thread_args_tag
{
	int thread_num;
	int board;
	GtiPrescale presc;
} thread_args, *pthread_args;

int thread_stop[2] = { 0, 0 };
volatile unsigned int total_read[2] = { 0, 0 };
unsigned int thread_err[2] = { 0, 0 };

#ifdef LINUX
void *GTAPI measure_board(void *p)
#else
unsigned int GTAPI measure_board(void *p)
#endif
{
	pthread_args pargs = (pthread_args)p;
	unsigned int totalSamplesRead, curRead, err = 0;

	GT668Select(pargs->board);
	GT668SetMeasEnable(0, GT_True);
	GT668SetMeasEnable(1, GT_False);
	GT668SetInputImpedance(GT_SIG_A, GT_IMP_LO);
	GT668SetInputCoupling(GT_SIG_A, GT_CPL_DC);
	GT668SetInputPrescale(GT_SIG_A, pargs->presc);
	GT668SetMeasSkip(0, 1);
	GT668SetMemoryWrapMode(GT_False);

	totalSamplesRead = 0;
	GT668StartMeasurements();               /* reset measurement memory   */
	Sleep(10);

	while(totalSamplesRead < ARRAY_SIZE && !thread_stop[pargs->thread_num] && err == 0)
	{
		unsigned int ToRead = ARRAY_SIZE - totalSamplesRead;
		if (ToRead > 1000)
			ToRead = 1000;
		curRead = 0;
		GT668ReadTimetags(&BoardsData[pargs->thread_num][totalSamplesRead], ToRead, &curRead, NULL, 0, NULL);
		totalSamplesRead += curRead;

		if (curRead)
			total_read[pargs->thread_num] = totalSamplesRead;

		Sleep(0);

		err = GT668GetError();                       /* check for driver errors    */
	}

	GT668StopMeasurements();
	thread_stop[pargs->thread_num] = 1;
#ifdef LINUX
	return (void*)(intptr_t)err;
#else
	return err;
#endif
}

int main(int argc,char *argv[])
{
	int i;
	int board0, board1, presc = 1;
	thread_args args[2];
	char tmpStr[256];

	if (argc != 3 && argc != 4)
	{
		printf("usage: %s <board1> <board2> [prescale]\n",argv[0]); 
		printf("Example:   %s 0 1\n",argv[0]);
		exit(0);
	}

	sscanf(argv[1],"%d",&board0);
	sscanf(argv[2],"%d",&board1);
	if (argc == 4)
	{
		presc = atoi(argv[3]);
		for (i = 0; i < 11; i++)
			if ((1 << i) == presc)
				break;
		if (i >= 11)
		{
			printf("Prescale should be (1, 2, 4, 8, 16, 32, 64, 128, 256, 512, or 1024\n");
			exit(0);
		}
		presc = i + 1;
	}
		
	printf("Initializing and calibrating first board instrument...\n");
	GT668Initialize(board0);
	GT668SelfCal();
	checkForErrors();                       /* check for driver errors    */
		
	printf("Initializing and calibrating second board instrument...\n");
	GT668Initialize(board1);
	GT668SelfCal();
	checkForErrors();                       /* check for driver errors    */

	args[0].thread_num = 0;
	args[0].board = board0;
	args[0].presc = (GtiPrescale)presc;
	thread_stop[0] = 0;
	args[1].thread_num = 1;
	args[1].board = board1;
	args[1].presc = (GtiPrescale)presc;
	thread_stop[1] = 0;

#ifdef LINUX
	if (pthread_create(&hThread[0], NULL, measure_board, (void*)&args[0]))
		hThread[0] = INVALID_HANDLE;
	if (pthread_create(&hThread[1], NULL, measure_board, (void*)&args[1]))
		hThread[1] = INVALID_HANDLE;
#else
	{
		unsigned int id[2];

		hThread[0] = (THREAD_HANDLE)_beginthreadex(NULL, 0, measure_board, (void*)&args[0], 0, &id[0]);
		hThread[1] = (THREAD_HANDLE)_beginthreadex(NULL, 0, measure_board, (void*)&args[1], 0, &id[1]);
	}
#endif
	if (hThread[0] == INVALID_HANDLE)
		printf("\nFailed to run thread on board0\n");
	if (hThread[1] == INVALID_HANDLE)
		printf("\nFailed to run thread on board1\n");

	printf("Acquiring data on channel 0 of boath boards (Hit any key to abort)...\nTotal done - ");
	while(!_kbhit() && !(thread_stop[0] && thread_stop[1]))
	{
		static unsigned int prev[2] = { 0xffffffff, 0xffffffff };
		if (total_read[0] != prev[0] || total_read[1] != prev[1])
		{
			printf("%10d %10d\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b", total_read[0], total_read[1]);
			prev[0] = total_read[0];
			prev[1] = total_read[1];
			Sleep(10);
		}
		else
			Sleep(0);
	}
	printf("%10d %10d\n", total_read[0], total_read[1]);
	if (_kbhit())
	{
		DWORD err, timeout = 2000;
		_getch();
		for (i = 0; i < 2; i++)
		{
			LONG32 last_cnt = total_read[i];
			if (hThread[1] == INVALID_HANDLE)
				break;
			thread_stop[i] = 1;
			Sleep(0);
#ifdef LINUX
			{
				struct timespec t;
				t.tv_nsec = timeout * 1000000;
				t.tv_sec = 0;
				if (pthread_timedjoin_np(hThread[i], (void**)&err, &t) == ETIMEDOUT)
				{
					if (last_cnt == total_read[i])
					{
						pthread_cancel(hThread[i]);
						err = -1;
					}
					else
						last_cnt = total_read[i];
				}
			}
#else
			if (WaitForSingleObject(hThread[i], timeout) == WAIT_TIMEOUT)
			{
				if (last_cnt == total_read[i])
					TerminateThread(hThread[i], -1);
				else
					last_cnt = total_read[i];
			}
			GetExitCodeThread(hThread[i], &err);
			CloseHandle(hThread[i]);
#endif
			hThread[i] = INVALID_HANDLE;
			thread_err[i] = err;
		}
	}

	GT668Select(board0);
	GT668Close();
	GT668Select(board1);
	GT668Close();

	if (thread_err[0])
	{
		GT668GetErrorMessage(thread_err[0], tmpStr, sizeof(tmpStr));
		printf("\nError Board #%d [%d]: %s", board0, thread_err[0], tmpStr);
	}
	if (thread_err[1])
	{
		GT668GetErrorMessage(thread_err[1], tmpStr, sizeof(tmpStr));
		printf("\nError Board #%d [%d]: %s", board1, thread_err[1], tmpStr);
	}

	for (i = 0; i < 2; i++)
	{
		int j;
		if (total_read[i] > 2)
		{
			double delta = BoardsData[i][1] - BoardsData[i][0];
			for (j = 2; j < (int)total_read[i]; j++)
			{
				if (fabs(BoardsData[i][j] - BoardsData[i][j - 1] - delta) > 250e-12)
					break;
			}
			if (j < (int)total_read[i])
				printf("\nError on board #%d @ measurement #%d", i, j);
		}
	}

	printf("\nHit any key to exit...");
	_getch();
	
	return 0;
}

/*----------------------------------------------------------------------------*/
/*                            checkForErrors()                           */
/*----------------------------------------------------------------------------*/
/*
** This Application level routine checks for instrument errors.  If an 
** error has occurred, then a description of the error is printed to stderr, 
** and program execution terminates.  
** 
** This function is used during program debug because it is often easier 
** to sprinkle 'checkForErrors()' calls throughout a program rather than 
** putting 'if' statements around each driver function call.
**
*/
void checkForErrors(void)
{
	char		tmpStr[128];
	int		err;

	err = GT668GetError();
	if(!err)                        /* check error of currently   */
		return;                                   /* selected brd               */

	GT668GetErrorMessage(err, tmpStr, sizeof(tmpStr));
	fprintf(stderr,"Error: %s\n",tmpStr);
	GT668Close();
	exit(0);
}
