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

extern  void prepareInstrument(void );
extern  void showChannelSampleCounts(void );
extern  void displayOneChannel(void );
extern  void usage(char *run_file);
extern  void checkForErrors(void );
extern  void getCommandLineArgs(int argc,char * *argv);

/*----------------------------------------------------------------------------*/
/*                                #defines                                    */
/*----------------------------------------------------------------------------*/

#define ARRAY_SIZE        128L                  /* samples to acquire         */


/*----------------------------------------------------------------------------*/
/*                               Variables                                    */
/*----------------------------------------------------------------------------*/
/*
** Data variables
*/ 
double			TimeData[2][ARRAY_SIZE]; /* Array holding Time tags    */
unsigned int	TagsCount[2];

/*
** Command line arguments
*/
double             Threshold;                   /* channel threshold          */
int              Use50Ohms;                   /* 1 = 50 ohm termination     */
int              Board = 0;

double Timeout;

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
** argv[1] = board
** argv[2] = channel threshold
** argv[3] = optional 50 ohm termination
*/
int main(int argc,char *argv[])
{
	double start_time;
	unsigned int num_tags[2];

/*
**************************** PARSE THE COMMAND LINE ***************************
*/
	if(argc < 4)                                 /* Must have the min args     */
	{
		usage(argv[0]);
		exit(0);
	}

	getCommandLineArgs(argc, argv);
/*
**************************** INITIALIZE INSTRUMENT ***************************
*/
	prepareInstrument();                         /* setup the instrument       */
	checkForErrors();                       /* check for driver errors    */

/*
***************************** MAKE MEASUREMENTS ******************************
*/
	while(!_kbhit())
	{
		printf("Waiting for measurements (any key to abort)...\n");
		printf("--------------------------------------------------------");
		printf("-----------------------\n");
		GT668StartMeasurements();                    /* reset measurement memory   */
		start_time = GT668ReadSysTime();
		TagsCount[0] = 0;
		TagsCount[1] = 0;

		do
		{
			num_tags[0] = 0;
			num_tags[1] = 0;
			GT668ReadTimetags(&TimeData[0][TagsCount[0]], ARRAY_SIZE - TagsCount[0], &num_tags[0], &TimeData[1][TagsCount[1]], ARRAY_SIZE - TagsCount[1], &num_tags[1]);
			TagsCount[0] += num_tags[0];
			TagsCount[1] += num_tags[1];
		}
		while ((TagsCount[0] < ARRAY_SIZE || TagsCount[1] < ARRAY_SIZE) && GT668ReadSysTime() - start_time < Timeout);

		checkForErrors();					/* Timeout?                   */

		showChannelSampleCounts();				/* Show number of points      */
												/* acquired on each channel   */

		displayOneChannel();					/* show time interval for     */
												/* just one channel           */
		printf("--------------------------------------------------------");
		printf("-----------------------\n");
    
		printf("waiting 2 seconds for your convenience (holding the display)\n");
		Sleep(2000);
	}
	GT668Close();
	return 0;
}
/*----------------------------------------------------------------------------*/
/*                              prepareInstrument()                           */
/*----------------------------------------------------------------------------*/
void prepareInstrument(void)
{
	printf("Initializing and calibrating the instrument...\n");
	GT668Initialize(Board);
	GT668SelfCal();

	printf("   Channel threshold set to %7.3lf [Volts]\n",Threshold);
	GT668SetInputThreshold(GT_SIG_A, GT_THR_VOLTS, Threshold);
	GT668SetInputThreshold(GT_SIG_B, GT_THR_VOLTS, Threshold);

	printf("   Input impedance set to 50 Ohm termination\n");
	GT668SetInputImpedance(GT_SIG_A, Use50Ohms ? GT_IMP_LO : GT_IMP_HI);
	GT668SetInputImpedance(GT_SIG_B, Use50Ohms ? GT_IMP_LO : GT_IMP_HI);

	/*
	** Set timeout time to 5.0 seconds.
	*/
	Timeout = 5.0;
}


/*----------------------------------------------------------------------------*/
/*                           showChannelSampleCounts()                        */
/*----------------------------------------------------------------------------*/
/* 
** Display the total number of time tags received and the number received
** on each channel.
*/
void showChannelSampleCounts(void)
{
	int      chan;

	printf("Total number of time tags: %10d\n", TagsCount[0] + TagsCount[1]);
	for(chan = 0; chan < 2; chan++)
		printf("Points For Channel %d: %d\n",chan,TagsCount[ chan ]);
	printf("===========================================================");
	printf("====================\n");
}
/*----------------------------------------------------------------------------*/
/*                            displayOneChannel()                             */
/*----------------------------------------------------------------------------*/
/*
** Display time interval data for the first channel that contains data.
*/
void displayOneChannel(void)
{
	unsigned int  lindex, end_index;
	int      chan;

	double     diff1;
	unsigned int    samplesRead;

	for(chan = 0; chan < 2; chan++)
	{
		samplesRead = TagsCount[chan];
		if( samplesRead > 0L )
			break;
	}
	if( chan == 2 )              /* if no points for any chan  */
		return;

	end_index = 4L;
	if(samplesRead < 4L)
		end_index = samplesRead;

	/*
	** Display the first 4 points in UnpackedData[]
	*/
	printf("\n");
	printf("Data points for Channel: %d\n",chan);
	printf("Index       Time Tag [uS]    Time Interval [uS] \n");
	printf("================================================\n");
	for(lindex = 0; lindex < end_index; lindex++)
	{
		if(lindex == 0L) 
		{
			printf("%5d    %16.3lf\n", lindex,TimeData[chan][lindex] * 1.0e6);
		}
		else
		{
			diff1 = (TimeData[chan][lindex] - TimeData[chan][lindex - 1]) * 1.0e6;
			printf("%5d    %16.3lf      %16.3lf\n", lindex, (TimeData[chan][lindex] * 1.0e6),diff1);
		}
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
	printf("This program acquires data on either channel and displays ");
	printf("the number of time\n");
	printf("tags acquired.  The time interval of the first few samples ");
	printf("is also displayed.\n\n");
	printf("Usage: %s <board> <design path> <threshold> [50 Ohms]\n\n",basename);
	printf("where\n");
	printf("   <board>         board number\n");
	printf("   <threshold>     Channel threshold for all channels\n");
	printf("   [50 Ohms]       If a '1' is placed in this optional");
	printf(" parameter location\n");
	printf("                   then 50 Ohm termination is enabled (2 channel models)\n");

	printf("\nExamples:\n\n");
	printf("   %s  0  1.4   \n",basename);
	printf("   %s  0  0.0   1\n",basename);
}
/*----------------------------------------------------------------------------*/
/*                             checkForErrors()                          */
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
/*----------------------------------------------------------------------------*/
/*                           getCommandLineArgs()                             */
/*----------------------------------------------------------------------------*/
void getCommandLineArgs(int argc, char *argv[])
{
	sscanf(argv[1],"%d",&Board);
	sscanf(argv[2],"%lf",&Threshold);            /* get channel threshold      */

	Use50Ohms = 0;                               /* default to 1Meg input      */
	if(argc > 3)                                 /* If optional parameters     */
	{
		if( argv[3][0] == '1' )                  /* if use 50 ohm impedance    */
			Use50Ohms = 1;
	}
}
