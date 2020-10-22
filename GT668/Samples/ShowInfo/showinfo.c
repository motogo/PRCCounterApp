#include <stdio.h>
#include <math.h>
#include <stdlib.h>                             /* needed for USAGE()         */
#include <string.h>                             /* needed for USAGE()         */
#include <time.h>
#ifdef LINUX
#include <termios.h>
#include <unistd.h>
#include <fcntl.h>
#else
#include <conio.h>
#endif

#include "gt668drv.h"
#include "gt_sys.h"

/*----------------------------------------------------------------------------*/
/*                          Function Declarations                             */
/*----------------------------------------------------------------------------*/

extern  void usage(char *run_file);
extern  void checkForErrors(void );

/*----------------------------------------------------------------------------*/
/*                                #defines                                    */
/*----------------------------------------------------------------------------*/



/*----------------------------------------------------------------------------*/
/*                               Variables                                    */
/*----------------------------------------------------------------------------*/

#ifdef LINUX
int _getch(void)
{
	return getchar();
}
#endif

/*----------------------------------------------------------------------------*/
/*                                  main()                                    */
/*----------------------------------------------------------------------------*/
/*
** argv[0] = program
** argv[1] = board
*/
int main(int argc,char *argv[])
{
	int tdb = 0;
	int dev = -1;
	char drv_rev[64], model[256], *s;
	unsigned int rev, sn, mem_size, fpga, cal;
	struct tm *ptime;
	time_t t;
/*
**************************** PARSE THE COMMAND LINE ***************************
*/
	if(argc > 2)
	{
		usage(argv[0]);
		exit(0);
	}

	if (argc < 2)
		dev = GT668EnumerateBoards(GT_True);
	else
	{
		if (argv[1][0] >= '0' && argv[1][0] <= '9')
			dev = atoi(argv[1]);
		else if (GTSysInitialize(0, argv[1]))
			tdb = 1;
	}
	if ((dev < 0 || dev > 31) && !tdb)
	{
		usage(argv[0]);
		exit(0);
	}

	if (tdb)
	{
        GTSysGetSerialNumber(&sn);
        GTSysGetHWRevision(&rev);
        GTSysGetFpgaRevision(&fpga);
		GTSysClose();

		printf("\n\nTDB");
		printf("\nSerial Number: %u", sn);
		printf("\nH/W Revision: %u", rev);

		t = (time_t)fpga;
		ptime = gmtime((const time_t *)&t);
		s = asctime(ptime);
		printf("\nFPGA Date (UTC): %s", s);
	}
	else
	{
		while(dev >= 0)
		{
			GT668Initialize(dev);

			sn = GT668GetSerialNumber();
			GT668GetBoardModel(model, sizeof(model));
			GT668GetBoardRevision(&rev);
			GT668GetDriverVersion(drv_rev, sizeof(drv_rev));
			mem_size = GT668GetMemorySize();
			fpga = GT668GetFpgaCode();
			cal = GT668GetCalTime();
			checkForErrors();

			GT668Close();

			printf("\n\nDevice #%d", dev);
			printf("\nBoard Model: %s", model);
			printf("\nSerial Number: %u", sn);
			printf("\nH/W Revision: %u", rev);
			printf("\nDriver Revision: %s", drv_rev);

			t = (time_t)fpga;
			ptime = gmtime((const time_t *)&t);
			s = asctime(ptime);
			printf("\nFPGA Date (UTC): %s", s);

			t = (time_t)cal;
			ptime = gmtime((const time_t *)&t);
			s = asctime(ptime);
			printf("Factory Cal (UTC): %s", s);

			printf("Memory Size: %uMB\n\n", mem_size / 1024 /1024);

			if (argc < 2)
				dev = GT668EnumerateBoards(GT_False);
			else
				break;
		}
	}
	printf("\nHit any key to exit...");
	_getch();
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
	printf("This program shows information about one or all boards\n\n");
	printf("Usage: %s [<board>]\n\n",basename);
	printf("where\n");
	printf("   <board>         board number - all boards if argument is missing\n");
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
