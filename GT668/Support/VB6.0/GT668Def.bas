Attribute VB_Name = "GT668Def"
Option Explicit


Global Const GT668_ERR_NOT_FOUND = 1
Global Const GT668_ERR_NO_INFO = 2
Global Const GT668_ERR_NO_CAL = 3
Global Const GT668_ERR_NOT_OPEN = 4
Global Const GT668_ERR_INVALID_PARAM = 5
Global Const GT668_ERR_OUT_OF_MEM = 6
Global Const GT668_ERR_CAL_FAIL = 7
Global Const GT668_ERR_BD_NOT_SUPP = 8
Global Const GT668_PROG_ERR = 9
Global Const GT668_WRAP_ERR = 10
Global Const GT668_MEMORY_ERR = 11
Global Const GT668_ERR_FPGA = 12
Global Const GT668_ERR_FIFO_OVFL = 13
Global Const GT668_ERR_BD_OPEN = 14
Global Const GT668_ERR_DEV_OPEN = 15
Global Const GT668_ERR_INVALID_TT = 16
Global Const GT668_ERR_DEV_SKEW = 17
Global Const GT668_ERR_CAL_FAIL2 = 18
Global Const GT668_ERR_CAL_FAIL3 = 19
Global Const GT668_ERR_CAL_FAIL4 = 20
Global Const GT668_ERR_TIMEOUT = 21
Global Const GT668_ERR_SKEW = 22
Global Const GT668_ERR_OLD_BD = 23
Global Const GT668_ERR_SKEW_CAL = 24

Enum GtiSignal
    GT_SIG_A
    GT_SIG_B
    GT_SIG_CLK
    GT_SIG_ARM
End Enum

Enum GtiPolarity
    GT_POL_POS
    GT_POL_NEG
End Enum

Enum GtiImpedance
    GT_IMP_LO
    GT_IMP_HI
End Enum

Enum GtiCoupling
    GT_CPL_DC
    GT_CPL_AC
End Enum

Enum GtiThrMode
    GT_THR_PERCENTS
    GT_THR_VOLTS
End Enum

Enum GtiPrescale
    GT_DIV_AUTO
    GT_DIV_1
    GT_DIV_2
    GT_DIV_4
    GT_DIV_8
    GT_DIV_16
    GT_DIV_32
    GT_DIV_64
    GT_DIV_128
    GT_DIV_256
    GT_DIV_512
    GT_DIV_1024
End Enum

Enum GtiInputSel
    GT_CHA_POS
    GT_CHA_NEG
    GT_CHB_POS
    GT_CHB_NEG
    GT_CLOCK
    GT_AUX_SIG
    GT_ARM_POS
    GT_ARM_NEG
End Enum

Enum GtiTagArmSrc
    GT_TA_IMM
    GT_TA_SW
    GT_TA_EXT
    GT_TA_AUX
    GT_TA_OTHER
    GT_TA_OFF
End Enum

Enum GtiBlkArmSrc
    GT_BA_IMM
    GT_BA_SW
    GT_BA_EXT
    GT_BA_AUX
    GT_BA_CH0
    GT_BA_CH1
    GT_BA_OFF
End Enum

Enum GtiArmAuxOut
    GT_AUX_OUT_OFF
    GT_AUX_OUT_BA
    GT_AUX_OUT_TA0
    GT_AUX_OUT_TA1
End Enum

Enum GtiRefClkSrc
    GT_REF_INTERNAL
    GT_REF_EXTERNAL
    GT_REF_PXI
    GT_REF_AUX
End Enum

Type GtiRealTime
    Fraction As Double
    Seconds As Long
    Reserved As Long
End Type

Enum GtiOutSrc
    GT_OUT_REALTIME
    GT_OUT_START
    GT_OUT_ARM_POS
    GT_OUT_ARM_NEG
    GT_OUT_BA
    GT_OUT_OTHER
End Enum

