/* 
** Single page of source code illustrating the measurement of the phase (TIE) 
** of a signal relative to the reference external.  The program allows
** control of threshold, mux, and prescaling. 
*/
#include <stdio.h>
#include <stdlib.h>                             /* needed for exit()          */
#include <string.h>                             /* needed for exit()          */
#include <time.h>
#ifdef LINUX
#include <termios.h>
#include <unistd.h>
#include <fcntl.h>
#else
#include <conio.h>
#endif
#include "gt668drv.h"

double  *ChanData;       /* Array for time values      */
unsigned int *ChanSec;

typedef struct _mux_table
{
    GtiPrescale scale;
    int value;
} MUX_TABLE;

MUX_TABLE table[] =
{
    { GT_DIV_1,    1 },
    { GT_DIV_2,    2 },
    { GT_DIV_4,    4 },
    { GT_DIV_8,    8 },
    { GT_DIV_16,   16 },
    { GT_DIV_32,   32 },
    { GT_DIV_64,   64 },
    { GT_DIV_128,  128 },
    { GT_DIV_256,  256 },
    { GT_DIV_512,  512 },
    { GT_DIV_1024, 1024 }
};

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

void usage(char *prog)
{
    char *s;
    s = strrchr(prog, '\\');
    if (s)
       s++;
    else
    {
       s = strrchr(prog, '/');
       if (s)
          s++;
       else
       {
          s = strrchr(prog, ':');
          if (s)
             s++;
          else
             s = prog;
       }
    }
    printf("Measure phase (TIE) for a pre-scaled signal from a channel and store them to a file\n\n");
    printf("usage:\n\n  %s  <board> <chan> <thr> <clksrc> <scale> <skip> <samples> <freq> [outfile]\n\n",s);
    printf("      board   - board number (0-31)\n");
    printf("      chan    - input channel (0 - chan A, 1 - chan B, 2 - Both channels)\n");
    printf("      thr     - input threshold (Volts)\n");
    printf("      clksrc  - reference source (0 - internal, 1 - external, 2 - PXI\n");
    printf("      scale   - sampling Mux scaling (1, 2, 4, 8, 16, 32, 64, 128, 256, 512 or 1024)\n");
    printf("      skip    - measurements to skip (0 to 999999)\n");
    printf("      samples - number of samples to read\n");
    printf("      freq    - input signal frequency or 0 to measure the frequency from the signal\n");
    printf("                itself.\n");
    printf("      outfile - output file name. If 'outfile' is not specified then\n");
    printf("                standard output device (normally screen) will be used\n\n");
    printf("Example:  %s  0 0 1.4 0 4 100 1024 tags.txt\n",s); exit(0); 
}

