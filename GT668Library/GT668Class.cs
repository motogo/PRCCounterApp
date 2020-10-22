using Enums;
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace GT668Library
{
    public class GT668Class
    {

        public const int GT668_ERR_NO_ERROR = 0;

        public const int GT668_ERR_NOT_FOUND = 1;
        public const int GT668_ERR_NO_INFO = 2;
        public const int GT668_ERR_NO_CAL = 3;
        public const int GT668_ERR_NOT_OPEN = 4;
        public const int GT668_ERR_INVALID_PARAM = 5;
        public const int GT668_ERR_OUT_OF_MEM = 6;
        public const int GT668_ERR_CAL_FAIL = 7;
        public const int GT668_ERR_BD_NOT_SUPP = 8;
        public const int GT668_PROG_ERR = 9;
        public const int GT668_WRAP_ERR = 10;
        public const int GT668_MEMORY_ERR = 11;
        public const int GT668_ERR_FPGA = 12;
        public const int GT668_ERR_FIFO_OVFL = 13;
        public const int GT668_ERR_BD_OPEN = 14;
        public const int GT668_ERR_DEV_OPEN = 15;
        public const int GT668_ERR_INVALID_TT = 16;
        public const int GT668_ERR_DEV_SKEW = 17;
        public const int GT668_ERR_CAL_FAIL2 = 18;
        public const int GT668_ERR_CAL_FAIL3 = 19;
        public const int GT668_ERR_CAL_FAIL4 = 20;
        public const int GT668_ERR_TIMEOUT = 21;
        public const int GT668_ERR_SKEW = 22;
        public const int GT668_ERR_OLD_BD = 23;
        public const int GT668_ERR_SKEW_CAL = 24;
        public const int GT668_ERR_PLL_HW = 25;
        public const int GT668_ERR_PLL_LOCK_SYS = 26;
        public const int GT668_ERR_PLL_LOCK_CAL = 27;

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GT668EnumerateBoards(bool first);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668Initialize(int dev);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668IsInitialized(int dev);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern void GT668Close();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SystemInitialize(int dev, uint dev_mask);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern void GT668SystemClose();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668Select(int dev);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668BoardNumber(int dev, int bd);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern uint GT668GetSerialNumber();

        [DllImport("GT668.DLL", EntryPoint = "GT668GetSerialNumberStr", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GT668GetSerialNumberStr_(StringBuilder Buf, int BufSize);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668IsPXI();

        [DllImport("GT668.DLL", EntryPoint = "GT668GetDriverVersion", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GT668GetDriverVersion_(StringBuilder DrvRev, int BufSize);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetBoardRevision(ref uint rev);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern uint GT668GetFpgaCode();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern uint GT668GetMemorySize();

        [DllImport("GT668.DLL", EntryPoint = "GT668GetBoardModel", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GT668GetBoardModel_(StringBuilder Buf, int BufSize);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern uint GT668GetCalTime();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668IsMaster();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern uint GT668SetOutput(
          int @out,
          GtiOutSrc src,
          GtiPolarity pol,
          double width,
          double delay);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetRealTimeOutputStatus(ref uint used0, ref uint used1);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetRealTimeOutputMaxPend(ref uint max_pend);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668RealTimeOutput(int @out, uint seconds, double fraction);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668IsRealTimeSet();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetRealTimeStart(uint sec, bool sync);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetRealTimeEnd();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetRealTimeIsDone();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetRealTime(uint sec, bool sync);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetRealTime(ref uint sec);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetBaseSeconds(uint sec);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern uint GT668GetBaseSeconds();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern void GT668InitDefault(bool keep_ref);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetDelay(bool enb);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetInputImpedance(
          GtiSignal sig,
          GtiImpedance imp);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetInputPrescale(
          GtiSignal sig,
          GtiPrescale presc);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetInputCoupling(
          GtiSignal sig,
          GtiCoupling cpl);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetInputThreshold(
          GtiSignal sig,
          GtiThrMode thr_mode,
          double thr_val);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetMeasEnable(int ch, bool enb);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetMeasInput(int ch, GtiInputSel sel);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetMeasSkip(int ch, uint rate);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetMeasGate(int ch, uint cnt);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetMeasTagArm(
          int ch,
          GtiTagArmSrc src,
          GtiPolarity pol);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetBlockArm(
          GtiBlkArmSrc src,
          GtiPolarity pol,
          bool level);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetArmAuxOut(GtiArmAuxOut aux_out);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetReferenceClock(
          GtiRefClkSrc src,
          bool ref_5MHz,
          bool aux_out);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetMemoryWrapMode(bool wrap);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SetT0Mode(bool enb, bool rel);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668StartMeasurements();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668StopMeasurements();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668BlockArmCommand(bool arm);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668TagArmCommand(bool st_arm, bool sp_arm);

        /*
            Declare Function GT668ReadRaw Lib "GT668.DLL" (ByRef pBuf As UInteger, ByVal offset As UInteger, ByVal ToRead As UInteger, ByRef ActRead As UInteger) As Boolean
            Declare Function GT668ReadTimetags Lib "GT668.DLL" (ByRef pTags0 As Double, ByVal NumTags0 As UInteger, ByRef ActNumTags0 As UInteger, ByRef pTags1 As Double, ByVal NumTags1 As UInteger, ByRef ActNumTags1 As UInteger) As Boolean
            Declare Function GT668ConvertRawToTimetags Lib "GT668.DLL" (ByRef pRawBuf As UInteger, ByVal tags_cnt As UInteger, ByRef tags_used As UInteger, ByRef pTags0 As Double, ByVal NumTags0 As UInteger, ByRef ActNumTags0 As UInteger, ByRef pTags1 As Double, ByVal NumTags1 As UInteger, ByRef ActNumTags1 As UInteger) As Boolean
        */

        /*
        GT_Bool GTAPI GT668ReadRaw(void* Buf, unsigned int offset, unsigned int ToRead, unsigned int* ActRead);
        */
        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668ReadRaw(
          ref uint pBuf,
          uint offset,
          uint ToRead,
          ref uint ActRead);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]

        /*
            Declare Function GT668ReadTimetags Lib "GT668.DLL" (ByRef pTags0 As Double, ByVal NumTags0 As UInteger, ByRef ActNumTags0 As UInteger, ByRef pTags1 As Double, ByVal NumTags1 As UInteger, ByRef ActNumTags1 As UInteger) As Boolean
        */

        public static extern bool GT668ReadTimetags(
              ref double pTags0,
              uint NumTags0,
              ref uint ActNumTags0,
              ref double pTags1,
              uint NumTags1,
              ref uint ActNumTags1);



        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668ConvertRawToTimetags(
      ref uint pRawBuf,
      uint tags_cnt,
      ref uint tags_used,
      ref double pTags0,
      uint NumTags0,
      ref uint ActNumTags0,
      ref double pTags1,
      uint NumTags1,
      ref uint ActNumTags1);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668ReadTimetagsEx(
          ref GtiRealTime pTags0,
          uint NumTags0,
          ref uint ActNumTags0,
          ref GtiRealTime pTags1,
          uint NumTags1,
          ref uint ActNumTags1);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668ConvertRawToTimetagsEx(
          ref uint pRawBuf,
          uint tags_cnt,
          ref uint tags_used,
          ref GtiRealTime pTags0,
          uint NumTags0,
          ref uint ActNumTags0,
          ref GtiRealTime pTags1,
          uint NumTags1,
          ref uint ActNumTags1);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668ReadTTUnpacked(
          ref uint pSec0,
          ref double pFrac0,
          uint NumTags0,
          ref uint ActNumTags0,
          ref uint pSec1,
          ref double pFrac1,
          uint NumTags1,
          ref uint ActNumTags1);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668ConvertRawToTTUnpacked(
          ref uint pRawBuf,
          uint tags_cnt,
          ref uint tags_used,
          ref uint pSec0,
          ref double pFrac0,
          uint NumTags0,
          ref uint ActNumTags0,
          ref uint pSec1,
          ref double pFrac1,
          uint NumTags1,
          ref uint ActNumTags1);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetDelay(ref bool enb);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetInputImpedance(
          GtiSignal sig,
          ref GtiImpedance imp);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetInputCoupling(
          GtiSignal sig,
          ref GtiCoupling cpl);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetInputPrescale(
          GtiSignal sig,
          ref GtiPrescale presc);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetInputThreshold(
          GtiSignal sig,
          ref GtiThrMode thr_mode,
          ref double thr_val);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetMeasEnable(int ch, ref bool enb);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetMeasInput(int ch, ref GtiInputSel sel);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetMeasSkip(int ch, ref uint rate);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetMeasGate(int ch, ref uint cnt);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetMeasTagArm(
          int ch,
          ref GtiTagArmSrc src,
          ref GtiPolarity pol);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetBlockArm(
          ref GtiBlkArmSrc src,
          ref GtiPolarity pol,
          ref bool level);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetArmAuxOut(ref GtiArmAuxOut aux_out);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetReferenceClock(
          ref GtiRefClkSrc src,
          ref bool ref_5MHz,
          ref bool aux_out);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetMemoryWrapMode(ref bool wrap);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetT0Mode(ref bool enb);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetTotalPrescale(int ch, ref uint presc);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetT0(ref double t0);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetT0Ex(ref uint t0_sec, ref double t0_frac);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668SelfCal();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetActualInputThreshold(GtiSignal sig, ref double thr);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668MeasureAmplitude(
          GtiSignal sig,
          ref double posv,
          ref double negv,
          double minFreq);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668AutoPrescale(int ch, ref GtiPrescale presc);

        


        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GT668GetError();

        [DllImport("GT668.DLL", EntryPoint = "GT668GetErrorMessage", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int GT668GetErrorMessage_(int ErrNum, StringBuilder ErrMsg, int BufSize);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern void GT668ClearError();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern void GT668SelfCalSettling(double v);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern double GT668ReadSysTime();

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668CheckAUX(uint dev_mask);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668BoardsSkewSelfCal(uint dev_mask);

        [DllImport("GT668.DLL", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern bool GT668GetBoardsSkewCal(
          int ref_dev,
          uint dev_mask,
          bool aux_ref,
          ref double skew);

        public static void GT668GetDriverVersion(ref string DrvRev)
        {
            StringBuilder DrvRev1 = new StringBuilder(256);
            int driverVersion = GT668GetDriverVersion_(DrvRev1, 256);
            if (driverVersion > (int)byte.MaxValue)
            {
                DrvRev1 = new StringBuilder(driverVersion);
                GT668GetDriverVersion_(DrvRev1, driverVersion);
            }
            DrvRev = DrvRev1.ToString();
        }

        public static void GT668GetErrorMessage(int ErrNum, ref string ErrMsg)
        {
            StringBuilder ErrMsg1 = new StringBuilder(256);
            int errorMessage = GT668GetErrorMessage_(ErrNum, ErrMsg1, 256);
            if (errorMessage < 0)
            {
                int num = checked(-errorMessage + 1);
                ErrMsg1 = new StringBuilder(num);
                GT668GetErrorMessage_(ErrNum, ErrMsg1, num);
            }
            ErrMsg = ErrMsg1.ToString();
        }

        public string GT668GetBoardModel()
        {
            StringBuilder Buf = new StringBuilder(256);
            int boardModel = GT668GetBoardModel_(Buf, 256);
            if (boardModel < 0)
            {
                int num = checked(-boardModel + 1);
                Buf = new StringBuilder(num);
                GT668GetBoardModel_(Buf, num);
            }
            return Buf.ToString();
        }

        public string GT668GetSerialNumberStr()
        {
            StringBuilder Buf = new StringBuilder(256);
            int serialNumberStr = GT668GetSerialNumberStr_(Buf, 256);
            if (serialNumberStr < 0)
            {
                int num = checked(-serialNumberStr + 1);
                Buf = new StringBuilder(num);
                GT668GetSerialNumberStr_(Buf, num);
            }
            return Buf.ToString();
        }

        public enum GtiSignal
        {
            GT_SIG_A,
            GT_SIG_B,
            GT_SIG_CLK,
            GT_SIG_ARM,
        }

        public enum GtiPolarity
        {
            GT_POL_POS,
            GT_POL_NEG,
        }

        public enum GtiImpedance
        {
            [EnumDescription("Low Impendance 50 Ohm")]
            GT_IMP_LO,
            [EnumDescription("High Impendance 1 kOhm")]
            GT_IMP_HI,
        }

        public enum GtiCoupling
        {
            [EnumDescription("DC")]
            GT_CPL_DC,
            [EnumDescription("AC")]
            GT_CPL_AC,
        }

        public enum GtiThrMode
        {
            [EnumDescription("Percent")]
            GT_THR_PERCENTS,
            [EnumDescription("Volts")]
            GT_THR_VOLTS,
        }

        public enum GtiPrescale
        {
            [EnumDescription("AUTO")]
            GT_DIV_AUTO,
            [EnumDescription("1")]
            GT_DIV_1,
            [EnumDescription("2")]
            GT_DIV_2,
            [EnumDescription("4")]
            GT_DIV_4,
            [EnumDescription("8")]
            GT_DIV_8,
            [EnumDescription("16")]
            GT_DIV_16,
            [EnumDescription("32")]
            GT_DIV_32,
            [EnumDescription("64")]
            GT_DIV_64,
            [EnumDescription("128")]
            GT_DIV_128,
            [EnumDescription("256")]
            GT_DIV_256,
            [EnumDescription("512")]
            GT_DIV_512,
            [EnumDescription("1024")]
            GT_DIV_1024,
        }

        public enum GtiInputSel
        {
            [EnumDescription("Channel A positiv")]
            GT_CHA_POS,
            [EnumDescription("Channel A negativ")]
            GT_CHA_NEG,
            [EnumDescription("Channel B positiv")]
            GT_CHB_POS,
            [EnumDescription("Channel A negativ")]
            GT_CHB_NEG,
            [EnumDescription("Clock")]
            GT_CLOCK,
            [EnumDescription("AUX")]
            GT_AUX_SIG,
            [EnumDescription("ARM positiv")]
            GT_ARM_POS,
            [EnumDescription("Channel A negativ")]
            GT_ARM_NEG,
        }

        public enum GtiTagArmSrc
        {
            GT_TA_IMM,
            GT_TA_SW,
            GT_TA_EXT,
            GT_TA_AUX,
            GT_TA_OTHER,
            GT_TA_OFF,
        }

        public enum GtiBlkArmSrc
        {
            GT_BA_IMM,
            GT_BA_SW,
            GT_BA_EXT,
            GT_BA_AUX,
            GT_BA_CH0,
            GT_BA_CH1,
            GT_BA_OFF,
        }

        public enum GtiArmAuxOut
        {
            GT_AUX_OUT_OFF,
            GT_AUX_OUT_BA,
            GT_AUX_OUT_TA0,
            GT_AUX_OUT_TA1,
        }

        public enum GtiRefClkSrc
        {
            [EnumDescription("Clock internal")]
            GT_REF_INTERNAL,
            [EnumDescription("Clock extern")]
            GT_REF_EXTERNAL,
            [EnumDescription("Clock PXI")]
            GT_REF_PXI,
            [EnumDescription("Clock AUX")]
            GT_REF_AUX,
        }

        public struct GtiRealTime
        {
            [EnumDescription("Fraction")]
            public double Fraction;
            [EnumDescription("Seconds")]
            public uint Seconds;
            [EnumDescription("Reserved")]
            public uint Reserved;
        }

        public enum GtiOutSrc
        {
            [EnumDescription("Out Realtime")]
            GT_OUT_REALTIME,
            [EnumDescription("Out Start")]
            GT_OUT_START,
            [EnumDescription("Out ARM positive")]
            GT_OUT_ARM_POS,
            [EnumDescription("Out ARM negative")]
            GT_OUT_ARM_NEG,
            [EnumDescription("Out BA")]
            GT_OUT_BA,
            [EnumDescription("Out other")]
            GT_OUT_OTHER,
        }
    }
    public class GT900USBClass : GT668Class
    {

        public bool Run = false;

        public MeasurementConfigClass measConfig = null;
        public void Sleep()
        {
            if (measConfig.sleepAfterSingleMeasurement > 0) Thread.Sleep(measConfig.sleepAfterSingleMeasurement);
        }

        public bool AssignBoardNumber(int logical_dev, int physical_bd)
        {
            return GT668BoardNumber(logical_dev, physical_bd);
        }
        public void CloseMeasurement()
        {
            GT668Close();
        }
        public void SystemClose()
        {
            GT668SystemClose();
        }
        public bool SelfCal()
        {
            return GT668SelfCal();
        }

        /// <summary>
        /// This function retrieves the last driver error encountered.
        /// Use getErrorMessage to translate it to an error message.
        /// </summary>
        /// <returns>The error code(0 means no error)</returns>
        public int GetError()
        {
            return GT668GetError();
        }

        public bool GetMeasSkip(int ch, ref uint rate)
        {
            return GT668GetMeasSkip(ch, ref rate);
        }

        public bool GetMeasGate(int ch, ref uint cnt)
        {
            return GT668GetMeasGate(ch, ref cnt);
        }

        public uint GetSerialNumber()
        {
            return GT668GetSerialNumber();
        }

        public bool IsPXI()
        {
            return GT668IsPXI();
        }

        public bool AutoPrescale(int ch, ref GtiPrescale presc)
        {
            return GT668AutoPrescale(ch, ref presc);
        }
        public bool GetDelay(ref bool enb)
        {
            return GT668GetDelay(ref enb);
        }

        public bool GetInputImpedance(GtiSignal sig, ref GtiImpedance imp)
        {
            return GT668GetInputImpedance(sig, ref imp);
        }
        public bool GetInputCoupling(GtiSignal sig, ref GtiCoupling cpl)
        {
            return GT668GetInputCoupling(sig, ref cpl);
        }

        public bool GetInputPrescale(GtiSignal sig, ref GtiPrescale presc)
        {
            return GT668GetInputPrescale(sig, ref presc);
        }

        public bool GetInputThreshold(GtiSignal sig, ref GtiThrMode thr_mode, ref double thr_val)
        {
            return GT668GetInputThreshold(sig, ref thr_mode, ref thr_val);
        }

        public bool SetBaseSeconds(uint sec)
        {
            return GT668SetBaseSeconds(sec);
        }

        public uint GetBaseSeconds()
        {
            return GT668GetBaseSeconds();
        }

        public uint SetOutput(int @out, GtiOutSrc src, GtiPolarity pol, double width, double delay)
        {
            return GT668SetOutput(@out, src, pol, width, delay);
        }
        public bool GetRealTimeOutputStatus(ref uint used0, ref uint used1)
        {
            return GT668GetRealTimeOutputStatus(ref used0, ref used1);
        }

        public bool GetRealTimeOutputMaxPend(ref uint max_pend)
        {
            return GT668GetRealTimeOutputMaxPend(ref max_pend);
        }
        public bool RealTimeOutput(int @out, uint seconds, double fraction)
        {
            return GT668RealTimeOutput(@out, seconds, fraction);
        }
        public bool IsRealTimeSet()
        {
            return GT668IsRealTimeSet();
        }
        public bool SetRealTimeStart(uint sec, bool sync)
        {
            return GT668SetRealTimeStart(sec, sync);
        }
        public bool SetRealTimeEnd()
        {
            return GT668SetRealTimeEnd();
        }
        public bool SetRealTimeIsDone()
        {
            return GT668SetRealTimeIsDone();
        }

        public bool TagArmCommand(bool st_arm, bool sp_arm)
        {
            return GT668TagArmCommand(st_arm, sp_arm);
        }
        public bool GetMeasEnable(int ch, ref bool enb)
        {
            return GT668GetMeasEnable(ch, ref enb);
        }

        public void SelfCalSettling(double v)
        {
            GT668SelfCalSettling(v);
        }


        public bool CheckAUX(uint dev_mask)
        {
            return GT668CheckAUX(dev_mask);
        }
        public bool BoardsSkewSelfCal(uint dev_mask)
        {
            return GT668BoardsSkewSelfCal(dev_mask);
        }
        public bool GetBoardsSkewCal(int ref_dev, uint dev_mask, bool aux_ref, ref double skew)
        {
            return GT668GetBoardsSkewCal(ref_dev, dev_mask, aux_ref, ref skew);
        }

        public double ReadSysTime()
        {
            return GT668ReadSysTime();
        }
        public bool StartMeasurements()
        {
            return GT668StartMeasurements();
        }

        public bool ReadRaw(ref uint pBuf, uint offset, uint ToRead, ref uint ActRead)
        {
            return GT668ReadRaw(ref pBuf, offset, ToRead, ref ActRead);
        }
        public bool StopMeasurements()
        {
            return GT668StopMeasurements();
        }

        public bool SetMeasTagArm(int ch, GtiTagArmSrc src, GtiPolarity pol)
        {
            return GT668SetMeasTagArm(ch, src, pol);
        }
        public bool SetMemoryWrapMode(bool wrap)
        {
            return GT668SetMemoryWrapMode(wrap);
        }

        public bool SetT0Mode(bool enb, bool rel)
        {
            return GT668SetT0Mode(enb, rel);
        }

        public bool SetMeasSkip(int ch, UInt32 rate)
        {
            return GT668SetMeasSkip(ch, rate);
        }
        public bool SetMeasInput(int ch, GtiInputSel sel)
        {
            return GT668SetMeasInput(ch, sel);
        }

        /// <summary>
        /// This function retrieves the current gate count of a measurement channel. (See GT668SetMeasEnable()). 
        /// The “Gate” allows configuring an averaging gate for each measurement
        /// channel.This option is enabled and used only for Frequency, Period, and TIE measurements.When
        /// disabled or set to 1 (the default) no averaging is done.When it is set to a greater value, measurements will
        /// be averaged over each gate(there is no dead time between gates). For example if gate is 1000, every 1000
        /// measurements will be averaged into one result.
        /// </summary>

        public bool SetMeasGate(int ch, UInt32 cnt)
        {
            return GT668SetMeasGate(ch, cnt);
        }
        public bool SetInputPrescale(GtiSignal sig, GtiPrescale presc)
        {
            return GT668SetInputPrescale(sig, presc);
        }

        public bool SetReferenceClock(GtiRefClkSrc src, bool ref_5MHz, bool aux_out)
        {
            return GT668SetReferenceClock(src, ref_5MHz, aux_out);
        }
        public bool SetInputCoupling(GtiSignal sig, GtiCoupling cpl)
        {
            return GT668SetInputCoupling(sig, cpl);
        }

        public bool SetBlockArm(GtiBlkArmSrc src, GtiPolarity pol, bool level)
        {
            return GT668SetBlockArm(src, pol, level);
        }


        public bool SetArmAuxOut(GtiArmAuxOut aux_out)
        {
            return GT668SetArmAuxOut(aux_out);
        }

        public bool BlockArmCommand(bool arm)
        {
            return GT668BlockArmCommand(arm);
        }

        public string GetDriverVersion()
        {
            string buf = string.Empty;
            GT668GetDriverVersion(ref buf);
            return ($@"{buf.ToString()}");
        }

        public string GetBoardModel()
        {
            string n = GT668GetBoardModel();

            return ($@"{n}");
        }

        public uint GetFpgaCode()
        {
            return GT668GetFpgaCode();
        }

        public uint GetMemorySize()
        {
            return GT668GetMemorySize();
        }
        public bool IsMaster()
        {
            return GT668IsMaster();
        }

        public bool Initialize(int dev)
        {
            return GT668Initialize(dev);
        }

        public bool SystemInitialize(int dev, uint dev_mask)
        {
            return GT668SystemInitialize(dev, dev_mask);
        }

        public bool IsInitialized(int dev)
        {
            return GT668IsInitialized(dev);
        }

        /// <summary>
        /// This function initializes the current board to default setup, 
        /// with the possible exception of the reference clock selection (to avoid settling time penalty).
        /// </summary>
        /// <param name="keepRef">If keep_ref is true the current clock reference selection will be kept unchanged, 
        /// if it's false the clock reference will be set to default value (internal clock).</param>
        public void InitDefault(bool keepRef)
        {
            GT668InitDefault(keepRef);
        }


        public void ClearError()
        {
            GT668ClearError();
        }

        public bool SetRealTime(uint sec, bool sync)
        {
            return GT668SetRealTime(sec, sync);
        }


        public bool GetRealTime(ref uint sec)
        {
            return GT668GetRealTime(ref sec);
        }



        public bool SetInputThreshold(GtiSignal sig, GtiThrMode thr_mode, double thr_val)
        {
            return GT668SetInputThreshold(sig, thr_mode, thr_val);
        }
        public bool SetInputImpendance(GtiSignal sig, GtiImpedance imp)
        {
            return GT668SetInputImpedance(sig, imp);
        }

        public bool SetMeasEnable(int ch, bool enb)
        {
            return GT668SetMeasEnable(ch, enb);
        }
        public bool SetDelay(bool enb)
        {
            return GT668SetDelay(enb);
        }

        public uint GetCalTime()
        {
            return GT668GetCalTime();
        }


        public bool GetMeasTagArm(int ch, ref GtiTagArmSrc src, ref GtiPolarity pol)
        {
            return GT668GetMeasTagArm(ch, ref src, ref pol);
        }
        public bool GetBlockArm(ref GtiBlkArmSrc src, ref GtiPolarity pol, ref bool level)
        {
            return GT668GetBlockArm(ref src, ref pol, ref level);
        }
        public bool GetArmAuxOut(ref GtiArmAuxOut aux_out)
        {
            return GT668GetArmAuxOut(ref aux_out);
        }
        public bool GetReferenceClock(ref GtiRefClkSrc src, ref bool ref_5MHz, ref bool aux_out)
        {
            return GT668GetReferenceClock(ref src, ref ref_5MHz, ref aux_out);
        }
        public bool GetMemoryWrapMode(ref bool wrap)
        {
            return GT668GetMemoryWrapMode(ref wrap);
        }

        public bool GetT0Mode(ref bool enb)
        {
            return GT668GetT0Mode(ref enb);
        }
        public bool GetTotalPrescale(int ch, ref uint presc)
        {
            return GT668GetTotalPrescale(ch, ref presc);
        }
        public bool GetT0(ref double t0)
        {
            return GT668GetT0(ref t0);
        }

        public bool GetT0Ex(ref uint t0_sec, ref double t0_frac)
        {
            return GT668GetT0Ex(ref t0_sec, ref t0_frac);
        }


        /// <summary>
        /// The function will read up-to the requested number of time tags, but will stop sooner if the number of time tags available is smaller.


        /// </summary>
        /// <param name="pTags0">time tags from channel 0</param>
        /// <param name="NumTags0">The number of time tags from channel 0 to read.</param>
        /// <param name="ActNumTags0">Finally read numbers of time tags from channel 0</param>
        /// <param name="pTags1">time tags from channel 1</param>
        /// <param name="NumTags1">The number of time tags from channel 1 to read.</param>
        /// <param name="ActNumTags1">Finally read numbers of time tags from channel 1</param>
        /// <returns></returns>


        public bool ReadTimetags(ref double pTags0, UInt32 NumTags0, ref UInt32 ActNumTags0, ref double pTags1, UInt32 NumTags1, ref UInt32 ActNumTags1)
        {
            return GT668ReadTimetags(ref pTags0, NumTags0, ref ActNumTags0, ref pTags1, NumTags1, ref ActNumTags1);
        }

        public bool ReadTimetagsEx(ref GtiRealTime pTags0, uint NumTags0, ref uint ActNumTags0, ref GtiRealTime pTags1, uint NumTags1, ref uint ActNumTags1)
        {
            return GT668ReadTimetagsEx(ref pTags0, NumTags0, ref ActNumTags0, ref pTags1, NumTags1, ref ActNumTags1);
        }
        /*
          public static extern bool GT668ReadTTUnpacked(
        ref uint pSec0,
        ref double pFrac0,
        uint NumTags0,
        ref uint ActNumTags0,
        ref uint pSec1,
        ref double pFrac1,
        uint NumTags1,
        ref uint ActNumTags1);
          */

        public bool ConvertRawToTimetags(ref uint pRawBuf, uint tags_cnt, ref uint tags_used, ref double pTags0, uint NumTags0, ref uint ActNumTags0, ref double pTags1, uint NumTags1, ref uint ActNumTags1)
        {
            return GT668ConvertRawToTimetags(ref pRawBuf, tags_cnt, ref tags_used, ref pTags0, NumTags0, ref ActNumTags0, ref pTags1, NumTags1, ref ActNumTags1);
        }
        public bool ConvertRawToTimetagsEx(ref uint pRawBuf, uint tags_cnt, ref uint tags_used, ref GtiRealTime pTags0, uint NumTags0, ref uint ActNumTags0, ref GtiRealTime pTags1, uint NumTags1, ref uint ActNumTags1)
        {
            return GT668ConvertRawToTimetagsEx(ref pRawBuf, tags_cnt, ref tags_used, ref pTags0, NumTags0, ref ActNumTags0, ref pTags1, NumTags1, ref ActNumTags1);
        }

        public bool ReadTTUnpacked(ref uint pSec0, ref double pFrac0, uint NumTags0, ref uint ActNumTags0, ref uint pSec1, ref double pFrac1, uint NumTags1, ref uint ActNumTags1)
        {
            return GT668ReadTTUnpacked(ref pSec0, ref pFrac0, NumTags0, ref ActNumTags0,  ref pSec1, ref pFrac1, NumTags1, ref ActNumTags1);
        }

        public bool ConvertRawToTTUnpacked(ref uint pRawBuf, uint tags_cnt, ref uint tags_used, ref uint pSec0, ref double pFrac0, uint NumTags0, ref uint ActNumTags0, ref uint pSec1, ref double pFrac1, uint NumTags1, ref uint ActNumTags1)
        {
            return GT668ConvertRawToTTUnpacked(ref pRawBuf, tags_cnt,ref tags_used,ref pSec0, ref pFrac0, NumTags0,ref ActNumTags0, ref pSec1,  ref pFrac1, NumTags1, ref ActNumTags1);
        }

        /*
        public bool ReadTimetags(ref double[] pTags0, UInt32 NumTags0, ref UInt32 ActNumTags0, ref double[] pTags1, UInt32 NumTags1, ref UInt32 ActNumTags1)
        {
            return GT668ReadTimetags(ref pTags0, NumTags0, ref ActNumTags0, ref pTags1, NumTags1, ref ActNumTags1);
        }
        */
        public bool GetMeasInput(int ch, ref GtiInputSel sel)
        {        
            return GT668GetMeasInput(ch, ref sel);
        }

        public bool Select(int dev)
        {
            return GT668Select(dev);
        }

        public int EnumerateBoards(bool first)
        {
            return GT668EnumerateBoards(first);
        }

        public string GetErrorMessage(int error)
        {
            string ErrMsg = string.Empty;
            GT668GetErrorMessage(error, ref ErrMsg);
            return ErrMsg;
        }

        public bool GetBoardRevision(ref uint rev)
        {
            return GT668GetBoardRevision(ref rev);
        }
        /// <summary>
        /// This function measures the peak voltages of an input signal. Because the measurement is done by a
        /// threshold search the measurement can be slow if the frequency of the signal is low.The measurement
        /// takes about 60 msec + 36 * (signal maximum period).
        /// ch 0 – Input channel A.
        /// 1 – Input channel B.
        /// posv Pointer to a place to store the positive peak voltage.
        /// negv Pointer to a place to store the negative peak voltage.
        /// minFreq Minimum frequency of the measured signal.Using a value lower than
        /// necessary may slow down the measurement
        /// </summary>
        /// <param name="sig">channel of signal</param>
        /// <param name="posv">returns positive peak voltage</param>
        /// <param name="negv">returns negative peak voltage</param>
        /// <param name="minFreq">Set Minimum frequency of the measured signal.Using a value lower than necessary may slow down the measurement</param>
        /// <returns></returns>
        public bool MeasureAmplitude(GtiSignal sig, ref double posv, ref double negv, double minFreq)
        {
            return GT668MeasureAmplitude(sig,ref posv, ref negv, minFreq);
        }

        /// <summary>
        /// This function retrieves the current actual threshold used for the selected signal.
        /// </summary>
        /// <param name="sig">channel</param>
        /// <param name="thr">returns actual threshold</param>
        /// <returns></returns>
        public bool GetActualInputThreshold(GtiSignal sig, ref double thr)
        {
            return GT668GetActualInputThreshold(sig, ref thr);
        }
    }
}
