/* 
** Single page of source code illustrating the acqusition of 180000 samples,
** 1000 samples at a time as a pseudo backround process.  This technique applies
** to applications that acquire data over minutes and want to perform other 
** tasks in the mean time.  Best illustrated with a 100Hz TTL level signal.
*/
#include <stdio.h>                              /* needed for printf()        */
#include <stdlib.h>                             /* needed for exit()          */
#ifdef LINUX
#include <termios.h>
#include <unistd.h>
#include <fcntl.h>
#else
#include <conio.h>
#endif

#include "gt668drv.h"

#define            ARRAY_SIZE     0x4000000        /* total number to acquire    */
#define            BLOCKSIZE      1000000          /* block size to acquire      */

double             Chan0Data[ARRAY_SIZE];       /* Array for time values      */

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

int main(int argc,char *argv[])
{
	int             board, presc = 1;
	unsigned int    blockCnt, blockSamplesRead, totalSamplesRead, curRead, baseSeconds;
	

	if (argc != 2 && argc != 3)
	{
		printf("usage: %s  <board> [prescale]\n",argv[0]); 
		printf("Example:   %s  0\n",argv[0]);
		exit(0);
	}

	sscanf(argv[1],"%d",&board);
	if (argc == 3)
	{
		int i;
		presc = atoi(argv[2]);
		for (i = 0; i < 11; i++)
			if ((1 << i) == presc)
				break;
		if (i >= 11)
		{
			printf("Prescale should be (1, 2, 4, 8, 16, 32, 64, 128, 256, 512, or 1024\n");
			exit(0);
		}
		presc = i;
	}
		
	printf("Initializing and calibrating the instrument...\n");
	GT668Initialize(board);
	GT668SelfCal();
	checkForErrors();                       /* check for driver errors    */

	GT668SetMeasEnable(0, GT_True);
	GT668SetMeasEnable(1, GT_False);
	GT668SetInputImpedance(GT_SIG_A, GT_IMP_LO);
	GT668SetInputCoupling(GT_SIG_A, GT_CPL_DC);
	GT668SetInputPrescale(GT_SIG_A, (GtiPrescale)presc);
	GT668SetMeasSkip(0, 0);
	GT668SetMemoryWrapMode(GT_True);           /* allow memory to wrap       */

	blockCnt = 1L;                          /* call the first block, #1   */
	totalSamplesRead = 0;
	blockSamplesRead = 0;
	baseSeconds = 0;
	GT668StartMeasurements();               /* reset measurement memory   */

	printf("Acquiring data on channel 0 (Any key to abort)...\n");
	while(!_kbhit())
	{
		unsigned int ToRead = BLOCKSIZE - blockSamplesRead;
		if ((blockCnt - 1) * BLOCKSIZE + blockSamplesRead + ToRead >= ARRAY_SIZE)
			ToRead = ARRAY_SIZE - (blockCnt - 1) * BLOCKSIZE - blockSamplesRead;
		curRead = 0;
		GT668ReadTimetags(&Chan0Data[(blockCnt - 1) * BLOCKSIZE + blockSamplesRead], ToRead, &curRead, NULL, 0, NULL);
		totalSamplesRead += curRead;
		blockSamplesRead += curRead;

		if (blockSamplesRead == BLOCKSIZE || totalSamplesRead == ARRAY_SIZE)
		{
			printf("\nBlock %d done.  Samples: %8d   (base seconds = %u)\n",blockCnt,totalSamplesRead,baseSeconds);
			printf("----------------------------------------------------------\n");
			if( totalSamplesRead == ARRAY_SIZE)
			{
				printf("Done acquiring %d samples\n",ARRAY_SIZE);
				break;
			}
			blockCnt += 1L;
			blockSamplesRead = 0;

			/* To prevent loss of resolution over long measurement times, use the base seconds
			 * feature to create an offset for all time tags generated from this point and on.
			 */
			if (Chan0Data[totalSamplesRead - 1] >= 1000.0)
			{
				baseSeconds += (int)Chan0Data[totalSamplesRead - 1];
				GT668SetBaseSeconds(baseSeconds);
			}
		}

		printf("%4d \b\b\b\b\b\b\b\b\b",totalSamplesRead);
		checkForErrors();                       /* check for driver errors    */
	}
	if (_kbhit())
		_getch();

	GT668StopMeasurements();
	GT668Close();

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
