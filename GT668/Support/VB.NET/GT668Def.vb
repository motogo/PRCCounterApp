Imports System.Text
Imports System.Runtime.InteropServices
Module GT668Def


    Public Const GT668_ERR_NOT_FOUND As Integer = 1
    Public Const GT668_ERR_NO_INFO As Integer = 2
    Public Const GT668_ERR_NO_CAL As Integer = 3
    Public Const GT668_ERR_NOT_OPEN As Integer = 4
    Public Const GT668_ERR_INVALID_PARAM As Integer = 5
    Public Const GT668_ERR_OUT_OF_MEM As Integer = 6
    Public Const GT668_ERR_CAL_FAIL As Integer = 7
    Public Const GT668_ERR_BD_NOT_SUPP As Integer = 8
    Public Const GT668_PROG_ERR As Integer = 9
    Public Const GT668_WRAP_ERR As Integer = 10
    Public Const GT668_MEMORY_ERR As Integer = 11
    Public Const GT668_ERR_FPGA As Integer = 12
    Public Const GT668_ERR_FIFO_OVFL As Integer = 13
    Public Const GT668_ERR_BD_OPEN As Integer = 14
    Public Const GT668_ERR_DEV_OPEN As Integer = 15
    Public Const GT668_ERR_INVALID_TT As Integer = 16
    Public Const GT668_ERR_DEV_SKEW As Integer = 17
    Public Const GT668_ERR_CAL_FAIL2 As Integer = 18
    Public Const GT668_ERR_CAL_FAIL3 As Integer = 19
    Public Const GT668_ERR_CAL_FAIL4 As Integer = 20
    Public Const GT668_ERR_TIMEOUT As Integer = 21
    Public Const GT668_ERR_SKEW As Integer = 22
    Public Const GT668_ERR_OLD_BD As Integer = 23
    Public Const GT668_ERR_SKEW_CAL As Integer = 24
    Public Const GT668_ERR_PLL_HW As Integer = 25
    Public Const GT668_ERR_PLL_LOCK_SYS As Integer = 26
    Public Const GT668_ERR_PLL_LOCK_CAL As Integer = 27

    Public Enum GtiSignal
        GT_SIG_A
        GT_SIG_B
        GT_SIG_CLK
        GT_SIG_ARM
    End Enum

    Public Enum GtiPolarity
        GT_POL_POS
        GT_POL_NEG
    End Enum

    Public Enum GtiImpedance
        GT_IMP_LO
        GT_IMP_HI
    End Enum

    Public Enum GtiCoupling
        GT_CPL_DC
        GT_CPL_AC
    End Enum

    Public Enum GtiThrMode
        GT_THR_PERCENTS
        GT_THR_VOLTS
    End Enum

    Public Enum GtiPrescale
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

    Public Enum GtiInputSel
        GT_CHA_POS
        GT_CHA_NEG
        GT_CHB_POS
        GT_CHB_NEG
        GT_CLOCK
        GT_AUX_SIG
        GT_ARM_POS
        GT_ARM_NEG
    End Enum

    Public Enum GtiTagArmSrc
        GT_TA_IMM
        GT_TA_SW
        GT_TA_EXT
        GT_TA_AUX
        GT_TA_OTHER
        GT_TA_OFF
    End Enum

    Public Enum GtiBlkArmSrc
        GT_BA_IMM
        GT_BA_SW
        GT_BA_EXT
        GT_BA_AUX
        GT_BA_CH0
        GT_BA_CH1
        GT_BA_OFF
    End Enum

    Public Enum GtiArmAuxOut
        GT_AUX_OUT_OFF
        GT_AUX_OUT_BA
        GT_AUX_OUT_TA0
        GT_AUX_OUT_TA1
    End Enum

    Public Enum GtiRefClkSrc
        GT_REF_INTERNAL
        GT_REF_EXTERNAL
        GT_REF_PXI
        GT_REF_AUX
    End Enum

    Public Structure GtiRealTime
        Dim Fraction As Double
        Dim Seconds As UInteger
        Dim Reserved As UInteger
    End Structure

    Public Enum GtiOutSrc
        GT_OUT_REALTIME
        GT_OUT_START
        GT_OUT_ARM_POS
        GT_OUT_ARM_NEG
        GT_OUT_BA
        GT_OUT_OTHER
    End Enum


    Declare Function GT668EnumerateBoards Lib "GT668.DLL" (ByVal first As Boolean) As Integer
    Declare Function GT668Initialize Lib "GT668.DLL" (ByVal dev As Integer) As Boolean
    Declare Sub GT668Close Lib "GT668.DLL" ()
    Declare Function GT668SystemInitialize Lib "GT668.DLL" (ByVal dev As Integer, ByVal dev_mask As UInteger) As Boolean
    Declare Sub GT668SystemClose Lib "GT668.DLL" ()
    Declare Function GT668Select Lib "GT668.DLL" (ByVal dev As Integer) As Boolean
    Declare Function GT668BoardNumber Lib "GT668.DLL" (ByVal dev As Integer, ByVal bd As Integer) As Boolean
    Declare Function GT668GetSerialNumber Lib "GT668.DLL" () As UInteger
    Declare Function GT668GetSerialNumberStr_ Lib "GT668.DLL" Alias "GT668GetSerialNumberStr" (ByVal Buf As StringBuilder, ByVal BufSize As Integer) As Integer
    Declare Function GT668IsPXI Lib "GT668.DLL" () As Boolean
    Declare Function GT668GetDriverVersion_ Lib "GT668.DLL" Alias "GT668GetDriverVersion" (ByVal DrvRev As StringBuilder, ByVal BufSize As Integer) As Integer
    Declare Function GT668GetBoardRevision Lib "GT668.DLL" (ByRef rev As UInteger) As Boolean
    Declare Function GT668GetFpgaCode Lib "GT668.DLL" () As UInteger
    Declare Function GT668GetMemorySize Lib "GT668.DLL" () As UInteger
    Declare Function GT668GetBoardModel_ Lib "GT668.DLL" Alias "GT668GetBoardModel" (ByVal Buf As StringBuilder, ByVal BufSize As Integer) As Integer
    Declare Function GT668GetCalTime Lib "GT668.DLL" () As UInteger
    Declare Function GT668IsMaster Lib "GT668.DLL" () As Boolean

    Declare Function GT668SetOutput Lib "GT668.DLL" (ByVal out As Integer, ByVal src As GtiOutSrc, ByVal pol As GtiPolarity, ByVal width As Double, ByVal delay As Double) As UInteger
    Declare Function GT668GetRealTimeOutputStatus Lib "GT668.DLL" (ByRef used0 As UInteger, ByRef used1 As UInteger) As Boolean
    Declare Function GT668GetRealTimeOutputMaxPend Lib "GT668.DLL" (ByRef max_pend As UInteger) As Boolean
    Declare Function GT668RealTimeOutput Lib "GT668.DLL" (ByVal out As Integer, ByVal seconds As UInteger, ByVal fraction As Double) As Boolean

    Declare Function GT668IsRealTimeSet Lib "GT668.DLL" () As Boolean
    Declare Function GT668SetRealTimeStart Lib "GT668.DLL" (ByVal sec As UInteger, ByVal sync As Boolean) As Boolean
    Declare Function GT668SetRealTimeEnd Lib "GT668.DLL" () As Boolean
    Declare Function GT668SetRealTimeIsDone Lib "GT668.DLL" () As Boolean
    Declare Function GT668SetRealTime Lib "GT668.DLL" (ByVal sec As UInteger, ByVal sync As Boolean) As Boolean
    Declare Function GT668GetRealTime Lib "GT668.DLL" (ByRef sec As UInteger) As Boolean
    Declare Function GT668SetBaseSeconds Lib "GT668.DLL" (ByVal sec As UInteger) As Boolean
    Declare Function GT668GetBaseSeconds Lib "GT668.DLL" () As UInteger

    Declare Sub GT668InitDefault Lib "GT668.DLL" (ByVal keep_ref As Boolean)
    Declare Function GT668SetDelay Lib "GT668.DLL" (ByVal enb As Boolean) As Boolean
    Declare Function GT668SetInputImpedance Lib "GT668.DLL" (ByVal sig As GtiSignal, ByVal imp As GtiImpedance) As Boolean
    Declare Function GT668SetInputPrescale Lib "GT668.DLL" (ByVal sig As GtiSignal, ByVal presc As GtiPrescale) As Boolean
    Declare Function GT668SetInputCoupling Lib "GT668.DLL" (ByVal sig As GtiSignal, ByVal cpl As GtiCoupling) As Boolean
    Declare Function GT668SetInputThreshold Lib "GT668.DLL" (ByVal sig As GtiSignal, ByVal thr_mode As GtiThrMode, ByVal thr_val As Double) As Boolean
    Declare Function GT668SetMeasEnable Lib "GT668.DLL" (ByVal ch As Integer, ByVal enb As Boolean) As Boolean
    Declare Function GT668SetMeasInput Lib "GT668.DLL" (ByVal ch As Integer, ByVal sel As GtiInputSel) As Boolean
    Declare Function GT668SetMeasSkip Lib "GT668.DLL" (ByVal ch As Integer, ByVal rate As UInteger) As Boolean
    Declare Function GT668SetMeasGate Lib "GT668.DLL" (ByVal ch As Integer, ByVal cnt As UInteger) As Boolean
    Declare Function GT668SetMeasTagArm Lib "GT668.DLL" (ByVal ch As Integer, ByVal src As GtiTagArmSrc, ByVal pol As GtiPolarity) As Boolean
    Declare Function GT668SetBlockArm Lib "GT668.DLL" (ByVal src As GtiBlkArmSrc, ByVal pol As GtiPolarity, ByVal level As Boolean) As Boolean
    Declare Function GT668SetArmAuxOut Lib "GT668.DLL" (ByVal aux_out As GtiArmAuxOut) As Boolean
    Declare Function GT668SetReferenceClock Lib "GT668.DLL" (ByVal src As GtiRefClkSrc, ByVal ref_5MHz As Boolean, ByVal aux_out As Boolean) As Boolean
    Declare Function GT668SetMemoryWrapMode Lib "GT668.DLL" (ByVal wrap As Boolean) As Boolean
    Declare Function GT668SetT0Mode Lib "GT668.DLL" (ByVal enb As Boolean, ByVal rel As Boolean) As Boolean
    Declare Function GT668StartMeasurements Lib "GT668.DLL" () As Boolean
    Declare Function GT668StopMeasurements Lib "GT668.DLL" () As Boolean
    Declare Function GT668BlockArmCommand Lib "GT668.DLL" (ByVal arm As Boolean) As Boolean
    Declare Function GT668TagArmCommand Lib "GT668.DLL" (ByVal st_arm As Boolean, ByVal sp_arm As Boolean) As Boolean
    Declare Function GT668ReadRaw Lib "GT668.DLL" (ByRef pBuf As UInteger, ByVal offset As UInteger, ByVal ToRead As UInteger, ByRef ActRead As UInteger) As Boolean
    Declare Function GT668ReadTimetags Lib "GT668.DLL" (ByRef pTags0 As Double, ByVal NumTags0 As UInteger, ByRef ActNumTags0 As UInteger, ByRef pTags1 As Double, ByVal NumTags1 As UInteger, ByRef ActNumTags1 As UInteger) As Boolean
    Declare Function GT668ConvertRawToTimetags Lib "GT668.DLL" (ByRef pRawBuf As UInteger, ByVal tags_cnt As UInteger, ByRef tags_used As UInteger, ByRef pTags0 As Double, ByVal NumTags0 As UInteger, ByRef ActNumTags0 As UInteger, ByRef pTags1 As Double, ByVal NumTags1 As UInteger, ByRef ActNumTags1 As UInteger) As Boolean
    Declare Function GT668ReadTimetagsEx Lib "GT668.DLL" (ByRef pTags0 As GtiRealTime, ByVal NumTags0 As UInteger, ByRef ActNumTags0 As UInteger, ByRef pTags1 As GtiRealTime, ByVal NumTags1 As UInteger, ByRef ActNumTags1 As UInteger) As Boolean
    Declare Function GT668ConvertRawToTimetagsEx Lib "GT668.DLL" (ByRef pRawBuf As UInteger, ByVal tags_cnt As UInteger, ByRef tags_used As UInteger, ByRef pTags0 As GtiRealTime, ByVal NumTags0 As UInteger, ByRef ActNumTags0 As UInteger, ByRef pTags1 As GtiRealTime, ByVal NumTags1 As UInteger, ByRef ActNumTags1 As UInteger) As Boolean
    Declare Function GT668ReadTTUnpacked Lib "GT668.DLL" (ByRef pSec0 As UInteger, ByRef pFrac0 As Double, ByVal NumTags0 As UInteger, ByRef ActNumTags0 As UInteger, ByRef pSec1 As UInteger, ByRef pFrac1 As Double, ByVal NumTags1 As UInteger, ByRef ActNumTags1 As UInteger) As Boolean
    Declare Function GT668ConvertRawToTTUnpacked Lib "GT668.DLL" (ByRef pRawBuf As UInteger, ByVal tags_cnt As UInteger, ByRef tags_used As UInteger, ByRef pSec0 As UInteger, ByRef pFrac0 As Double, ByVal NumTags0 As UInteger, ByRef ActNumTags0 As UInteger, ByRef pSec1 As UInteger, ByRef pFrac1 As Double, ByVal NumTags1 As UInteger, ByRef ActNumTags1 As UInteger) As Boolean

    Declare Function GT668GetDelay Lib "GT668.DLL" (ByRef enb As Boolean) As Boolean
    Declare Function GT668GetInputImpedance Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef imp As GtiImpedance) As Boolean
    Declare Function GT668GetInputCoupling Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef cpl As GtiCoupling) As Boolean
    Declare Function GT668GetInputPrescale Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef presc As GtiPrescale) As Boolean
    Declare Function GT668GetInputThreshold Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef thr_mode As GtiThrMode, ByRef thr_val As Double) As Boolean
    Declare Function GT668GetMeasEnable Lib "GT668.DLL" (ByVal ch As Integer, ByRef enb As Boolean) As Boolean
    Declare Function GT668GetMeasInput Lib "GT668.DLL" (ByVal ch As Integer, ByRef sel As GtiInputSel) As Boolean
    Declare Function GT668GetMeasSkip Lib "GT668.DLL" (ByVal ch As Integer, ByRef rate As UInteger) As Boolean
    Declare Function GT668GetMeasGate Lib "GT668.DLL" (ByVal ch As Integer, ByRef cnt As UInteger) As Boolean
    Declare Function GT668GetMeasTagArm Lib "GT668.DLL" (ByVal ch As Integer, ByRef src As GtiTagArmSrc, ByRef pol As GtiPolarity) As Boolean
    Declare Function GT668GetBlockArm Lib "GT668.DLL" (ByRef src As GtiBlkArmSrc, ByRef pol As GtiPolarity, ByRef level As Boolean) As Boolean
    Declare Function GT668GetArmAuxOut Lib "GT668.DLL" (ByRef aux_out As GtiArmAuxOut) As Boolean
    Declare Function GT668GetReferenceClock Lib "GT668.DLL" (ByRef src As GtiRefClkSrc, ByRef ref_5MHz As Boolean, ByRef aux_out As Boolean) As Boolean
    Declare Function GT668GetMemoryWrapMode Lib "GT668.DLL" (ByRef wrap As Boolean) As Boolean
    Declare Function GT668GetT0Mode Lib "GT668.DLL" (ByRef enb As Boolean) As Boolean
    Declare Function GT668GetTotalPrescale Lib "GT668.DLL" (ByVal ch As Integer, ByRef presc As UInteger) As Boolean
    Declare Function GT668GetT0 Lib "GT668.DLL" (ByRef t0 As Double) As Boolean
    Declare Function GT668GetT0Ex Lib "GT668.DLL" (ByRef t0_sec As UInteger, ByRef t0_frac As Double) As Boolean
    Declare Function GT668SelfCal Lib "GT668.DLL" () As Boolean
    Declare Function GT668GetActualInputThreshold Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef thr As Double) As Boolean
    Declare Function GT668MeasureAmplitude Lib "GT668.DLL" (ByVal sig As GtiSignal, ByRef posv As Double, ByRef negv As Double, ByVal minFreq As Double) As Boolean
    Declare Function GT668AutoPrescale Lib "GT668.DLL" (ByVal ch As Integer, ByRef presc As GtiPrescale) As Boolean
    Declare Function GT668GetError Lib "GT668.DLL" () As Integer
    Declare Function GT668GetErrorMessage_ Lib "GT668.DLL" Alias "GT668GetErrorMessage" (ByVal ErrNum As Integer, ByVal ErrMsg As StringBuilder, ByVal BufSize As Integer) As Integer
    Declare Sub GT668ClearError Lib "GT668.DLL" ()
    Declare Sub GT668SelfCalSettling Lib "GT668.DLL" (ByVal v As Double)
    Declare Function GT668ReadSysTime Lib "GT668.DLL" () As Double

    Declare Function GT668CheckAUX Lib "GT668.DLL" (ByVal dev_mask As UInteger) As Boolean
    Declare Function GT668BoardsSkewSelfCal Lib "GT668.DLL" (ByVal dev_mask As UInteger) As Boolean
    Declare Function GT668GetBoardsSkewCal Lib "GT668.DLL" (ByVal ref_dev As Integer, ByVal dev_mask As UInteger, ByVal aux_ref As Boolean, ByRef skew As Double) As Boolean

    Public Sub GT668GetDriverVersion(ByRef DrvRev As String)
        Dim Buffer As StringBuilder = New StringBuilder(256)
        Dim n As Integer
        n = GT668GetDriverVersion_(Buffer, 256)
        If n > 255 Then
            Buffer = New StringBuilder(n)
            GT668GetDriverVersion_(Buffer, n)
        End If
        DrvRev = Buffer.ToString()
    End Sub

    Public Sub GT668GetErrorMessage(ByVal ErrNum As Integer, ByRef ErrMsg As String)
        Dim Buffer As StringBuilder = New StringBuilder(256)
        Dim n As Integer
        n = GT668GetErrorMessage_(ErrNum, Buffer, 256)
        If n < 0 Then
            n = -n + 1
            Buffer = New StringBuilder(n)
            GT668GetErrorMessage_(ErrNum, Buffer, n)
        End If
        ErrMsg = Buffer.ToString()
    End Sub

    Public Function GT668GetBoardModel() As String
        Dim Buffer As StringBuilder = New StringBuilder(256)
        Dim n As Integer
        n = GT668GetBoardModel_(Buffer, 256)
        If n < 0 Then
            n = -n + 1
            Buffer = New StringBuilder(n)
            GT668GetBoardModel_(Buffer, n)
        End If
        Return Buffer.ToString()
    End Function

    Public Function GT668GetSerialNumberStr() As String
        Dim Buffer As StringBuilder = New StringBuilder(256)
        Dim n As Integer
        n = GT668GetSerialNumberStr_(Buffer, 256)
        If n < 0 Then
            n = -n + 1
            Buffer = New StringBuilder(n)
            GT668GetSerialNumberStr_(Buffer, n)
        End If
        Return Buffer.ToString()
    End Function
End Module