/*----------------------------------------------------------------------------*/
/*                                  main()                                    */
/*----------------------------------------------------------------------------*/
int main(int argc,char *argv[])
{
	int           board, ch;
	int           clksrc, scl_val, skip_val;
	double        freq;
	int           totalSamplesRead, numToRead, totalLeft;
	FILE          *fp;
	double        thresh;
	int i;
	unsigned int  NumTags;
	time_t        run_time;
	unsigned int  base_sec;
	double        phase, ti;
	GtiPrescale   scl;
	GtiRefClkSrc src = GT_REF_INTERNAL;
	GtiSignal sig;

	if (argc != 9 && argc != 10)
		usage(argv[0]);

	sscanf(argv[1],"%d",&board);
	if (board < 0 || board > 31)
	{
		printf("Invalid board number %d\n", board);
		usage(argv[0]);
	}
	sscanf(argv[2],"%d",&ch);
	if (ch < 0 || ch > 1)
	{
		printf("Invalid channel %d\n", ch);
		usage(argv[0]);
	}
	sig = ch == 0 ? GT_SIG_A : GT_SIG_B;
	sscanf(argv[3],"%lf",&thresh);
	sscanf(argv[4],"%d",&clksrc);
	if (clksrc == 0)
		src = GT_REF_INTERNAL;
	else if (clksrc == 1)
		src = GT_REF_EXTERNAL;
	else if (clksrc == 2)
		src = GT_REF_PXI;
	else
	{
		printf("Invalid clksrc %d\n", clksrc);
		usage(argv[0]);
	}
	sscanf(argv[5],"%d",&i);
	scl_val = i;
	sscanf(argv[6],"%d",&i);
	skip_val = i;
	if (skip_val < 0 || skip_val > 999999)
	{
		printf("Invalid skip value %d\n", skip_val);
		usage(argv[0]);
	}
	sscanf(argv[7],"%d",&totalSamplesRead);
	if (totalSamplesRead < 2)
	{
		printf("Invalid number of samples %d\n", totalSamplesRead);
		usage(argv[0]);
	}
	sscanf(argv[8],"%lf",&freq);
	if (freq < 0.0 || freq > 2.7e9)
		usage(argv[0]);

	ChanData = (double *)malloc(totalSamplesRead * sizeof(double));
	ChanSec = (unsigned int *)malloc(totalSamplesRead * sizeof(unsigned int));
	if (!ChanData || !ChanSec)
	{
		if (ChanData)
			free(ChanData);
		if (ChanSec)
			free(ChanSec);
		printf("\nNot enough memory");
		exit(-1);
	}

	printf("Initializing and calibrating the instrument...\n");
	GT668Initialize(board);
	GT668SelfCal();
	checkForErrors();                       /* check for driver errors    */

	for (i = 0; i < sizeof(table)/sizeof(table[0]); i++)
		if (table[i].value == scl_val)
			break;
	if (i < sizeof(table)/sizeof(table[0]))
		scl = table[i].scale;
	else
	{
		printf("Invalid scale value %d\n", scl_val);
		usage(argv[0]);
		exit(-1);
	}
	GT668SetReferenceClock(src, GT_False, GT_False);
	GT668SetInputThreshold(GT_SIG_CLK, GT_THR_PERCENTS, 50.0);
	GT668SetInputThreshold(sig, GT_THR_VOLTS, thresh);
	GT668SetInputImpedance(sig, GT_IMP_LO);
	GT668SetInputCoupling(sig, GT_CPL_DC);
	GT668SetInputPrescale(sig, scl);
	GT668SetMeasSkip(ch, skip_val);
	GT668SetMeasEnable(ch, GT_True);
	GT668SetMeasEnable(1 - ch, GT_False);
	GT668SetMemoryWrapMode(GT_True);
	checkForErrors();                       /* check for driver errors    */

	if (argc == 10)
	{
		fp = fopen(argv[9], "wt");
		if (!fp)
		{
			printf("Error opening output file\n");
			exit(-1);
		}
	}
	else
		fp = NULL;

	if (!fp)
		fp = stdout;

	if (fp != stdout)
		printf("Acquiring data on channel A (Any key to abort)...\n");
	fprintf(fp, "#Type: Phase\n");
	run_time = time(NULL);
	fprintf(fp, "#Start: %s", asctime(localtime(&run_time)));

	memset(ChanSec, 0, totalSamplesRead * sizeof(unsigned int));
	base_sec = 0;
	totalLeft = totalSamplesRead;
	i = 0;
	GT668StartMeasurements();                    /* reset measurement memory   */
	if (fp != stdout)
		printf("\nDone 0\b");
	while(!_kbhit() && totalLeft)
	{
		numToRead = totalLeft;
		NumTags = 0;
		if (ch == 0)
			GT668ReadTimetags(&ChanData[i], numToRead, &NumTags, NULL, 0, NULL);
		else
			GT668ReadTimetags(NULL, 0, NULL, &ChanData[i], numToRead, &NumTags);
		checkForErrors();                       /* check for driver errors    */

		if (NumTags)
		{
			i += NumTags;
			totalLeft -= NumTags;
			if (i < totalSamplesRead && ChanData[i-1] >= 500.0)
			{
				base_sec = (unsigned int)ChanData[i-1] + base_sec;
				GT668SetBaseSeconds(base_sec);
				ChanSec[i] = base_sec;
			}
			if (fp != stdout)
				printf("%10d\b\b\b\b\b\b\b\b\b\b", i);
		}
	}
	if (fp != stdout)
		printf("\n");
	GT668StopMeasurements();
	GT668Close();
	totalSamplesRead = i;
	if (totalSamplesRead < 2)
	{
		printf("Not enough data points.\n");
		exit(-1);
	}

	base_sec = 0;
	for (i = 1; i < totalSamplesRead; i++)
	{
		if (ChanSec[i])
			base_sec = ChanSec[i];
		else
			ChanSec[i] = base_sec;
	}

	if (freq == 0)
	{
		ti = (ChanData[totalSamplesRead - 1] + (double)ChanSec[totalSamplesRead - 1] - ChanData[0]) / (double)(totalSamplesRead - 1);
		freq = (double)scl_val * (double)(skip_val + 1) / ti;
	}
	else
		ti = (double)scl_val * (double)(skip_val + 1) / freq;
	fprintf(fp, "#Frequency: %.14e\n", freq);
	fprintf(fp, "#Multiplier: 1\n");
	phase = 0;
	fprintf(fp, "%.14e,%.14e\n", 0.0, 0.0);
	for (i = 1; i < totalSamplesRead; i++)
	{
		phase += ChanData[i] - ChanData[i-1] + (ChanSec[i] - ChanSec[i - 1]) - ti;
		fprintf(fp, "%.14e,%.14e\n", ChanData[i] + (double)ChanSec[i] - ChanData[0], phase);
	}
	fclose(fp);
	if (fp != stdout)
	{
		printf("\nTotal Samples on channel %c: %8d", ch ? 'B' : 'A', totalSamplesRead);
		printf("\nHit any key to exit...");
		_getch();
	}
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
