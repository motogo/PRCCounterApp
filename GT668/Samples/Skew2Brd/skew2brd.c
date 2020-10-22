/* 
** Source code illustrating skew measurement between channel A on two boards
** Reference should be connected to the first board (or to the PXI chassis
** if USE_PXI_REF is set to 1).
**
** Usage: skew2brd <bd1> <bd2> [<presc>]
**           bd1    First board
**           bd2    Second board
**           presc  Prescale value (1, 2, 4, 8, 16, 32, 64, 128, 256, 512, or 1024)
*/
#ifdef LINUX
#include <termios.h>
#include <unistd.h>
#include <fcntl.h>
#else
#include <conio.h>
#endif
#include <math.h>
#include "gt668drv.h"

#define USE_PXI_REF	(0)		// Set to 1 to use PXI reference
#define NUM_MEAS (1000)		// Number of measurements

typedef struct _mux_table
{
    GtiPrescale scale;
    int value;
} MUX_TABLE;

MUX_TABLE presc_table[] =
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

int dev1 = -1, dev2 = -1;
double skew_tags[2][NUM_MEAS];

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

void checkForErrors(void)
{
	char msg[128];
	int err;

	err = GT668GetError();
	if (!err)
		return;

	GT668GetErrorMessage(err, msg, sizeof(msg));
	printf("Error #%d: %s\n", err, msg);
	printf("Hit any key to exit...");
	_getch();
	GT668Close();
	exit(0);
}