Declare Function GT668EnumerateBoards Lib "GT668.DLL" (ByVal first As Boolean) As Long
Declare Function GT668Initialize Lib "GT668.DLL" (ByVal dev As Long) As Boolean
Declare Sub GT668Close Lib "GT668.DLL" ()
Declare Function GT668SystemInitialize Lib "GT668.DLL" (ByVal dev As Long, ByVal dev_mask As Long) As Boolean
Declare Sub GT668SystemClose Lib "GT668.DLL" ()
Declare Function GT668Select Lib "GT668.DLL" (ByVal dev As Long) As Boolean
Declare Function GT668BoardNumber Lib "GT668.DLL" (ByVal dev As Long, ByVal bd As Long) As Boolean
Declare Function GT668GetSerialNumber Lib "GT668.DLL" () As Long
Declare Function GT668GetSerialNumberStr_ Lib "GT668.DLL" Alias "GT668GetSerialNumberStr" (ByVal Buf As String, ByVal BufSize As Long) As Long
Declare Function GT668IsPXI Lib "GT668.DLL" () As Boolean
Declare Function GT668GetDriverVersion_ Lib "GT668.DLL" Alias "GT668GetDriverVersion" (ByVal DrvRev As String, ByVal BufSize As Long) As Long
Declare Function GT668GetBoardRevision Lib "GT668.DLL" (ByRef rev As Long) As Boolean
Declare Function GT668GetMemorySize Lib "GT668.DLL" () As Long
Declare Function GT668GetBoardModel_ Lib "GT668.DLL" Alias "GT668GetBoardModel" (ByVal Buf As String, ByVal BufSize As Long) As Long
Declare Function GT668GetCalTime Lib "GT668.DLL" () As Long

Declare Function GT668SetOutput Lib "GT668.DLL" (ByVal out As Long, ByVal src As GtiOutSrc, ByVal pol As GtiPolarity, ByVal width As Double, ByVal delay As Double) As Long
Declare Function GT668GetRealTimeOutputStatus Lib "GT668.DLL" (ByRef used0 As Long, ByRef used1 As Long) As Long
Declare Function GT668GetRealTimeOutputMaxPend Lib "GT668.DLL" (ByRef max_pend As Long) As Long
Declare Function GT668RealTimeOutput Lib "GT668.DLL" (ByVal out As Long, ByVal seconds As Long, ByVal fraction As Double) As Long

Declare Function GT668IsRealTimeSet Lib "GT668.DLL" () As Boolean
Declare Function GT668SetRealTime Lib "GT668.DLL" (ByVal sec As Long, ByVal sync As Boolean) As Boolean
Declare Function GT668GetRealTime Lib "GT668.DLL" (ByRef sec As Long) As Boolean
Declare Function GT668SetBaseSeconds Lib "GT668.DLL" (ByVal sec As Long) As Boolean
Declare Function GT668GetBaseSeconds Lib "GT668.DLL" () As Long

