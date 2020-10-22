#include <stdio.h>
#include <math.h>
#include <stdlib.h>                             /* needed for USAGE()         */
#include <string.h>                             /* needed for USAGE()         */
#ifdef LINUX
#include <termios.h>
#include <unistd.h>
#include <fcntl.h>
#else
#include <conio.h>
#endif

#include "gt668drv.h"

/*----------------------------------------------------------------------------*/
/*                          Function Declarations                             */
/*----------------------------------------------------------------------------*/

extern  int main(int argc,char *argv[]);
extern  void measureChannelParameters(int chan);
extern  void usage(char *run_file);
extern  void checkForErrors(void );
/*----------------------------------------------------------------------------*/
/*                                 #defines                                   */
/*----------------------------------------------------------------------------*/

#define ARRAY_SIZE      128L                    /* # of samples to acquire    */

/*----------------------------------------------------------------------------*/
/*                               Variables                                    */
/*----------------------------------------------------------------------------*/

double				TimeData[ARRAY_SIZE]; /* Array holding Time tags    */
unsigned int		TagsCount;
double				Timeout;

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

/*----------------------------------------------------------------------------*/
/*                                  main()                                    */
/*----------------------------------------------------------------------------*/
/*
** argv[0] = program
** argv[1] = board number
** argv[2] = optional 50 ohm termination (for 2 channel models)
*/
int main(int argc,char *argv[])
{
	int      board;
	int      use50Ohms;                        /* use 50 ohms flag           */
	int      chan;

/*
**************************** PARSE THE COMMAND LINE ***************************
*/
	if(argc < 2)                                 /* check argument count       */
	{
		usage(argv[0]);
		exit(0);
	}

	sscanf(argv[1],"%d",&board);

/*
*************************** Prepare the Instrument ****************************
*/
	printf("Initializing and calibrating the instrument...\n");
	GT668Initialize(board);
	checkForErrors();                       /* check for driver errors    */

	GT668SelfCal();
	checkForErrors();                       /* check for driver errors    */

	GT668SetMeasInput(0, GT_CHA_POS);
	GT668SetMeasInput(1, GT_CHB_POS);
	GT668SetInputPrescale(GT_SIG_A, GT_DIV_1);
	GT668SetInputPrescale(GT_SIG_B, GT_DIV_1);
	GT668SetInputThreshold(GT_SIG_A, GT_THR_VOLTS, 0.0);
	GT668SetInputThreshold(GT_SIG_B, GT_THR_VOLTS, 0.0);
	GT668SetInputImpedance(GT_SIG_A, GT_IMP_HI);
	GT668SetInputImpedance(GT_SIG_B, GT_IMP_HI);
	GT668SetInputCoupling(GT_SIG_A, GT_CPL_DC);
	GT668SetInputCoupling(GT_SIG_B, GT_CPL_DC);
	GT668SetMeasSkip(0, 0);
	GT668SetMeasSkip(1, 0);
	GT668SetReferenceClock(GT_REF_INTERNAL, GT_False, GT_False);
	GT668SetInputThreshold(GT_SIG_CLK, GT_THR_VOLTS, 0.0);

	use50Ohms = 0;
	if(argc == 3)
	{
		if( argv[2][0] == '1' )                   /* if use 50 ohm impedance    */
			use50Ohms = 1;
	}

	if( use50Ohms == 1)
	{
		GT668SetInputImpedance(GT_SIG_A, GT_IMP_LO);
		GT668SetInputImpedance(GT_SIG_B, GT_IMP_LO);
	}

/*
***************************** MAKE MEASUREMENTS ******************************
*/
	Timeout = 2.5;                          /* set the timeout to 2.5 Sec   */
	while(!_kbhit())
	{
		printf("\n");
		printf("+---------+---------------------------------+-----------");
		printf("-------------+\n");
		printf("|         |          Input Signal           |      Input");
		printf(" Signal      |\n");
		printf("| Channel |   Center   Pos Peak   Neg Peak  |  End point");
		printf(" Frequency   |\n");
		printf("+=========+=================================+===========");
		printf("=============+\n");
		for(chan = 0; chan < 2; chan++)
		{
			measureChannelParameters(chan);        /* measure channel 'chan'     */
		}
		measureChannelParameters(2); /* measure the clock SMA      */
		measureChannelParameters(3); /* measure the arm SMA        */
		printf("+---------+---------------------------------+-----------");
		printf("-------------+\n");
		Sleep(2000);
		checkForErrors();
	}
	GT668Close();
	return 0;
}
/*----------------------------------------------------------------------------*/
/*                          measureChannelParameters()                        */
/*----------------------------------------------------------------------------*/
void measureChannelParameters(int chan)
{
	double center,                               /* current threshold setting  */
           pos,                                  /* pos peak input voltage     */
           neg,                                  /* neg peak input voltage     */
           freq,                                 /* computed frequency         */
		   start_time;

	int   measure_freq,                          /* measure frequency flag     */
          i;                                     /* temporary int              */
    unsigned int prescale;

	/*
	** Measure channel peak to peak voltage and center the threshold between
	** the peaks
	*/
	GT668MeasureAmplitude((GtiSignal)chan, &pos, &neg, 1000.0);
	checkForErrors();                       /* check for driver errors    */
	center = (pos+neg)/2.0;
	GT668SetInputThreshold((GtiSignal)chan,GT_THR_VOLTS,center);

	prescale = 1;
	if( chan >= 0 && chan < 2 )                /* if standard measure chan   */
	{
		measure_freq = 1;

		GT668SetInputPrescale((GtiSignal)chan, GT_DIV_AUTO);

		printf("|    %2d   |  %7.3lf    %7.3lf    %7.3lf  |",chan,center,pos,neg);
		for( i = 0; i < 2; i++)
		{
			if( i != chan )
				GT668SetMeasEnable(i, GT_False);
			else
				GT668SetMeasEnable(i, GT_True);
		}
	}
	else                                         /* if arm or clk channel      */
	{
		measure_freq = 0;                         /* can't measure freq on arm  */
                                                /* and clock                  */
		switch(chan)
		{
		case 3:  
			printf("|   ARM   |");
			break;
		case 2:  
			printf("|   CLK   |");
			break;
		}
		printf("  %7.3lf    %7.3lf    %7.3lf  |",center,pos,neg);
	}

/*
** If measure frequency, then make a time measurement
*/
	if(measure_freq == 1)                        /* if measure frequency       */
	{
		if( pos-neg > 0.4 )                       /* if there appears to be     */
		{                                      /* something there            */
			GT668StartMeasurements();                    /* reset measurement memory   */
			start_time = GT668ReadSysTime();
			TagsCount = 0;

			do
			{
				unsigned int num_tags;
				num_tags = 0;
				if (chan == 0)
					GT668ReadTimetags(&TimeData[TagsCount], ARRAY_SIZE - TagsCount, &num_tags, NULL, 0, NULL);
				else
					GT668ReadTimetags(NULL, 0, NULL, &TimeData[TagsCount], ARRAY_SIZE - TagsCount, &num_tags);
				TagsCount += num_tags;
			}
			while (TagsCount < ARRAY_SIZE && GT668ReadSysTime() - start_time < Timeout);

			GT668GetTotalPrescale(chan, &prescale);
			/*
			** Slow signals will timeout.  If there are enough samples then
			** compute the frequency.
			*/
   
			if(TagsCount > 1L)              /* if more than 1 sample     */
			{ 
				freq = ((double)prescale)/((TimeData[TagsCount-1]-TimeData[0]) 
								/ ((double)(TagsCount-1)) );
				printf("  %13.3lf [Hz]    |\n",freq);
            } 
			else                                   /* if insufficient samples    */
			{
				printf("           No Signal    |\n");
			}
		}
		else
		{
			if( fabs(center) > 0.2 )               /* if DC Signal               */
			{
				printf("           DC Signal    |\n");
			}
			else
			{
				printf("           No Signal    |\n");
			}
		}
	}
	else                                         /* if ARM/CLOCK signal        */
	{
		printf("                        |\n");
	}
}
/*----------------------------------------------------------------------------*/
/*                                  usage()                                   */
/*----------------------------------------------------------------------------*/
void usage(char *run_file)
{
	char  *basename;

	basename = strrchr(run_file,0x5C);
	if (basename)
		basename++;
	else
		basename = run_file;
	printf("\n");
	printf("This program evaluates what is present at the inputs of the");
	printf(" instrument.");

	printf("\n\n");
	printf("Usage: %s <board> [50 Ohms]\n\n",basename);
	printf("   where\n");
	printf("\n");
	printf("       <board>          Board number\n");
	printf("       [50 Ohms]        If a '1' is placed in this optional");
	printf(" parameter location\n");
	printf("                        then 50 Ohm termination is enabled (2 channel models)\n");
	printf("\nExample:\n\n");
	printf("    %s 0\n",basename);
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
