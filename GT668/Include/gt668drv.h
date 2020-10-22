#ifndef __GT668DRV_H                               /* If not already included    */
#define __GT668DRV_H                               /* define to avoid multiple   */

#include "gti_io.h"
#include "gti_util.h"

#if defined(__cplusplus)
extern "C" {
#endif

#define GT668_ERR_NO_ERROR		(0)
#define GT668_ERR_NOT_FOUND		(1)
#define GT668_ERR_NO_INFO		(2)
#define GT668_ERR_NO_CAL		(3)
#define GT668_ERR_NOT_OPEN		(4)
#define GT668_ERR_INVALID_PARAM	(5)
#define GT668_ERR_OUT_OF_MEM	(6)
#define GT668_ERR_CAL_FAIL1		(7)
#define GT668_ERR_BD_NOT_SUPP	(8)
#define GT668_PROG_ERR			(9)
#define GT668_WRAP_ERR			(10)
#define GT668_MEMORY_ERR		(11)
#define GT668_ERR_FPGA			(12)
#define GT668_ERR_FIFO_OVFL		(13)
#define GT668_ERR_BD_OPEN		(14)
#define GT668_ERR_DEV_OPEN		(15)
#define GT668_ERR_INVALID_TT	(16)
#define GT668_ERR_DEV_SKEW		(17)
#define GT668_ERR_CAL_FAIL2		(18)
#define GT668_ERR_CAL_FAIL3		(19)
#define GT668_ERR_CAL_FAIL4		(20)
#define GT668_ERR_TIMEOUT		(21)
#define GT668_ERR_SKEW			(22)
#define GT668_ERR_OLD_BD		(23)
#define GT668_ERR_SKEW_CAL		(24)
#define GT668_ERR_PLL_HW		(25)
#define GT668_ERR_PLL_LOCK_SYS	(26)
#define GT668_ERR_PLL_LOCK_CAL	(27)
#define GT668_ERR_PLL_NO_USB3	(28)

typedef enum __gti_signal_tag
{
	GT_SIG_A,
	GT_SIG_B,
	GT_SIG_CLK,
	GT_SIG_ARM
} GtiSignal;

typedef enum __gti_polarity_tag
{
	GT_POL_POS,
	GT_POL_NEG
} GtiPolarity;

typedef enum __gti_impedance_tag
{
	GT_IMP_LO,
	GT_IMP_HI
} GtiImpedance;

typedef enum __gti_coupling_tag
{
	GT_CPL_DC,
	GT_CPL_AC
} GtiCoupling;

typedef enum __gti_thrmode_tag
{
	GT_THR_PERCENTS,
	GT_THR_VOLTS
} GtiThrMode;

typedef enum __gti_prescale_tag
{
	GT_DIV_AUTO,
	GT_DIV_1,
	GT_DIV_2,
	GT_DIV_4,
	GT_DIV_8,
	GT_DIV_16,
	GT_DIV_32,
	GT_DIV_64,
	GT_DIV_128,
	GT_DIV_256,
	GT_DIV_512,
	GT_DIV_1024
} GtiPrescale;

typedef enum __gti_inputsel_tag
{
	GT_CHA_POS,
	GT_CHA_NEG,
	GT_CHB_POS,
	GT_CHB_NEG,
	GT_CLOCK,
	GT_AUX_SIG,
	GT_ARM_POS,
	GT_ARM_NEG
} GtiInputSel;

typedef enum __gti_tagarmsrc_tag
{
	GT_TA_IMM,
	GT_TA_SW,
	GT_TA_EXT,
	GT_TA_AUX,
	GT_TA_OTHER,
	GT_TA_OFF,
	GT_TA_CAL,
	GT_TA_210
} GtiTagArmSrc;

typedef enum __gti_blkarmsrc_tag
{
	GT_BA_IMM,
	GT_BA_SW,
	GT_BA_EXT,
	GT_BA_AUX,
	GT_BA_CH0,
	GT_BA_CH1,
	GT_BA_OFF
} GtiBlkArmSrc;

typedef enum __gti_armauxout_tag
{
	GT_AUX_OUT_OFF,
	GT_AUX_OUT_BA,
	GT_AUX_OUT_TA0,
	GT_AUX_OUT_TA1
} GtiArmAuxOut;

typedef enum __gti_refclksrc_tag
{
	GT_REF_INTERNAL,
	GT_REF_EXTERNAL,
	GT_REF_PXI,
	GT_REF_AUX
} GtiRefClkSrc;

typedef enum __gti_auxsig_tag
{
	GT_AUX_SIG_LOW,
	GT_AUX_SIG_HIGH,
	GT_AUX_SIG_CAL
} GtiAuxSig;

typedef enum __gti_outsrc_tag
{
	GT_OUT_REALTIME,
	GT_OUT_START,
	GT_OUT_ARM_POS,
	GT_OUT_ARM_NEG,
	GT_OUT_BA,
	GT_OUT_OTHER,
} GtiOutSrc;

typedef struct __GitRealTime_tag
{
	double fraction;
	unsigned int seconds;
	unsigned int reserved;
} GtiRealTime;

int GTAPI GT668GetBoardModel(char *buf, unsigned int buf_size);
int GTAPI GT668GetDriverVersion(char *buf, unsigned int buf_size);
GT_Bool GTAPI GT668GetBoardRevision(unsigned int *rev);
unsigned int GTAPI GT668GetFpgaCode(void);
int GTAPI GT668EnumerateBoards(GT_Bool first);
GT_Bool GTAPI GT668Initialize(int dev);
void GTAPI GT668Close(void);
GT_Bool GTAPI GT668SystemInitialize(int dev, unsigned int dev_mask);
void GTAPI GT668SystemClose(void);
GT_Bool GTAPI GT668Select(int dev);
GT_Bool GTAPI GT668IsInitialized(int dev);
GT_Bool GTAPI GT668BoardNumber(int dev, int bd);
unsigned int GTAPI GT668GetSerialNumber(void);
int GTAPI GT668GetSerialNumberStr(char *buf, unsigned int buf_size);
GT_Bool GTAPI GT668SetAUXSignal(GT_Bool enb, GtiAuxSig level);
GT_Bool GTAPI GT668IsPXI(void);
unsigned int GTAPI GT668GetMemorySize(void);
unsigned int GTAPI GT668GetCalTime(void);
GT_Bool GTAPI GT668IsMaster(void);

GT_Bool GTAPI GT668SetBaseSeconds(unsigned int sec);
unsigned int GTAPI GT668GetBaseSeconds(void);

void GTAPI GT668InitDefault(GT_Bool keep_ref);
GT_Bool GTAPI GT668SetInputImpedance(GtiSignal sig, GtiImpedance imp);
GT_Bool GTAPI GT668SetInputPrescale(GtiSignal sig, GtiPrescale presc);
GT_Bool GTAPI GT668SetInputCoupling(GtiSignal sig, GtiCoupling cpl);
GT_Bool GTAPI GT668SetInputThreshold(GtiSignal sig, GtiThrMode thr_mode, double thr_val);
GT_Bool GTAPI GT668SetMeasEnable(int ch, GT_Bool enb);
GT_Bool GTAPI GT668SetMeasGate(int ch, unsigned int cnt);
GT_Bool GTAPI GT668SetMeasInput(int ch, GtiInputSel sel);
GT_Bool GTAPI GT668SetMeasSkip(int ch, unsigned int rate);
GT_Bool GTAPI GT668SetMeasTagArm(int ch, GtiTagArmSrc src, GtiPolarity pol);
GT_Bool GTAPI GT668SetBlockArm(GtiBlkArmSrc src, GtiPolarity pol, GT_Bool level);
GT_Bool GTAPI GT668SetArmAuxOut(GtiArmAuxOut aux_out);
GT_Bool GTAPI GT668SetReferenceClock(GtiRefClkSrc src, GT_Bool ref_5MHz, GT_Bool aux_out);
GT_Bool GTAPI GT668SetMemoryWrapMode(GT_Bool wrap);
GT_Bool GTAPI GT668SetT0Mode(GT_Bool enb, GT_Bool rel);

GT_Bool GTAPI GT668IsRealTimeSet(void);
GT_Bool GTAPI GT668SetRealTimeStart(unsigned int sec, GT_Bool sync);
GT_Bool GTAPI GT668SetRealTimeEnd(void);
GT_Bool GTAPI GT668SetRealTimeIsDone(void);
GT_Bool GTAPI GT668SetRealTime(unsigned int sec, GT_Bool sync);
GT_Bool GTAPI GT668GetRealTime(unsigned int *sec);
GT_Bool GTAPI GT668SetOutput(int out, GtiOutSrc src, GtiPolarity pol, double width, double delay);
GT_Bool GTAPI GT668GetRealTimeOutputStatus(unsigned int *used0, unsigned int *used1);
GT_Bool GTAPI GT668GetRealTimeOutputMaxPend(unsigned int *max_pending);
GT_Bool GTAPI GT668RealTimeOutput(int out, unsigned int sec, double frac);

GT_Bool GTAPI GT668StartMeasurements(void);
GT_Bool GTAPI GT668StopMeasurements(void);
GT_Bool GTAPI GT668BlockArmCommand(GT_Bool arm);
GT_Bool GTAPI GT668TagArmCommand(GT_Bool ch0, GT_Bool ch1);
GT_Bool GTAPI GT668ReadRaw(void *Buf, unsigned int offset, unsigned int ToRead, unsigned int *ActRead);
GT_Bool GTAPI GT668ReadTimetags(double *pTags0, unsigned int NumTags0, unsigned int *ActNumTags0, double *pTags1, unsigned int NumTags1, unsigned int *ActNumTags1);
GT_Bool GTAPI GT668ConvertRawToTimetags(void *pRawBuf, unsigned int tags_cnt, unsigned int *tags_used, double *pTags0, unsigned int NumTags0, unsigned int *ActNumTags0, double *pTags1, unsigned int NumTags1, unsigned int *ActNumTags1);
GT_Bool GTAPI GT668ReadTimetagsEx(GtiRealTime *pTags0, unsigned int NumTags0, unsigned int *ActNumTags0, GtiRealTime *pTags1, unsigned int NumTags1, unsigned int *ActNumTags1);
GT_Bool GTAPI GT668ConvertRawToTimetagsEx(void *pRawBuf, unsigned int tags_cnt, unsigned int *tags_used, GtiRealTime *pTags0, unsigned int NumTags0, unsigned int *ActNumTags0, GtiRealTime *pTags1, unsigned int NumTags1, unsigned int *ActNumTags1);
GT_Bool GTAPI GT668ReadTTUnpacked(unsigned int *pSec0, double *pFrac0, unsigned int NumTags0, unsigned int *ActNumTags0, unsigned int *pSec1, double *pFrac1, unsigned int NumTags1, unsigned int *ActNumTags1);
GT_Bool GTAPI GT668ConvertRawToTTUnpacked(void *pRaw, unsigned int tags_cnt, unsigned int *tags_used, unsigned int *pSec0, double *pFrac0, unsigned int NumTags0, unsigned int *ActNumTags0, unsigned int *pSec1, double *pFrac1, unsigned int NumTags1, unsigned int *ActNumTags1);

GT_Bool GTAPI GT668GetActualInputThreshold(GtiSignal sig, double *thr);
GT_Bool GTAPI GT668GetInputImpedance(GtiSignal sig, GtiImpedance *imp);
GT_Bool GTAPI GT668GetInputCoupling(GtiSignal sig, GtiCoupling *cpl);
GT_Bool GTAPI GT668GetInputPrescale(GtiSignal sig, GtiPrescale *presc);
GT_Bool GTAPI GT668GetInputThreshold(GtiSignal sig, GtiThrMode *thr_mode, double *thr_val);
GT_Bool GTAPI GT668GetMeasEnable(int ch, GT_Bool *enb);
GT_Bool GTAPI GT668GetMeasGate(int ch, unsigned int *cnt);
GT_Bool GTAPI GT668GetMeasInput(int ch, GtiInputSel *sel);
GT_Bool GTAPI GT668GetMeasSkip(int ch, unsigned int *rate);
GT_Bool GTAPI GT668GetMeasTagArm(int ch, GtiTagArmSrc *src, GtiPolarity *pol);
GT_Bool GTAPI GT668GetBlockArm(GtiBlkArmSrc *src, GtiPolarity *pol, GT_Bool *level);
GT_Bool GTAPI GT668GetArmAuxOut(GtiArmAuxOut *aux_out);
GT_Bool GTAPI GT668GetReferenceClock(GtiRefClkSrc *src, GT_Bool *ref_5MHz, GT_Bool *aux_out);
GT_Bool GTAPI GT668GetMemoryWrapMode(GT_Bool *wrap);
GT_Bool GTAPI GT668GetT0Mode(GT_Bool *arm, GT_Bool *rel);
GT_Bool GTAPI GT668GetTotalPrescale(int ch, unsigned int *presc);
GT_Bool GTAPI GT668GetT0(double *t0);
GT_Bool GTAPI GT668GetT0Ex(unsigned int *t0sec, double *t0frac);
GT_Bool GTAPI GT668SelfCal(void);
GT_Bool GTAPI GT668MeasureAmplitude(GtiSignal sig, double *posv, double *negv, double minFreq);
GT_Bool GTAPI GT668MeasurePeaksStart(GtiSignal sig, double minFreq);
int GTAPI GT668MeasurePeaksDone(GtiSignal sig, double *pos, double *neg);
GT_Bool GTAPI GT668AutoPrescale(int ch, GtiPrescale *presc);
int GTAPI GT668GetError(void);

int GTAPI GT668GetErrorMessage(int err, char *buf, unsigned int buf_size);
void GTAPI GT668ClearError(void);

double GTAPI GT668ReadSysTime(void);

GT_Bool GTAPI GT668CheckAUX(unsigned int dev_mask);
GT_Bool GTAPI GT668BoardsSkewSelfCal(unsigned int dev_mask);
double GTAPI GT668GetBoardsSkewCal(int cur_dev, unsigned int dev_mask, GT_Bool aux_ref, double *skew);

#ifdef __cplusplus
}
#endif

#endif