Declare Sub GT668InitDefault Lib "GT668.DLL" (ByVal keep_ref As Boolean)
Declare Function GT668SetDelay Lib "GT668.DLL" (ByVal enb As Boolean) As Boolean
Declare Function GT668SetInputImpedance Lib "GT668.DLL" (ByVal sig As GtiSignal, ByVal imp1 As GtiImpedance) As Boolean
Declare Function GT668SetInputPrescale Lib "GT668.DLL" (ByVal sig As GtiSignal, ByVal Presc As GtiPrescale) As Boolean
Declare Function GT668SetInputCoupling Lib "GT668.DLL" (ByVal sig As GtiSignal, ByVal cpl As GtiCoupling) As Boolean
Declare Function GT668SetInputThreshold Lib "GT668.DLL" (ByVal sig As GtiSignal, ByVal thr_mode As GtiThrMode, ByVal thr_val As Double) As Boolean
Declare Function GT668SetMeasEnable Lib "GT668.DLL" (ByVal ch As Long, ByVal enb As Boolean) As Boolean
Declare Function GT668SetMeasInput Lib "GT668.DLL" (ByVal ch As Long, ByVal sel As GtiInputSel) As Boolean
Declare Function GT668SetMeasSkip Lib "GT668.DLL" (ByVal ch As Long, ByVal rate As Long) As Boolean
Declare Function GT668SetMeasTagArm Lib "GT668.DLL" (ByVal ch As Long, ByVal src As GtiTagArmSrc, ByVal pol As GtiPolarity) As Boolean
Declare Function GT668SetBlockArm Lib "GT668.DLL" (ByVal src As GtiBlkArmSrc, ByVal pol As GtiPolarity, ByVal level As Boolean) As Boolean
Declare Function GT668SetArmAuxOut Lib "GT668.DLL" (ByVal aux_out As GtiArmAuxOut) As Boolean
Declare Function GT668SetReferenceClock Lib "GT668.DLL" (ByVal src As GtiRefClkSrc, ByVal ref_5MHz As Boolean, ByVal aux_out As Boolean) As Boolean
Declare Function GT668SetMemoryWrapMode Lib "GT668.DLL" (ByVal wrap As Boolean) As Boolean
Declare Function GT668SetT0Mode Lib "GT668.DLL" (ByVal enb As Boolean, ByVal rel As Boolean) As Boolean
Declare Function GT668StartMeasurements Lib "GT668.DLL" () As Boolean
Declare Function GT668StopMeasurements Lib "GT668.DLL" () As Boolean
Declare Function GT668BlockArmCommand Lib "GT668.DLL" (ByVal arm As Boolean) As Boolean
Declare Function GT668TagArmCommand Lib "GT668.DLL" (ByVal st_arm As Boolean, ByVal sp_arm As Boolean) As Boolean
Declare Function GT668ReadRaw Lib "GT668.DLL" (ByRef pBuf As Long, ByVal offset As Long, ByVal ToRead As Long, ByRef ActRead As Long) As Boolean
Declare Function GT668ReadTimetags Lib "GT668.DLL" (ByRef pTags0 As Double, ByVal NumTags0 As Long, ByRef ActNumTags0 As Long, ByRef pTags1 As Double, ByVal NumTags1 As Long, ByRef ActNumTags1 As Long) As Boolean
Declare Function GT668ConvertRawToTimetags Lib "GT668.DLL" (ByRef pRawBuf As Long, ByVal tags_cnt As Long, ByRef pTags0 As Double, ByVal NumTags0 As Long, ByRef ActNumTags0 As Long, ByRef pTags1 As Double, ByVal NumTags1 As Long, ByRef ActNumTags1 As Long) As Boolean
Declare Function GT668ReadTimetagsEx Lib "GT668.DLL" (ByRef pTags0 As GtiRealTime, ByVal NumTags0 As Long, ByRef ActNumTags0 As Long, ByRef pTags1 As GtiRealTime, ByVal NumTags1 As Long, ByRef ActNumTags1 As Long) As Boolean
Declare Function GT668ConvertRawToTimetagsEx Lib "GT668.DLL" (ByRef pRawBuf As Long, ByVal tags_cnt As Long, ByRef tags_used As Long, ByRef pTags0 As GtiRealTime, ByVal NumTags0 As Long, ByRef ActNumTags0 As Long, ByRef pTags1 As GtiRealTime, ByVal NumTags1 As Long, ByRef ActNumTags1 As Long) As Boolean
Declare Function GT668ReadTTUnpacked Lib "GT668.DLL" (ByRef pSec0 As Long, ByRef pFrac0 As Double, ByVal NumTags0 As Long, ByRef ActNumTags0 As Long, ByRef pSec1 As Long, ByRef pFrac1 As Double, ByVal NumTags1 As Long, ByRef ActNumTags1 As Long) As Boolean
Declare Function GT668ConvertRawToTTUnpacked Lib "GT668.DLL" (ByRef pRawBuf As Long, ByVal tags_cnt As Long, ByRef tags_used As Long, ByRef pSec0 As Long, ByRef pFrac0 As Double, ByVal NumTags0 As Long, ByRef ActNumTags0 As Long, ByRef pSec1 As Long, ByRef pFrac1 As Double, ByVal NumTags1 As Long, ByRef ActNumTags1 As Long) As Boolean