int main(int argc, char *argv[])
{
	int i;
	double sum, sum2, first, period, skew, stddev, st, skew_cal = 0.0;
	unsigned int offset[2], act_read[2], mask;
	GtiPrescale presc = GT_DIV_1;
	int scl_val = 1;

	if (argc != 3 && argc != 4)
	{
		printf("\nUsage: skew2bd <bd1> <bd2> [<prescale>]\n");
		return -1;
	}
	dev1 = atoi(argv[1]);
	dev2 = atoi(argv[2]);
	if (dev1 < 0 || dev2 < 0)
	{
		printf("\nBoard number cannot be negative.\n");
		return -1;
	}
	if (dev1 == dev2)
	{
		printf("\nBoard numbers must be different.\n");
		return -1;
	}
	if (argc == 4)
	{
		scl_val = atoi(argv[3]);
		for (i = 0; i < sizeof(presc_table)/sizeof(presc_table[0]); i++)
			if (presc_table[i].value == scl_val)
				break;
		if (i < sizeof(presc_table)/sizeof(presc_table[0]))
			presc = presc_table[i].scale;
		else
		{
			printf("\nInvalid prescale value %d, should be %d to %d\n", scl_val, presc_table[0].value, presc_table[i-1].value);
			return -1;
		}
	}

	printf("\nInitalized all system boards\n");
	i = GT668EnumerateBoards(GT_True);
	mask = 0;
	while (i >= 0)
	{
		mask |= (1 << i);
		i = GT668EnumerateBoards(GT_False);
	}

	for (i = 0; i < 32; i++)
	{
		if (mask & (1 << i))
		{
			printf("\nInitialize board %d", i);
			GT668Initialize(i);
			GT668SetAUXSignal(GT_False, GT_AUX_SIG_LOW);
		}
	}

	printf("\nCalibrate board %d", dev1);
	GT668Select(dev1);
	GT668SelfCal();
	checkForErrors();

	printf("\nCalibrate board %d", dev2);
	GT668Select(dev2);
	GT668SelfCal();
	checkForErrors();

	printf("\nCalibrate board %d to board %d skew", dev1, dev2);
	GT668Select(dev1);
	GT668BoardsSkewSelfCal((1 << dev1)|(1 << dev2));

	printf("\nSetup board %d", dev1);
	GT668Select(dev1);

	GT668InitDefault(GT_True);
	GT668SetInputImpedance(GT_SIG_A, GT_IMP_LO);
	GT668SetInputPrescale(GT_SIG_A, presc);
	GT668SetInputCoupling(GT_SIG_A, GT_CPL_DC);
	GT668SetInputThreshold(GT_SIG_A, GT_THR_VOLTS, 0.0);
	GT668SetMeasInput(0, GT_CHA_POS);
	GT668SetMeasSkip(0, 0);
	GT668SetMeasTagArm(0, GT_TA_IMM, GT_POL_POS);
	GT668SetBlockArm(GT_BA_CH0, GT_POL_NEG, GT_False);
	GT668SetT0Mode(GT_False, GT_False);
	GT668SetArmAuxOut(GT_AUX_OUT_BA);
#if USE_PXI_REF
	GT668SetReferenceClock(GT_REF_PXI, GT_False, GT_False);
#else
	GT668SetReferenceClock(GT_REF_EXTERNAL, GT_False, GT_True);
#endif
	GT668SetMemoryWrapMode(GT_False);
	GT668SetMeasEnable(0, GT_True);
	GT668SetMeasEnable(1, GT_False);
	GT668SetAUXSignal(GT_False, GT_AUX_SIG_LOW);

	printf("\nSetup board %d", dev2);
	GT668Select(dev2);

	GT668InitDefault(GT_True);
	GT668SetInputImpedance(GT_SIG_A, GT_IMP_LO);
	GT668SetInputPrescale(GT_SIG_A, presc);
	GT668SetInputCoupling(GT_SIG_A, GT_CPL_DC);
	GT668SetInputThreshold(GT_SIG_A, GT_THR_VOLTS, 0.0);
	GT668SetMeasInput(0, GT_CHA_POS);
	GT668SetMeasSkip(0, 0);
	GT668SetMeasTagArm(0, GT_TA_IMM, GT_POL_POS);
	GT668SetBlockArm(GT_BA_AUX, GT_POL_POS, GT_False);
	GT668SetT0Mode(GT_False, GT_False);
	GT668SetArmAuxOut(GT_AUX_OUT_OFF);
#if USE_PXI_REF
	GT668SetReferenceClock(GT_REF_PXI, GT_False, GT_False);
#else
	GT668SetReferenceClock(GT_REF_AUX, GT_False, GT_False);
#endif
	GT668SetMemoryWrapMode(GT_False);
	GT668SetMeasEnable(0, GT_True);
	GT668SetMeasEnable(1, GT_False);
	GT668SetAUXSignal(GT_False, GT_AUX_SIG_LOW);

	// Get inter board skew factor
	GT668GetBoardsSkewCal(dev1, 1 << dev2, GT_False, &skew_cal);

	printf("\nMeasure skew of board %d to board %d = ", dev1, dev2);
	GT668Select(dev2);
	GT668StartMeasurements();

	GT668Select(dev1);
	GT668StartMeasurements();

	st = GT668ReadSysTime();
	offset[0] = 0;
	offset[1] = 0;
	act_read[0] = 0;
	act_read[1] = 0;
	while (offset[0] < sizeof(skew_tags[0])/sizeof(skew_tags[0][0]) || offset[1] < sizeof(skew_tags[0])/sizeof(skew_tags[0][0]))
	{
		if (sizeof(skew_tags[0])/sizeof(skew_tags[0][0]) > offset[0])
		{
			GT668Select(dev1);
			GT668ReadTimetags(&skew_tags[0][offset[0]], sizeof(skew_tags[0])/sizeof(skew_tags[0][0]) - offset[0], &act_read[0], NULL, 0, NULL);
			offset[0] += act_read[0];
		}
		if (sizeof(skew_tags[1])/sizeof(skew_tags[1][0]) > offset[1])
		{
			GT668Select(dev2);
			GT668ReadTimetags(&skew_tags[1][offset[1]], sizeof(skew_tags[1])/sizeof(skew_tags[1][0]) - offset[1], &act_read[1], NULL, 0, NULL);
			offset[1] += act_read[1];
		}
		if (GT668ReadSysTime() - st > 3.0)
			break;
	}

	if (offset[0] < sizeof(skew_tags[0])/sizeof(skew_tags[0][0]) || offset[1] < sizeof(skew_tags[0])/sizeof(skew_tags[0][0]))
	{
		printf("\nTimeout.\n");
		GT668Select(dev1);
		GT668Close();
		GT668Select(dev2);
		GT668Close();
		return -1;
	}

	GT668Select(dev1);
	GT668StopMeasurements();
	GT668Select(dev2);
	GT668StopMeasurements();

	sum = (skew_tags[0][sizeof(skew_tags[0])/sizeof(skew_tags[0][0]) - 1] - skew_tags[0][0]) / (double)(sizeof(skew_tags[0])/sizeof(skew_tags[0][0]) - 1);
	sum += (skew_tags[1][sizeof(skew_tags[0])/sizeof(skew_tags[0][0]) - 1] - skew_tags[1][0]) / (double)(sizeof(skew_tags[0])/sizeof(skew_tags[0][0]) - 1);
	period = sum * 0.5 / (double)scl_val;

	sum = 0.0;
	sum2 = 0.0;
	first = skew_tags[1][0] - skew_tags[0][0];
	for (i = 0; i < sizeof(skew_tags[0])/sizeof(skew_tags[0][0]); i++)
	{
		double v = skew_tags[1][i] - skew_tags[0][i];
		v -= first;
		sum += v;
		sum2 += v * v;
	}
	skew = sum / (double)i;
	stddev = (sum2 - skew * sum) / (double)(i - 1);
	if (stddev > 0.0)
		stddev = sqrt(stddev);
	else
		stddev = 0.0;
	skew += first;
	skew -= skew_cal;

	if (skew > 0.5 * period)
	{
		i = (int)(skew / period + 0.5);
		skew -= (double)i * period;
	}
	else if (skew <= -0.5 * period)
	{
		i = (int)(-skew / period + 0.5);
		skew += (double)i * period;
	}

	printf("%.5lf ps (jitter = %.5lf ps)\n", skew * 1e12, stddev * 1e12);

	for (i = 0; i < 32; i++)
	{
		if (mask & (1 << i) && i != dev1 && i != dev2)
			GT668Close();
	}
	GT668Select(dev1);
	GT668Close();
	GT668Select(dev2);
	GT668Close();
	printf("\nHit any key to exit...");
	_getch();
	return 0;
}
