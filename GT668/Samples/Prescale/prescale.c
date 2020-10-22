/* 
** Single page of source code illustrating the continual acquisition of a 
** pre-scaled single block of data for channel 0 into a file.  The program
** allows control of clock source, threshold, mux, and prescaling. 
*/
#include <stdio.h>
#include <stdlib.h>                             /* needed for exit()          */
#include <string.h>                             /* needed for exit()          */
#ifdef LINUX
#include <termios.h>
#include <unistd.h>
#include <fcntl.h>
#else
#include <conio.h>
#endif
#include "gt668drv.h"

#define ARRAY_SIZE 5120L
double  ChanAData[ARRAY_SIZE];       /* Array for time values      */

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
    printf("Read time tags for a pre-scaled signal from channel A and store them to a file\n\n");
    printf("usage:\n\n  %s  <board> <thr> <clksrc> <scale1> <scale2> <samples> [[+]outfile]\n\n",s);
    printf("      board   - board number\n");
    printf("      thr     - input threshold (Volts)\n");
    printf("      clksrc  - 1 = external clock, 0 = internal clock\n");
    printf("      scale   - sampling Mux scaling (1, 2, 4, 8, 16, 32, 64, 128, 256, 512 or 1024)\n");
    printf("      skip    - measurements to skip (0 to 999999)\n");
    printf("      samples - number of samples to read\n");
    printf("      outfile - output file name. Use '+' in front of the name in order to\n");
    printf("                append the tags to an existing file, otherwise existing file\n");
    printf("                will be overwritten. If 'outfile' is not specified then\n");
    printf("                standard output device (normally screen) will be used\n\n");
    printf("Example:  %s  0 1.4 0 4 100 1024 tags.txt\n",s); exit(0); 
}

/*----------------------------------------------------------------------------*/
/*                                  main()                                    */
/*----------------------------------------------------------------------------*/
int main(int argc,char *argv[])
{
	int           board;
	int           scl_val, skip_val, readRtn, clksrc;
	unsigned int  totalSamplesRead, numToRead, totalLeft;
	FILE          *fp;
	double        *dp, thresh, last = -1.;
	int i;
	unsigned int NumTags;

	GtiRefClkSrc  ref;
	GtiPrescale   scl;

	if (argc != 7 && argc != 8)
		usage(argv[0]);

	sscanf(argv[1],"%d",&board);
	sscanf(argv[2],"%lf",&thresh);
	sscanf(argv[3],"%d",&i);
	clksrc = i;
	sscanf(argv[4],"%d",&i);
	scl_val = i;
	sscanf(argv[5],"%d",&i);
	skip_val = i;
	sscanf(argv[6],"%d",&totalSamplesRead);

	printf("Initializing and calibrating the instrument...\n");
	GT668Initialize(board);
	GT668SelfCal();
	checkForErrors();                       /* check for driver errors    */

	if (clksrc)
		ref = GT_REF_EXTERNAL;
	else
		ref = GT_REF_INTERNAL;

	for (i = 0; i < sizeof(table)/sizeof(table[0]); i++)
		if (table[i].value == scl_val)
			break;
	if (i < sizeof(table)/sizeof(table[0]))
		scl = table[i].scale;
	else
	{
		printf("Invalid scale value %d\n", scl_val);
		exit(0);
	}
	if (0)
	{
		double pos, neg;
		GT668MeasureAmplitude(GT_SIG_A, &pos, &neg, 1e3);
		printf("\nPos = %g, Neg = %g\n", pos, neg);
	}
	GT668SetReferenceClock(ref, GT_False, GT_False);
	GT668SetInputThreshold(GT_SIG_CLK, GT_THR_PERCENTS, 50.0);
	GT668SetInputThreshold(GT_SIG_A, GT_THR_VOLTS, thresh);
	GT668SetInputImpedance(GT_SIG_A, GT_IMP_LO);
	GT668SetInputCoupling(GT_SIG_A, GT_CPL_DC);
	GT668SetInputPrescale(GT_SIG_A, scl);
	GT668SetMeasSkip(0, skip_val);
	GT668SetMeasEnable(0, GT_True);
	GT668SetMeasEnable(1, GT_False);
	checkForErrors();                       /* check for driver errors    */

	if (argc == 8)
	{
		if (argv[7][0] == '+')
			fp = fopen(&argv[7][1], "at");
		else
			fp = fopen(argv[7], "wt");
		if (!fp)
		{
			printf("Error opening output file\n");
			exit(0);
		}
	}
	else
		fp = NULL;

	printf("Acquiring data on channel A (Any key to abort)...\n");

	if (!fp)
	{
		printf("\nTimeTag (usec)  Interval (usec)");
		printf("\n===============================\n");
	}

	totalLeft = totalSamplesRead;
	GT668StartMeasurements();                    /* reset measurement memory   */
	while(!_kbhit() && totalLeft)
	{
		numToRead = ARRAY_SIZE;
		if (numToRead > totalLeft)
			numToRead = totalLeft;

		NumTags = 0;
		GT668ReadTimetags(&ChanAData[0], numToRead, &NumTags, NULL, 0, NULL);
		readRtn = GT668GetError();

		if (readRtn != GT668_MEMORY_ERR)
			checkForErrors();                       /* check for driver errors    */

		totalLeft -= NumTags;
		for (dp = ChanAData; NumTags; NumTags--, dp++)
		{
			if (fp)
				fprintf(fp, "%16.10lf", *dp);
			else
				printf("%10.4lf", *dp * 1e6);
			if (last >= 0.0)
			{
				if (fp)
					fprintf(fp, "   %16.10lf", *dp - last);
				else
					printf("   %10.4lf", (*dp - last) * 1e6);
			}
			last = *dp;
			if (fp)
				fprintf(fp, "\n");
			else
				printf("\n");
		}

		if (readRtn == GT668_MEMORY_ERR)
		{
			printf("End of memory reached\n");
			break;
		}
	}
	GT668StopMeasurements();
	GT668Close();
	if (fp)
		fclose(fp);
	printf("\nTotal Samples on channel A: %8d", totalSamplesRead - totalLeft);
	printf("\n----------------------------------------------------------\n");
	if (!fp)
	{
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