Declare Function GT668GetDelay Lib "GT668.DLL" (ByRef enb As Boolean) As Boolean
Declare Function GT668GetInputImpedance Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef imp1 As GtiImpedance) As Boolean
Declare Function GT668GetInputCoupling Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef cpl As GtiCoupling) As Boolean
Declare Function GT668GetInputPrescale Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef Presc As GtiPrescale) As Boolean
Declare Function GT668GetInputThreshold Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef thr_mode As GtiThrMode, ByRef thr_val As Double) As Boolean
Declare Function GT668GetMeasEnable Lib "GT668.DLL" (ByVal ch As Long, ByRef enb As Boolean) As Boolean
Declare Function GT668GetMeasInput Lib "GT668.DLL" (ByVal ch As Long, ByRef sel As GtiInputSel) As Boolean
Declare Function GT668GetMeasSkip Lib "GT668.DLL" (ByVal ch As Long, ByRef rate As Long) As Boolean
Declare Function GT668GetMeasTagArm Lib "GT668.DLL" (ByVal ch As Long, ByRef src As GtiTagArmSrc, ByRef pol As GtiPolarity) As Boolean
Declare Function GT668GetBlockArm Lib "GT668.DLL" (ByRef src As GtiBlkArmSrc, ByRef pol As GtiPolarity, ByRef level As Boolean) As Boolean
Declare Function GT668GetArmAuxOut Lib "GT668.DLL" (ByRef aux_out As GtiArmAuxOut) As Boolean
Declare Function GT668GetReferenceClock Lib "GT668.DLL" (ByRef src As GtiRefClkSrc, ByRef ref_5MHz As Boolean, ByRef aux_out As Boolean) As Boolean
Declare Function GT668GetMemoryWrapMode Lib "GT668.DLL" (ByRef wrap As Boolean) As Boolean
Declare Function GT668GetT0Mode Lib "GT668.DLL" (ByRef enb As Boolean) As Boolean
Declare Function GT668GetTotalPrescale Lib "GT668.DLL" (ByVal ch As Long, ByRef Presc As Long) As Boolean
Declare Function GT668GetT0 Lib "GT668.DLL" (ByRef t0 As Double) As Boolean
Declare Function GT668GetT0Ex Lib "GT668.DLL" (ByRef t0_sec As Long, ByRef t0_frac As Double) As Boolean
Declare Function GT668SelfCal Lib "GT668.DLL" () As Boolean
Declare Function GT668GetActualInputThreshold Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef thr As Double) As Boolean
Declare Function GT668MeasureAmplitude Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef posv As Double, ByRef negv As Double, ByVal minFreq As Double) As Boolean
Declare Function GT668AutoPrescale Lib "GT668.DLL" (ByVal ch As Long, ByRef Presc As GtiPrescale) As Boolean
Declare Function GT668GetError Lib "GT668.DLL" () As Long
Declare Function GT668GetErrorMessage_ Lib "GT668.DLL" Alias "GT668GetErrorMessage" (ByVal ErrNum As Long, ByVal ErrMsg As String, ByVal BufSize As Long) As Long
Declare Sub GT668ClearError Lib "GT668.DLL" ()
Declare Sub GT668SelfCalSettling Lib "GT668.DLL" (ByVal v As Double)
Declare Function GT668ReadSysTime Lib "GT668.DLL" () As Double

Declare Function GT668CheckAUX Lib "GT668.DLL" (ByVal dev_mask As Long) As Boolean
Declare Function GT668BoardsSkewSelfCal Lib "GT668.DLL" (ByVal dev_mask As Long) As Boolean
Declare Function GT668GetBoardsSkewCal Lib "GT668.DLL" (ByVal ref_dev As Long, ByVal dev_mask As Long, ByVal aux_ref As Boolean, ByRef skew As Double) As Boolean

Public Sub GT668GetDriverVersion(ByVal DrvRev As String)
    Dim Buffer As String
    Dim n As Long
    Buffer = String$(256, 0)
    n = GT668GetDriverVersion_(Buffer, 256)
    If n > 255 Then
        Buffer = String$(n + 1, 0)
        n = GT668GetDriverVersion_(Buffer, n)
    End If
    n = InStr(Buffer, Chr$(0))
    If n > 1 Then
        DrvRev = Left$(Buffer, n - 1)
    Else
        DrvRev = ""
    End If
End Sub

Public Sub GT668GetErrorMessage(ByVal ErrNum As Long, ByRef ErrMsg As String)
    Dim Buffer As String
    Dim n As Long
    Buffer = String$(256, 0)
    n = GT668GetErrorMessage_(ErrNum, Buffer, 256)
    If n > 255 Then
        Buffer = String$(n + 1, 0)
        n = GT668GetErrorMessage_(ErrNum, Buffer, n)
    End If
    n = InStr(Buffer, Chr$(0))
    If n > 1 Then
        ErrMsg = Left$(Buffer, n - 1)
    Else
        ErrMsg = ""
    End If
End Sub

Public Function GT668GetSerialNumberStr(void) As String
    Dim Buffer As String
    Dim n As Long
    Buffer = String$(256, 0)
    n = GT668GetSerialNumberStr_(Buffer, 256)
    If n < 0 Then
        n = -n + 1
        Buffer = String$(n, 0)
        n = GT668GetSerialNumberStr_(Buffer, n)
    End If
    n = InStr(Buffer, Chr$(0))
    If n > 1 Then
        GT668GetSerialNumberStr = Left$(Buffer, n - 1)
    Else
        GT668GetSerialNumberStr = ""
    End If
End Function

Public Function GT668GetBoardModel(void) As String
    Dim Buffer As String
    Dim n As Long
    Buffer = String$(256, 0)
    n = GT668GetBoardModel_(Buffer, 256)
    If n < 0 Then
        n = -n + 1
        Buffer = String$(n, 0)
        n = GT668GetBoardModel_(Buffer, n)
    End If
    n = InStr(Buffer, Chr$(0))
    If n > 1 Then
        GT668GetBoardModel = Left$(Buffer, n - 1)
    Else
        GT668GetBoardModel = ""
    End If
End Function
