# -*- coding: utf-8 -*-
import json
import csv
from ctypes import *
import ctypes
import platform
from sqlite3.dbapi2 import Time


class GT668Driver:
    """
    Class containing GT668 manipulation methods (initialization, calibration, configuration, measurements etc.).
    """
    ## -----------------------------------------------------------------------------------------------------------------
    ## --- class constructor -------------------------------------------------------------------------------------------
    ## -----------------------------------------------------------------------------------------------------------------
    def __init__(self):
        try:
            self.os = platform.system()
            if self.os == 'Windows':
                self.lib = cdll.LoadLibrary('PyGT668.dll')
                print("PyGT668Lib: Windows lib loaded successfully.")
            elif self.os == 'Linux':
                self.lib = cdll.LoadLibrary('libPyGT668.so')
                print("PyGT668Lib: Linux lib loaded successfully.")

        except Exception as e:
            print(e)

    def free_c(self, ptr):
        """
        This functions frees the c memory
        @param ptr: pointer to memory
        """
        self.lib.free_c(ptr)

    def auto_prescale(self, channel):
        """
        This function measures the minimum input prescaling needed for the input signal.
        @type  channel: int
        @param channel:
            - 0 - input channel A
            - 1 - input channel B
        @rtype:   int
        @return: Returns prescaling setting measured, see L{Prescale<GT668.Prescale>}
        """
        ret = self.lib.autoPrescale(channel)
        return c_int(ret).value
    
    def get_meas_gate(self, channel):
        """
        This function retrieves current gate size for given channel.
        @type  channel: int
        @param channel:
            - 0 - input channel A
            - 1 - input channel B
        @rtype:   int
        @return: Current gate size.
        """
        ret = self.lib.getMeasGate(channel)
        return c_int(ret).value
    
    def set_meas_gate(self, channel, cnt):
        """
        This function set an averaging gate size (as a count of measurements) over which to average results using best fit method 
        (usually for frequency or TIE measurements). Valid range is 1 to 2000000000.
        @type  channel: int
        @param channel:
            - 0 - input channel A
            - 1 - input channel B
        @type cnt: int
        @param cnt: Gate size.
        @rtype:   int
        @return: Returns I{True} if real time clock was, I{False} if not.
        """
        ret = self.lib.setMeasGate(channel, cnt)
        return c_bool(ret).value
    
    def is_real_time_set(self):
        """
        This function checks if the real time clock was set since the board was powered on.
        @rtype: bool
        @return:  Returns I{True} if real time clock was, I{False} if not.
        """
        ret = self.lib.isRealTimeSet()
        return c_bool(ret).value

    def block_arm_command(self, arm):
        """
        This function sets the level of the software arm signal for block arming.
        @type  arm: bool
        @param arm:
            - True - set arm signal high
            - False - set arm signal low
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        ret = self.lib.blockArmCommand(arm)
        return c_bool(ret).value

    def board_number(self, device, board):
        """
        This function maps a physical board number (determined by the order in which the operating system
        scans all computer slots) into a logical device number. By default device number is the same as the board
        number.
        B{NOTE}: This function should be called before calling L{initialize<GT668Driver.initialize>} for the same board number or the
        same device number.
        @type  device: int
        @param device: logical device number
        @type board: int
        @param board: physical board number
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        ret = self.lib.boardNumber(device, board)
        return c_bool(ret).value

    def close(self):
        """This function closes the current board."""
        self.lib.closeBoard()

    def enumerate_board(self, first):
        """
        This function enumerates all GT668 boards in the computer. This function can be called at any time, even
        before any call to L{initialize<GT668Driver.initialize>}.
        @type  first: bool
        @param first: Should be set to I{'True'} on the first call and to I{'False'} on all subsequent calls
        @rtype:   int
        @return:  When B{first} is set to I{True} the function will return the first board number found (lowest
        number), when B{first} is set to I{False} it will return the next board number found, if no more boards are found
        the function will return -1.
        """
        ret = self.lib.enumerateBoards(first)
        return c_int(ret).value

    def get_base_seconds(self):
        """
        This function retrieves the current setting of the base seconds. (See L{set_base_seconds<GT668Driver.set_base_seconds>}).
        @rtype:   unsigned int
        @return: Base seconds value.
        """
        ret = self.lib.getBaseSeconds()
        return c_int(ret).value

    def get_arm_aux_out(self):
        """
        This function retrieves the current selection of the AUX bus arm output (See L{set_arm_aux_out<GT668Driver.set_arm_aux_out>}).
        @rtype:   string
        @return: Returns retrieved setting (See L{ArmAuxOut<GT668.ArmAuxOut>}).
        """
        self.lib.getArmAuxOut.restype = c_char_p
        ret = self.lib.getArmAuxOut()
        return ret

    def get_block_arm(self):
        """
        This function retrieves the current setting of the block arm. (See L{set_block_arm<GT668Driver.set_block_arm>}).
        @rtype:  dict
        @return: Returns dictionary object containing following entries:
            - B{I{src}} - string, see L{BlkArmSrc<GT668.BlkArmSrc>}
            - B{I{polarity}} - string, see L{Polarity<GT668.Polarity>}
            - B{I{level}} - bool
        """
        self.lib.getBlockArm.argtypes = [POINTER(c_char_p), POINTER(c_char_p), POINTER(c_bool)]
        c_blkArm = c_char_p(0)
        c_blkPol = c_char_p(0)
        c_level = c_bool(0)

        self.lib.getBlockArm(c_blkArm, c_blkPol, c_level)

        obj = {
            'src'   : c_blkArm.value,
            'polarity'   : c_blkPol.value,
            'level' : c_level.value
        }

        return obj

    def get_error(self):
        """
        This function retrieves the last driver error encountered.
        @rtype:  int
        @return: Returns the error code (0 means no error). Use I{L{get_error_message<GT668Driver.get_error_message>}} to translate it to an error message.
        """
        ret = self.lib.getError()
        return c_int(ret).value

    def get_input_coupling(self, signal):
        """
        This function retrieves the current settings of the input coupling of an input signal (L{GT_CPL_DC<GT668.Coupling.GT_CPL_DC>} or
        L{GT_CPL_AC<GT668.Coupling.GT_CPL_AC>}). Clock and Arm signal will always return L{GT_CPL_DC<GT668.Coupling.GT_CPL_DC>}
        (see L{get_input_coupling<GT668Driver.get_input_coupling>}).

        @type  signal: string
        @param signal: see L{Signal<GT668.Signal>}
            - L{GT_SIG_A<GT668.Signal.GT_SIG_A>} - Input channel A
            - L{GT_SIG_B<GT668.Signal.GT_SIG_B>} - Input channel B
            - L{GT_SIG_CLK<GT668.Signal.GT_SIG_CLK>} - Clock input
            - L{GT_SIG_ARM<GT668.Signal.GT_SIG_ARM>} - Arm Input

        @rtype:  string
        @return: Returns the retrieved setting.
        """
        self.lib.getInputCoupling.restype = c_char_p
        self.lib.getInputCoupling.argtypes = [c_char_p(0)]
        c_signal = c_char_p(signal)

        ret = self.lib.getInputCoupling(c_signal)        
        return ret

    def get_input_impedance(self, signal):
        """
        This function retrieves the current settings of the input impedance of an input signal (L{GT_IMP_LO<GT668.Impedance.GT_IMP_LO>} or
        L{GT_IMP_HI<GT668.Impedance.GT_IMP_HI>}). Clock and Arm signal will always return L{GT_IMP_HI<GT668.Impedance.GT_IMP_HI>}
        (see L{set_input_impedance<GT668Driver.set_input_impedance>}).

        @type  signal: string
        @param signal: see L{Signal<GT668.Signal>}
            - L{GT_SIG_A<GT668.Signal.GT_SIG_A>} - Input channel A
            - L{GT_SIG_B<GT668.Signal.GT_SIG_B>} - Input channel B
            - L{GT_SIG_CLK<GT668.Signal.GT_SIG_CLK>} - Clock input
            - L{GT_SIG_ARM<GT668.Signal.GT_SIG_ARM>} - Arm Input

        @rtype:  string
        @return: Returns the retrieved setting.
        """
        self.lib.getInputImpedance.restype = c_char_p
        self.lib.getInputImpedance.argtypes = [c_char_p(0)]
        c_signal = c_char_p(signal)

        ret = self.lib.getInputImpedance(c_signal)
        return ret

    def get_input_prescale(self, signal):
        """
        This function retrieves the current settings of the input prescaling of an input signal (L{GT_DIV_AUTO<GT668.Prescale.GT_DIV_AUTO>} or
        L{GT_DIV_1<GT668.Prescale.GT_DIV_1>} through L{GT_DIV_1024<GT668.Prescale.GT_DIV_1024>}). Clock and Arm signal will always return L{GT_DIV_1<GT668.Prescale.GT_DIV_1>}
        (see L{set_input_prescale<GT668Driver.set_input_prescale>}).

        @type  signal: string
        @param signal: see L{Signal<GT668.Signal>}
            - L{GT_SIG_A<GT668.Signal.GT_SIG_A>} - Input channel A
            - L{GT_SIG_B<GT668.Signal.GT_SIG_B>} - Input channel B

        @rtype:  int
        @return: Returns the retrieved setting (see L{Prescale<GT668.Prescale>}).
        """
        self.lib.getInputPrescale.argtypes = [c_char_p]
        c_signal = c_char_p(signal)

        ret = self.lib.getInputPrescale(c_signal)

        return c_int(ret).value

    def get_input_threshold(self, signal):
        """
        This function retrieves the current settings of the input threshold (mode and value) of an input signal.
        (see L{set_input_threshold<GT668Driver.set_input_threshold>}).

        @type  signal: string
        @param signal: see L{Signal<GT668.Signal>}
            - L{GT_SIG_A<GT668.Signal.GT_SIG_A>} - Input channel A
            - L{GT_SIG_B<GT668.Signal.GT_SIG_B>} - Input channel B
            - L{GT_SIG_CLK<GT668.Signal.GT_SIG_CLK>} - Clock input
            - L{GT_SIG_ARM<GT668.Signal.GT_SIG_ARM>} - Arm Input

        @rtype:  dict
        @return: Returns dictionary object containing following entries:
            - B{I{threshMode}} - string, see L{ThresholdMode<GT668.ThresholdMode>}
            - B{I{value}} - double
        """
        self.lib.getInputThreshold.argtypes = [c_char_p, POINTER(c_char_p), POINTER(c_double)]
        c_signal = c_char_p(signal)
        c_threshMode = c_char_p(0)
        c_value = c_double(0)

        self.lib.getInputThreshold(c_signal, c_threshMode, c_value)

        obj = {
            'threshMode' : c_threshMode.value,
            'value'      : c_value.value
        }

        return obj

    def get_meas_enable(self, channel):
        """
        This function retrieves the current enable state of a measurement channel (see L{get_meas_enable<GT668Driver.set_meas_enable>}).
        @type  channel: bool
        @param channel:
            - 0 - input channel A
            - 1 - input channel B
        @rtype:   bool
        @return:  Returns I{True} if channel is enabled, I{False} otherwise.
        """
        ret = self.lib.getMeasEnable(channel)
        return c_bool(ret).value

    def get_meas_input(self, channel):
        """
        This function retrieves the current input signal selection of a measurement channel (see L{set_meas_input<GT668Driver.set_meas_input>}).
        @type  channel: string
        @param channel:
            - 0 - input channel A
            - 1 - input channel B
        @rtype:   bool
        @return:  Returns retrieved setting (see L{InputSel<GT668.InputSel>}).
        """
        self.lib.getMeasInput.restype = c_char_p
        ret = self.lib.getMeasInput(channel)
        return ret

    def get_meas_skip(self, channel):
        """
        This function retrieves the current setting of the measurements skip rate of a measurement channel (see L{set_meas_skip<GT668Driver.set_meas_skip>}).
        @type  channel: int
        @param channel:
            - 0 - input channel A
            - 1 - input channel B
        @rtype:   int
        @return:  Returns retrieved setting.
        """
        ret = self.lib.getMeasSkip(channel)
        return c_int(ret).value

    def get_meas_tag_arm(self, channel):
        """
        This function retrieves the current setting of the tag arm of a measurement channel (see L{set_meas_tag_arm<GT668Driver.set_meas_tag_arm>}).
        @type  channel: int
        @param channel:
            - 0 - input channel A
            - 1 - input channel B
        @rtype:   dict
        @return: Returns dictionary object containing following entries
            - B{I{channel}} - int
            - B{I{tagArm}} - string, see L{TagArmSrc<GT668.TagArmSrc>}
            - B{I{polarity}} - sting,  see L{Polarity<GT668.Polarity>}
        """
        self.lib.getMeasTagArm.argtypes = [c_int, POINTER(c_char_p), POINTER(c_char_p)]
        c_channel = c_int(channel)
        c_tagArm = c_char_p(0)
        c_polarity = c_char_p(0)

        self.lib.getMeasTagArm(c_channel, c_tagArm, c_polarity)

        obj = {
            'channel'       : c_channel.value,
            'tagArm'        : c_tagArm.value,
            'polarity'      : c_polarity.value
        }

        return obj

    def get_memory_wrap_mode(self):
        """
        This function retrieves the current memory "wrap" mode (see L{set_memory_wrap_mode<GT668Driver.set_memory_wrap_mode>}).
        @rtype:   bool
        @return: Returns I{True} if wrap mode is switched on, I{False} otherwise.
        """
        ret = self.lib.getMemoryWrap()
        return c_bool(ret).value

    def get_serial_number(self):
        """
        This function retrieves the serial number of the current device.
        @rtype:   int
        @return: Returns the serial number.
        """
        ret = self.lib.getSerialNumber()
        return c_int(ret).value

    def get_reference_clock(self):
        """
        This function retrieves the current setting of the reference clock (see L{set_reference_clock<GT668Driver.set_reference_clock>}).
        @rtype:   dict
        @return: Returns dictionary object containing following entries
            - B{I{refClk}} - string, see L{RefClkSrc<GT668.RefClkSrc>}
            - B{I{ref5MHz}} - bool
            - B{I{polarity}} - bool
        """
        self.lib.getRefClock.argtypes = [POINTER(c_char_p), POINTER(c_bool), POINTER(c_bool)]
        c_refClk = c_char_p(0)
        c_ref5mhz = c_bool(0)
        c_auxOut = c_bool(0)

        self.lib.getRefClock(c_refClk, c_ref5mhz, c_auxOut)

        obj = {
            'refClk'       : c_refClk.value,
            'ref5MHz'      : c_ref5mhz.value,
            'auxOut'       : c_auxOut.value
        }

        return obj

    def get_T0(self):
        """
        This function retrieves the reference time (t0) for the current set of measurements.
        @rtype:   double
        @return: Returns retrieved value.
        """
        self.lib.getT0.restype = ctypes.c_double
        return self.lib.getT0()

    def get_T0_mode(self):
        """
        This function retrieves the setting for the t0 mode (see L{set_T0_mode<GT668Driver.set_T0_mode>}).
        @rtype:   dict
        @return: Returns dictionary object containing following entries
            - B{I{arm}} - bool
            - B{I{rel}} - bool
        """
        self.lib.getT0Mode.argtypes = [POINTER(c_bool), POINTER(c_bool)]
        c_arm = c_bool(0)
        c_rel = c_bool(0)

        self.lib.getT0Mode(c_arm, c_rel)

        obj = {
            'arm'      : c_arm.value,
            'rel'      : c_rel.value
        }

        return obj

    def get_total_prescale(self, channel):
        """
        This function retrieves the total current prescaling of a measurement channel. The total prescaling is
        calculated by multiplying the prescaling of the input signal selected for this measurement channel and the
        measurements prescaling. If the input prescaling is set to L{GT_DIV_AUTO<GT668.Prescale.GT_DIV_AUTO>} the function will use the
        prescaling value selected during the last call to L{start_measurements<GT668Driver.start_measurements>}
        @rtype:   unsigned int
        @return: Returns retrieved value.
        """
        ret = self.lib.getTotalPrescale(channel)
        return c_uint(ret).value

    def init_default(self, keep_ref):
        """
        This function initializes the current board to default setup, with the possible exception of the reference
        clock selection (to avoid settling time penalty).
        @type  keep_ref: bool
        @param keep_ref: If keep_ref is I{True} the current clock reference selection will be kept
                         unchanged, if it's I{False} the clock reference will be set to default value
                         (internal clock).
        """
        self.lib.initDefault(keep_ref)

    def initialize(self, device):
        """
        This function initializes a board and selects it as the current one.
        @type  device: int
        @param device: Board number to initialize
        @rtype:   bool
        @return:  Returns I{False} if initialization failed, I{True} if initialization was successful.
        """
        ret = self.lib.initialize(device)
        return c_bool(ret).value

    def is_initialized(self, device):
        """
        This function checks if a board is initialized.
        @type  device: int
        @param device: Board number to check
        @rtype:   bool
        @return:  Returns I{True} if initialized, I{False} if not.
        """
        ret = self.lib.isInitialized(device)
        return c_bool(ret).value

    def select(self, device):
        """
        This function selects a board. All subsequent operations will apply to this board.
        @type  device: int
        @param device: Board number to select
        @rtype:   bool
        @return:  Returns I{False} if selection failed (probably board was not initialized), I{True} if selection was successful.
        """
        ret = self.lib.selectBoard(device)
        return c_bool(ret).value

    def self_cal(self):
        """
        This function runs self-calibration.
        @rtype:   bool
        @return:  Returns I{False} if self-calibration failed,, I{True} if self-calibration was successful.
        """
        ret = self.lib.selfCal()
        return c_bool(ret).value

    def set_arm_aux_out(self, armAuxOut):
        """
        This function selects the arming output to the AUX bus.
        @type  armAuxOut: string
        @param armAuxOut: see L{ArmAuxOut<GT668.ArmAuxOut>}
            - L{GT_AUX_OUT_OFF<GT668.ArmAuxOut.GT_AUX_OUT_OFF>} - No arming on the AUX bus
            - L{GT_AUX_OUT_BA<GT668.ArmAuxOut.GT_AUX_OUT_BA>} - Output the block arm to AUX
            - L{GT_AUX_OUT_TA0<GT668.ArmAuxOut.GT_AUX_OUT_TA0>} - Output the tag arm from channel 0 to AUX
            - L{GT_AUX_OUT_TA1<GT668.ArmAuxOut.GT_AUX_OUT_TA1>} - Output the tag arm from channel 1 to AUX
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """

        self.lib.setArmAuxOut.argtypes = [c_char_p(0)]
        c_armAuxOut = c_char_p(armAuxOut)

        ret = self.lib.setArmAuxOut(c_armAuxOut)

        return c_bool(ret).value

    def set_block_arm(self, blkArm, polarity, level):
        """
        This function selects the block arming source.
        @type  blkArm: string
        @param blkArm: see L{BlkArmSrc<GT668.BlkArmSrc>}
            - L{GT_BA_IMM<GT668.BlkArmSrc.GT_BA_IMM>} - Arm immediately when the channel is ready
            - L{GT_BA_SW<GT668.BlkArmSrc.GT_BA_SW>} - Arm by software call to L{tag_arm_command<GT668Driver.tag_arm_command>}
            - L{GT_BA_EXT<GT668.BlkArmSrc.GT_BA_EXT>} - Arm from edge of external ARM signal
            - L{GT_BA_AUX<GT668.BlkArmSrc.GT_BA_AUX>} - Arm from arming signal on AUX bus
            - L{GT_BA_CH0<GT668.BlkArmSrc.GT_BA_CH0>} - Arm from measurement channel 0
            - L{GT_BA_CH1<GT668.BlkArmSrc.GT_BA_CH1>} - Arm from measurement channel 1
            - L{GT_BA_OFF<GT668.BlkArmSrc.GT_BA_OFF>} - Do not arming (same as disabling the channel)
        @type  polarity: string
        @param polarity: see L{BlkArmSrc<GT668.BlkArmSrc>}
            - L{GT_POL_POS<GT668.Polarity.GT_POL_POS>} - Use positive edge of external Arm
            - L{GT_POL_NEG<GT668.Polarity.GT_POL_NEG>} - Use negative edge of external Arm
        @type  level: bool
        @param level:
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setBlockArm.argtypes = [c_char_p, c_char_p, c_bool]
        c_blkArm = c_char_p(blkArm)
        c_polarity = c_char_p(polarity)
        c_level = c_bool(level)

        ret = self.lib.setBlockArm(c_blkArm, c_polarity, c_level)

        return c_bool(ret).value

    def set_base_seconds(self, seconds):
        """
        This function sets a base in whole seconds for the following time tags (future time tags value will be
        relative to this value).
        The base seconds is used to eliminate the problem of lost resolution over long time intervals (1000
        seconds and more). Because the time tags are represented as double precision floating point numbers
        when the time value gets above 1000 seconds the least significant bit becomes 1 ps and from there on
        resolution will be lost. Setting the base seconds of the time tags to 1000 (for example) with a call to
        L{set_base_seconds(1000)<GT668Driver.set_base_seconds>} will reduce the time tag value to a value close to 0 with least significant bit
        of 1 fs.
        Default value of base seconds is 0.
        @type  seconds: unsigned int
        @param seconds: Base seconds for the following time tags. The value must be less than or
                        equal to the seconds' part of the last time tag
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setBaseSeconds.argtypes = [c_int]
        c_seconds = c_int(seconds)
        ret = self.lib.setBaseSeconds(c_seconds)
        return c_bool(ret).value

    def set_input_coupling(self, signal, coupling):
        """
        This function sets the input coupling of a measured signal to DC or to AC.
        B{NOTE}: Clock and Arm signals support only DC coupling.
        @type  signal: string
        @param signal: see L{Signal<GT668.Signal>}
            - L{GT_SIG_A<GT668.Signal.GT_SIG_A>} - Input channel A
            - L{GT_SIG_B<GT668.Signal.GT_SIG_B>} - Input channel B
            - L{GT_SIG_CLK<GT668.Signal.GT_SIG_CLK>} - Clock input
            - L{GT_SIG_ARM<GT668.Signal.GT_SIG_ARM>} - Arm Input
        @type  coupling: string
        @param coupling: see L{Coupling<GT668.Coupling>}
            - L{GT_CPL_DC<GT668.Coupling.GT_CPL_DC>} - DC coupling
            - L{GT_CPL_AC<GT668.Coupling.GT_CPL_AC>} - AC coupling
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setInputCoupling.argtypes = [c_char_p, c_char_p]
        c_signal = c_char_p(signal)
        c_coupling = c_char_p(coupling)

        ret = self.lib.setInputCoupling(c_signal, c_coupling)

        return c_bool(ret).value

    def set_input_impedance(self, signal, impedance):
        """
        This function sets the input impedance of a measured signal to low impedance (50 Ohm) or to high
        impedance (1 KOhm).
        B{NOTE}: Clock and Arm signals support only high impedance.
        @type  signal: string
        @param signal: see L{Signal<GT668.Signal>}
            - L{GT_SIG_A<GT668.Signal.GT_SIG_A>} - Input channel A
            - L{GT_SIG_B<GT668.Signal.GT_SIG_B>} - Input channel B
            - L{GT_SIG_CLK<GT668.Signal.GT_SIG_CLK>} - Clock input
            - L{GT_SIG_ARM<GT668.Signal.GT_SIG_ARM>} - Arm Input
        @type  impedance: string
        @param impedance: see L{Impedance<GT668.Impedance>}
            - L{GT_IMP_LO<GT668.Impedance.GT_IMP_LO>} - Low impedance
            - L{GT_IMP_HI<GT668.Impedance.GT_IMP_HI>} - High impedance
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setInputImpedance.argtypes = [c_char_p, c_char_p]
        c_signal = c_char_p(signal)
        c_impedance = c_char_p(impedance)

        ret = self.lib.setInputImpedance(c_signal, c_impedance)

        return c_bool(ret).value

    def set_input_prescale(self, signal, prescale):
        """
        This function sets the hardware input prescaling of a measured signal to divide the input by a power of 2
        value between 1 and 1024. The prescaling must be high enough to reduce the measured signal to a
        frequency under 4MHz.
        B{NOTE}: Clock and Arm signals do not support prescaling (same as L{GT_DIV_1<GT668.Prescale.GT_DIV_1>}).
        @type  signal: string
        @param signal: see L{Signal<GT668.Signal>}
            - L{GT_SIG_A<GT668.Signal.GT_SIG_A>} - Input channel A
            - L{GT_SIG_B<GT668.Signal.GT_SIG_B>} - Input channel B
            - L{GT_SIG_CLK<GT668.Signal.GT_SIG_CLK>} - Clock input
            - L{GT_SIG_ARM<GT668.Signal.GT_SIG_ARM>} - Arm Input
        @type  prescale: int
        @param prescale: see L{prescale<GT668.Prescale>}
            - L{GT_DIV_AUTO<GT668.Prescale.GT_DIV_AUTO>} - Select automatically the minimal prescaling value
            needed to bring the signal under 4MHz
            - L{GT_DIV_1<GT668.Prescale.GT_DIV_1>} - divide by 1 (no prescaling)
            - L{GT_DIV_2<GT668.Prescale.GT_DIV_2>} - divide by 2
            - L{GT_DIV_4<GT668.Prescale.GT_DIV_4>} - divide by 4
            - L{GT_DIV_8<GT668.Prescale.GT_DIV_8>} - divide by 8
            - L{GT_DIV_16<GT668.Prescale.GT_DIV_16>} - divide by 16
            - L{GT_DIV_32<GT668.Prescale.GT_DIV_32>} - divide by 32
            - L{GT_DIV_64<GT668.Prescale.GT_DIV_64>} - divide by 64
            - L{GT_DIV_128<GT668.Prescale.GT_DIV_128>} - divide by 128
            - L{GT_DIV_256<GT668.Prescale.GT_DIV_256>} - divide by 256
            - L{GT_DIV_512<GT668.Prescale.GT_DIV_512>} - divide by 512
            - L{GT_DIV_1024<GT668.Prescale.GT_DIV_1024>} - divide by 1024
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setInputPrescale.argtypes = [c_char_p, c_int]
        c_signal = c_char_p(signal)
        c_prescale = c_int(prescale)

        ret = self.lib.setInputPrescale(c_signal, c_prescale)

        return c_bool(ret).value

    def set_input_threshold(self, signal, threshMode, value):
        """
        This function sets the input threshold either to a specific voltage value or to a percentage from a measured
        peak to peak voltage.
        @type  signal: string
        @param signal: see L{Signal<GT668.Signal>}
            - L{GT_SIG_A<GT668.Signal.GT_SIG_A>} - Input channel A
            - L{GT_SIG_B<GT668.Signal.GT_SIG_B>} - Input channel B
            - L{GT_SIG_CLK<GT668.Signal.GT_SIG_CLK>} - Clock input
            - L{GT_SIG_ARM<GT668.Signal.GT_SIG_ARM>} - Arm Input
        @type  threshMode: string
        @param threshMode: see L{ThresholdMode<GT668.ThresholdMode>}
            - L{GT_THR_PERCENTS<GT668.ThresholdMode.GT_THR_PERCENTS>} - Set threshold by percentage of peak-to-peak
            - L{GT_THR_VOLTS<GT668.ThresholdMode.GT_THR_VOLTS>} - Set threshold to absolute voltage
        @type  value: double
        @param value: Threshold to be used, either in percentage or in Volts according to the
            value of threshMode
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setInputThreshold.argtypes = [c_char_p, c_char_p, c_double]
        c_signal = c_char_p(signal)
        c_threshMode = c_char_p(threshMode)
        c_value = c_double(value)

        ret = self.lib.setInputThreshold(c_signal, c_threshMode, c_value)

        return c_bool(ret).value

    def set_meas_enable(self, channel, enabled):
        """
        This function enables or disables a measurement channel.
        @type  channel: int
        @param channel:
            - 0 - input channel A
            - 1 - input channel B
        @type  enabled: bool
        @param enabled:
            - True - enabled
            - False - disabled
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        ret = self.lib.setMeasEnable(channel, enabled)
        return c_bool(ret).value

    def set_meas_input(self, channel, input_sel):
        """
        This function selects the input source for a measurement channel.
        @type  channel: int
        @param channel:
            - 0 - input channel A
            - 1 - input channel B
        @type  input_sel: string
        @param input_sel: see L{InputSel<GT668.InputSel>}
            - L{GT_CHA_POS<GT668.InputSel.GT_CHA_POS>} - Measure positive edges on input channel A
            - L{GT_CHA_NEG<GT668.InputSel.GT_CHA_NEG>} - Measure negative edges on input channel A
            - L{GT_CHB_POS<GT668.InputSel.GT_CHB_POS>} - Measure positive edges on input channel B
            - L{GT_CHB_NEG<GT668.InputSel.GT_CHB_NEG>} - Measure negative edges on input channel B
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setMeasInput.argtypes = [c_int, c_char_p]
        c_channel = c_int(channel)
        c_input_sel = c_char_p(input_sel)

        ret = self.lib.setMeasInput(c_channel, c_input_sel)

        return c_bool(ret).value

    def set_meas_skip(self, channel, rate):
        """
        This function sets the measurements skip rate for a measurement channel. This will cause the
        measurement channel to drop rate out of every (rate + 1) time tags. If rate value is 0 - no prescaling will
        be done.
        @type  channel: int
        @param channel:
            - 0 - input channel A
            - 1 - input channel B
        @type  rate: unsigned int
        @param rate: Prescaling value (0 to 999999)
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setMeasSkip.argtypes = [c_int, c_uint]
        c_channel = c_int(channel)
        c_rate = c_uint(rate)

        ret = self.lib.setMeasSkip(c_channel, c_rate)

        return c_bool(ret).value

    def set_meas_tag_arm(self, channel, tagArm, polarity):
        """
        This function selects the time tag arming source for a measurement channel.
        @type  channel: int
        @param channel:
            - 0 - input channel A
            - 1 - input channel B
        @type  tagArm: string
        @param tagArm: see L{TagArmSrc<GT668.TagArmSrc>}
            - L{GT_TA_IMM<GT668.TagArmSrc.GT_TA_IMM>} - Arm immediately when the channel is ready
            - L{GT_TA_SW<GT668.TagArmSrc.GT_TA_SW>} - Arm by software call to L{tag_arm_command<GT668Driver.tag_arm_command>}
            - L{GT_TA_EXT<GT668.TagArmSrc.GT_TA_EXT>} - Arm from edge of external ARM signal
            - L{GT_TA_AUX<GT668.TagArmSrc.GT_TA_AUX>} - Arm from arming signal on AUX bus
            - L{GT_TA_OTHER<GT668.TagArmSrc.GT_TA_OTHER>} - Arm from other channel
            - L{GT_TA_OFF<GT668.TagArmSrc.GT_TA_OFF>} - Do not arming (same as disabling the channel)
        @type  polarity: string
        @param polarity: see L{BlkArmSrc<GT668.BlkArmSrc>}
            - L{GT_POL_POS<GT668.Polarity.GT_POL_POS>} - Use positive edge of external Arm
            - L{GT_POL_NEG<GT668.Polarity.GT_POL_NEG>} - Use negative edge of external Arm
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setMeasTagArm.argtypes = [c_int, c_char_p, c_char_p]
        c_channel = c_int(channel)
        c_tagArm = c_char_p(tagArm)
        c_polarity = c_char_p(polarity)

        ret = self.lib.setMeasTagArm(c_channel, c_tagArm, c_polarity)

        return c_bool(ret).value

    def set_memory_wrap_mode(self, wrap):
        """
        This function enables or disabled the "wrap" mode of the instrument's memory. If "wrap" mode is enable
        the instrument will work continuously (as long as the user reads the time tags fast enough). If "wrap"
        mode is disabled the instrument will fill the memory and stop.
        @type  wrap: bool
        @param wrap:
            - True - "Wrap" mode enabled
            - False - Wrap" mode disabled
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        ret = self.lib.setMemoryWrapMode(wrap)
        return c_bool(ret).value

    def set_reference_clock(self, refClk, ref5MHz, auxOut):
        """
        This function selects the source of the instrument's clock.
        @type  refClk: string
        @param refClk: see L{RefClkSrc<GT668.RefClkSrc>}
            - L{GT_REF_INTERNAL<GT668.RefClkSrc.GT_REF_INTERNAL>} - Use the internal clock on-board.
            - L{GT_REF_EXTERNAL<GT668.RefClkSrc.GT_REF_EXTERNAL>} - Lock to the 10MHz external clock input.
            - L{GT_REF_PXI<GT668.RefClkSrc.GT_REF_PXI>} - Use the clock from the PXI chassis (valid only for GT668PXI boards).
            - L{GT_REF_AUX<GT668.RefClkSrc.GT_REF_AUX>} - Use the clock transmitted on the AUX bus.
        @type  ref5MHz: bool
        @param ref5MHz:
            - True - Reference clock is 5MHz (valid only with L{GT_REF_EXTERNAL<GT668.RefClkSrc.GT_REF_EXTERNAL>} option)
            - False - Reference clock is 10MHz
        @type  auxOut: bool
        @param auxOut:
            - True - Output the selected clock to the AUX bus (invalid with L{GT_REF_AUX<GT668.RefClkSrc.GT_REF_AUX>} option)
            - False - Do not output clock to the AUX bus
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setReferenceClock.argtypes = [c_char_p, c_bool, c_bool]
        c_refClk = c_char_p(refClk)
        c_ref5MHz = c_bool(ref5MHz)
        c_auxOut = c_bool(auxOut)

        ret = self.lib.setReferenceClock(c_refClk, c_ref5MHz, c_auxOut)

        return c_bool(ret).value

    def set_T0_mode(self, arm, rel):
        """
        This function configure the T0 mode. The B{arm} value selects if the reference time (t0) will be generated
        from the block arming tag (with 20ns resolution) or from the first time tag (full channel resolution). The
        B{rel} value selects if the T0 value will be subtracted from all time tags.
        @type  arm: bool
        @param arm:
            - True - t0 generated from block arm
            - False - t0 generated from first time tag
        @type  rel: bool
        @param rel:
            - True - t0 will be subtracted from all time tags
            - False - t0 will not be subtracted from all time tags
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        ret = self.lib.setT0Mode(arm, rel)
        return c_bool(ret).value

    def start_measurements(self):
        """
        This function loads the user specified configuration into the instrument and starts a set of measurements.
        @rtype:   bool
        @return:  Returns I{False} if failed, I{True} if successful.
        """
        ret = self.lib.startMeasurements()
        return c_bool(ret).value

    def stop_measurements(self):
        """
        This function stops the measurements.
        @rtype:   bool
        @return:  Returns I{False} if failed, I{True} if successful.
        """
        ret = self.lib.stopMeasurements()
        return c_bool(ret).value

    def tag_arm_command(self, ch0, ch1):
        """
        This function sets the level of the software arm signals for tag arming on both measurement channels.
        @type  ch0: bool
        @param ch0:
            - True - set arm signal for channel 0 high
            - False - set arm signal for channel 0 low
        @type  ch1: bool
        @param ch1:
            - True - set arm signal for channel 1 high
            - False - set arm signal for channel 1 low
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        ret = self.lib.tagArmCommand(ch0, ch1)
        return c_bool(ret).value

    def measure_amplitude(self, signal, min_freq):
        """
        This function measures the peak voltages of an input signal. Because the measurement is done by a
        threshold search the measurement can be slow if the frequency of the signal is low. The measurement
        takes about 60 msec + 36 * (signal maximum period).
        @type  signal: string
        @param signal: see L{Signal<GT668.Signal>}
            - L{GT_SIG_A<GT668.Signal.GT_SIG_A>} - Input channel A
            - L{GT_SIG_B<GT668.Signal.GT_SIG_B>} - Input channel B
            - L{GT_SIG_CLK<GT668.Signal.GT_SIG_CLK>} - Clock input
            - L{GT_SIG_ARM<GT668.Signal.GT_SIG_ARM>} - Arm Input
        @type  min_freq: double
        @param min_freq: Minimum frequency of the measured signal. Using a value lower than necessary may slow down the measurement
        @rtype:   dict
        @return: Returns dictionary object containing following entries
            - B{I{posv}} - double, Positive peak voltage
            - B{I{negv}} - double, Negative peak voltage
        """
        self.lib.measureAmplitude.argtypes = [c_char_p, c_double, POINTER(c_double), POINTER(c_double)]
        c_signal = c_char_p(signal)
        c_min_freq = c_double(min_freq)
        c_posv = c_double(0)
        c_negv = c_double(0)

        self.lib.measureAmplitude(c_signal, c_min_freq, c_posv, c_negv)

        obj = {
            'posv'      : c_posv.value,
            'negv'      : c_negv.value
        }

        return obj

    def get_error_message(self, error):
        """
        This function translates an error code (returned from L{get_error<GT668Driver.get_error>}) in to an error message.
        @type error: int
        @param error: Error code
        @rtype:   string
        @return: The error message
        """
        self.lib.getErrorMessage.argtypes = [c_int, POINTER(c_char_p), c_uint]
        c_message = c_char_p(b"")
        c_error = c_int(int(error))
        c_size = c_int(512)

        self.lib.getErrorMessage(c_error, c_message, c_size)
        return c_message.value.decode("utf-8")

    def get_realtime_output_status(self):
        """
        This function retrieves how many pending RealTime output commands are in
        the FIFO buffer of output signals OUT0 and OUT1
        See L{set_output<GT668Driver.set_output>} and L{real_time_output<GT668Driver.real_time_output>}).
        @rtype:   dict
        @return: Returns dictionary object containing following entries
            - B{I{pending0}} - retrieved number of pending output commands for OUT0
            - B{I{pending1}} - retrieved number of pending output commands for OUT1
        """

        self.lib.getRealTimeOutputStatus.argtypes = [POINTER(c_int), POINTER(c_int)]
        c_used0 = c_int(0)
        c_used1 = c_int(0)
        ret = self.lib.getRealTimeOutputStatus(c_used0, c_used1)
        obj = {
            'pending0': c_used0.value,
            'pending1': c_used1.value
        }

        return obj

    def read_timetags(self, timetagsSet):
        """
        The function will read up-to the requested number of time tags,
        but will stop sooner if the number of time tags available is smaller.
        
        @rtype:   obj
        @return: Returns L{TimetagsSet<GT668Driver.TimetagsSet>} object containing following fields:
            - B{I{channel0Tags}} - double[], Array with time tags from channel 0
            - B{I{channel0Count}} - int, Number of time tags actually read from channel 0
            - B{I{channel1Tags}} - double[], Array with time tags from channel 0
            - B{I{channel1Count}} - int, Number of time tags actually read from channel 1
        """
        self.lib.readTimetags.argtypes = [POINTER(c_double), c_int, POINTER(c_int), POINTER(c_double), 
        c_int, POINTER(c_int)]

        c_outdata0 = (c_double * timetagsSet.channel0Size)(0)
        c_count0 = c_int(timetagsSet.channel0Size - timetagsSet.channel0Count)
        c_ch0read = c_int(0)

        c_outdata1 = (c_double * timetagsSet.channel1Size)(0)
        c_count1 = c_int(timetagsSet.channel1Size - timetagsSet.channel1Count)
        c_ch1read = c_int(0)

        read = self.lib.readTimetags
        read(c_outdata0, c_count0, c_ch0read, c_outdata1, c_count1, c_ch1read)

        idx = timetagsSet.channel0Count
        for i, tag in enumerate(c_outdata0[:c_ch0read.value]):
            timetagsSet.channel0Tags[idx + i] = tag
        timetagsSet.channel0Count += c_ch0read.value

        idx = timetagsSet.channel1Count
        for i, tag in enumerate(c_outdata1[:c_ch1read.value]):
            timetagsSet.channel1Tags[idx + i] = tag
        timetagsSet.channel1Count += c_ch1read.value
    
    def read_real_timetags(self, realTimetagsSet):
        """
        The function will read up-to the requested number of time tags,
        but will stop sooner if the number of time tags available is smaller.
        
        @rtype:   obj
        @return: Returns L{RealTimetagsSet<GT668Driver.RealTimetagsSet>} object containing following fields:
            - B{I{channel0Sec}} - int[], Array with second part of tags from channel 0
            - B{I{channel0Frac}} - double[], Array with frac part of tags from channel 0
            - B{I{channel0Count}} - int, Number of time tags actually read from channel 0
            - B{I{channel1Sec}} - int[], Array with second part of tags from channel 1
            - B{I{channel1Frac}} - double[], Array with frac part of tags from channel 1
            - B{I{channel1Count}} - int, Number of time tags actually read from channel 1
        """
        self.lib.readRealTimetags.argtypes = [POINTER(c_int), POINTER(c_double), c_int, POINTER(c_int), 
                                              POINTER(c_int), POINTER(c_double), c_int, POINTER(c_int)]

        c_sec0 = (c_int * realTimetagsSet.channel0Size)(0)
        c_frac0 = (c_double * realTimetagsSet.channel0Size)(0)
        c_count0 = c_int(realTimetagsSet.channel0Size - realTimetagsSet.channel0Count)
        c_ch0read = c_int(0)
        
        c_sec1 = (c_int * realTimetagsSet.channel1Size)(0)
        c_frac1 = (c_double * realTimetagsSet.channel1Size)(0)
        c_count1 = c_int(realTimetagsSet.channel1Size - realTimetagsSet.channel1Count)
        c_ch1read = c_int(0)

        read = self.lib.readRealTimetags
        read(c_sec0, c_frac0, c_count0, c_ch0read, 
             c_sec1, c_frac1, c_count1, c_ch1read)
       
        idx = realTimetagsSet.channel0Count
        read_tags_n = c_ch0read.value
        for i in range(read_tags_n):
            realTimetagsSet.channel0Sec[idx + i] = c_sec0[i]
            realTimetagsSet.channel0Frac[idx + i] = c_frac0[i]
        realTimetagsSet.channel0Count += read_tags_n

        idx = realTimetagsSet.channel1Count
        read_tags_n = c_ch1read.value
        for i in range(read_tags_n):
            realTimetagsSet.channel1Sec[idx + i] = c_sec1[i]
            realTimetagsSet.channel1Frac[idx + i] = c_frac1[i]
        realTimetagsSet.channel1Count += read_tags_n

    def read_raw(self, rawTimetagsSet, offset):
        """
        This function reads raw time tags data into a user provided buffer. The function will read up-to the
        requested number of words, but will stop sooner if the number of words available is smaller. The data can
        be converted to double precision time tags by calling the L{convert_raw_to_timetags<GT668Driver.convert_raw_to_timetags>} function.
        B{Note}: In "wrap" mode the B{offset} parameter is ignored. Each call to this function will read from the point where the last read ended.
        @type count: unsigned int
        @param count: The number (in 32-bit words) of the raw data words to read
        @type offset: unsigned int
        @param offset: The index (in 32-bit words) of the first raw data word to read. It is ignored in memory "wrap" mode (see note above)
        @rtype:   dict
        @return: Returns L{RawTimetagsSet<GT668Driver.RawTimetagsSet>} object containing following fields:
            - B{I{rawTags}} - unsigned int[], Buffer for raw data (32-bit for each time tag)
            - B{I{tagsRead}} - unsigned int, Number of words actually read
        """
        self.lib.readRawTags.argtypes = [POINTER(c_uint), c_uint, c_uint, POINTER(c_uint)]
        c_buff = (c_uint*rawTimetagsSet.size)(0)
        c_offset = c_uint(offset)
        c_count = c_uint(rawTimetagsSet.size - rawTimetagsSet.count)
        c_read = c_uint(0)

        self.lib.readRawTags(c_buff, c_offset, c_count, c_read)

        idx = rawTimetagsSet.count
        for i, tag in enumerate(c_buff[:c_read.value]):
            rawTimetagsSet.tags[idx + i] = tag
        rawTimetagsSet.count += c_read.value


    def convert_raw_to_timetags(self, buff, tagsAv, readCh0, readCh1):
        """
        This function converts raw time tags data (read using the L{read_raw<GT668Driver.read_raw>} function).
        The function will read up-to the requested number of time tags, but will stop sooner if the number
        of raw time tags available is smaller.
        @type buff: unsigned int[]
        @param buff: Array of raw data.
        @type tagsAv: unsigned int
        @param tagsAv: The number (in 32-bit words) of raw data words available to convert
        @type readCh0: unsigned int
        @param readCh0: The number of time tags from channel 0 to read
        @type readCh1: unsigned int
        @param readCh1: The number of time tags from channel 1 to read
        @rtype:   dict
        @return: Returns dictionary object containing following entries
            - B{I{tagsConv}} - unsigned int, Data words actually converted
            - B{I{ch0tags}} - double[], Array with time tags from channel 0
            - B{I{ch0read}} - int, Number of time tags actually read from channel 0
            - B{I{ch1tags}} - double[], Array with time tags from channel 1
            - B{I{ch1read}} - int, Number of time tags actually read from channel 1
        """
        self.lib.convertRawTags.argtypes = [POINTER(c_uint), c_uint, POINTER(c_uint), POINTER(c_double), c_int, POINTER(c_uint), POINTER(c_double), c_int, POINTER(c_uint)]
        c_buff = (c_uint*tagsAv)(0)
        for i in range(tagsAv):
            c_buff[i] = buff[i]
        c_tagsAv = c_uint(tagsAv)
        c_tagsConv = c_uint(0)

        #channel 0 params
        c_outdch0 = (c_double * readCh0)(0)
        c_toReadCh0 = c_int(readCh0)
        c_readCh0 = c_uint(0)

        #channel 1 params
        c_outdch1 = (c_double * readCh1)(0)
        c_toReadCh1 = c_int(readCh1)
        c_readCh1 = c_uint(0)

        self.lib.convertRawTags(c_buff, c_tagsAv, c_tagsConv,
                                c_outdch0, c_toReadCh0, c_readCh0,
                                c_outdch1, c_toReadCh1, c_readCh1)

        obj = {
            'tagsConv' : c_tagsConv.value,
            'ch0tags'  : c_outdch0,
            'ch0read'  : c_readCh0.value,
            'ch1tags'  : c_outdch1,
            'ch1read'  : c_readCh1.value
        }

        return obj

    def read_sys_time(self):
        """
        This function reads on-board time.
        @rtype:   double
        @return: Returns system time read from tbe board.
        """
        self.lib.readSysTime.restype = ctypes.c_double
        return self.lib.readSysTime()
    ############################################################################################################################
    #### SLR METHODS ###
    ############################################################################################################################
    def get_real_time(self):
        """
        This function retrieves the current real time from the real time clock.
        Note: this function cannot execute while measurements are running - it will return false without setting
        any error code
        @rtype: int
        @return: Retrieved time.
        """
        ret = self.lib.getRealTime()
        return c_int(ret).value

    def set_real_time(self, seconds, sync):
        """
        This function is used to set the real time clock to UTC or any other 32-bit time value in seconds (the time
        fraction will be set to zero). The sync option allows synchronization to a hardware pulse on the ARM
        input - usually a 1PPS signal from the same source as the seconds value.

        @param seconds:
        @param sync:
            - True - synchronize real time clock with next pulse on ARM input.
            - False - start real time clock immediately.
        @rtype: bool
        @return: Returns I{True} if channel is enabled, I{False} otherwise.
        """
        ret = self.lib.setRealTime(seconds, sync)
        return c_bool(ret).value

    def real_time_output(self, out, seconds, frac):
        """
        This function sends to the board a real time value at which to generate an output pulse. The fraction will be converted to the nearest 10 nsec interval.
        Notes:
            - 1. Only future times are valid.
            - 2. Calls should be in advancing time order for each output.
            - 3. If two time values are in the same 10 nsec interval the second one is ignored.
            - 4. Up to 64 time values per output can be pending at any time.
            - 5. The function will fail if the output source is not set to GT_OUT_REALTIME (see function L{set_output<GT668Driver.set_output>}).
        @param out: Output number to select (0 or 1).
        @param seconds: Real time seconds value.
        @param frac: Real time fraction (0 to less than 1).
        @rtype: bool
        @return: Returns I{True} if channel is enabled, I{False} otherwise.
        """
        self.lib.realTimeOutput.argtypes = [c_int, c_uint, c_double]
        c_out = c_int(out)
        c_seconds = c_uint(seconds)
        c_frac = c_double(frac)
        ret = self.lib.realTimeOutput(c_out, c_seconds, c_frac)
        return c_bool(ret).value

    def get_T0_Ex(self):
        """
        This function retrieves the reference time (t0) for the current set of measurements as seconds and fraction,
        allowing usage of real time (epoch) values without loss of resolution.
        @rtype: dict
        @return: Returns dictionary object containing following entries:
            - B{I{sec}} - second part.
            - B{I{frac}} - fraction of a second part.
        """
        self.lib.getT0Ex.argtypes = [POINTER(c_uint), POINTER(c_double)]
        c_sec = c_int(0)
        c_frac = c_double(0)

        self.lib.getT0Ex(c_sec, c_frac)

        obj = {
            'sec'      : c_sec.value,
            'frac'      : c_frac.value
        }

        return obj

    def set_output(self, out, gtiOutSrc, pol, width, delay):
        """
        This function configures one of the outputs to generate pulses.
        @param out: Select output to configure (0 or 1).
        @param gtiOutSrc: Source of the output pulse.
        @param pol: Set output pulse polarity.
        @param width: Set output pulse width.
        @param delay: Set output pulse delay for sources other than real time.
        @rtype: bool
        @return: Returns I{True} if channel is enabled, I{False} otherwise.
        """

        self.lib.setOutput.argtypes = [c_int, c_char_p, c_char_p, c_double, c_double]
        c_out = c_int(out)
        c_gti_out_src = c_char_p(gtiOutSrc)
        c_polarity = c_char_p(pol)
        c_width = c_double(width)
        c_delay = c_double(delay)

        ret = self.lib.setOutput(c_out, c_gti_out_src, c_polarity, c_width, c_delay)

        return c_bool(ret).value

    def set_real_time_start(self, sec, sync):
        """
        This function is used to start setting the real time clock to UTC or any other 32-bit time value in seconds
        (the time fraction will be set to zero). The B{sync} option allows synchronization to a hardware pulse on the
        ARM input – usually a 1PPS signal from the same source as the seconds value. Use the
        I{GT668SetRealTimeIsDone()} function to find when the setting is done, and then call the
        I{GT668SetRealTimeEnd()} function.
        @param sec: The time value in seconds.
        @param sync:    true – synchronize real time clock with next pulse on ARM input.
                        false – start real time clock immediately.
        @rtype: bool
        @return: Returns I{false} if setting failed, I{true} if setting was successful.
        """
        ret = self.lib.setRealTimeStart(sec, sync)
        return c_bool(ret).value

    def set_real_time_is_done(self):
        """
        This function is used to check if the setting the real time clock is finished
        @rtype: bool
        @return: Returns I{false} if setting is not done, I{true} if setting is done.
        """
        ret = self.lib.setRealTimeIsDone()
        return c_bool(ret).value

    def set_real_time_end(self):
        """
        This function is used to end setting the real time clock.
        @rtype: bool
        @return: Returns false if setting failed, true if setting was successful.
        """
        ret = self.lib.setRealTimeEnd()
        return c_bool(ret).value
    
    def clear_error(self):
        """
        This function clears the current error.
        """
        self.lib.clearError()
    
    def get_reference_clock(self):
        """
        This function retrieves the current setting of the reference clock.

        @rtype: dict
        @return: Returns dictionary object containing following entries:
            - B{I{RefClkSrc}} - string, see L{RefClkSrc<GT668.RefClkSrc>}
            - B{I{reference5MHz}} - bool
            - B{I{auxOut}} - bool

        """
        self.lib.getReferenceClock.argtypes = [POINTER(c_char_p), POINTER(c_bool), POINTER(c_bool)]
        c_src = c_char_p(0)
        c_reference5MHz = c_bool(True)
        c_auxOut = c_bool(True)

        self.lib.getReferenceClock(c_src, c_reference5MHz, c_auxOut)
        obj = {
            'refClk': c_src.value,
            'ref5MHz': c_reference5MHz.value,
            'auxOut': c_auxOut.value
        }

        return obj

    def get_memory_wrap_mode(self):
        """
        This function retrieves the current memory “wrap” mode.
        NOTE: USB instrument have no wrap mode. Calling this function will be ignored.

        @rtype: bool
        @return: Returns I{True} if wrap mode is switched on, I{False} otherwise. 
        """
        self.lib.getMemoryWrapMode.argtypes = [POINTER(c_bool)]
        c_wrap = c_bool(True)

        self.lib.getMemoryWrapMode(c_wrap)
        return c_wrap.value

###############################################################################################################################
    def load_config(self, device, config):
        """
        This function loads config to the card.
        @param device: Device number.
        @param config: Dictionary holding configuration data.
        """
        if self.is_initialized(device):
            self.set_arm_aux_out(config['arm_aux_out'])

            self.set_block_arm(config['block_arm']['src'], config['block_arm']['polarity'], config['block_arm']['level'])

            self.set_input_coupling(GT668.Signal.GT_SIG_A, config['channel_a_coupling'])
            self.set_input_coupling(GT668.Signal.GT_SIG_B, config['channel_b_coupling'])
            self.set_input_coupling(GT668.Signal.GT_SIG_ARM, config['arm_coupling'])
            self.set_input_coupling(GT668.Signal.GT_SIG_CLK, config['clk_coupling'])

            self.set_input_impedance(GT668.Signal.GT_SIG_A, config['channel_a_impedance'])
            self.set_input_impedance(GT668.Signal.GT_SIG_B, config['channel_b_impedance'])
            self.set_input_impedance(GT668.Signal.GT_SIG_ARM, config['arm_impedance'])
            self.set_input_impedance(GT668.Signal.GT_SIG_CLK, config['clk_impedance'])

            self.set_input_prescale(GT668.Signal.GT_SIG_A, config['channel_a_prescale'])
            self.set_input_prescale(GT668.Signal.GT_SIG_B, config['channel_b_prescale'])
            self.set_input_prescale(GT668.Signal.GT_SIG_ARM, config['arm_prescale'])
            self.set_input_prescale(GT668.Signal.GT_SIG_CLK, config['clk_prescale'])

            self.set_input_threshold(GT668.Signal.GT_SIG_A, config['channel_a_threshold']['threshMode'], config['channel_a_threshold']['value'])
            self.set_input_threshold(GT668.Signal.GT_SIG_A, config['channel_b_threshold']['threshMode'], config['channel_b_threshold']['value'])

            self.set_reference_clock(config['reference_clock']['refClk'], config['reference_clock']['ref5MHz'], config['reference_clock']['auxOut'])

            self.set_meas_enable(0, config['channel_a_meas_enabled'])
            self.set_meas_enable(1, config['channel_b_meas_enabled'])

            self.set_meas_input(0, config['channel_a_input_sel'])
            self.set_meas_input(1, config['channel_b_input_sel'])

            self.set_meas_skip(0, config['channel_a_skip'] )
            self.set_meas_skip(1, config['channel_b_skip'] )

            self.set_meas_tag_arm(0, config['channel_a_meas_tag_arm']['tagArm'], config['channel_a_meas_tag_arm']['polarity'])
            self.set_meas_tag_arm(1, config['channel_b_meas_tag_arm']['tagArm'], config['channel_b_meas_tag_arm']['polarity'])

            self.set_memory_wrap_mode(config['memory_wrap'])
            self.set_T0_mode(config['t0_mode']['arm'], config['t0_mode']['rel'])

            print("Config loaded.")


    def read_current_config(self, device):
        """
        This function reads current board configuration.
        @rtype: dict
        @param device: Device number.
        @return: Returns dictionary object holding configuration parameters with following entries
            - B{I{arm_aux_out}}
            - B{I{block_arm}}
            - B{I{channel_a_coupling}}
            - B{I{channel_b_coupling}}
            - B{I{clk_coupling}}
            - B{I{arm_coupling}}
            - B{I{channel_a_impedance}}
            - B{I{channel_b_impedance}}
            - B{I{clk_impedance}}
            - B{I{arm_impedance}}
            - B{I{channel_a_prescale}}
            - B{I{channel_b_prescale}}
            - B{I{clk_prescale}}
            - B{I{arm_prescale}}
            - B{I{channel_a_threshold}}
            - B{I{channel_b_threshold}}
            - B{I{reference_clock}}
            - B{I{channel_a_meas_enabled}}
            - B{I{channel_b_meas_enabled}}
            - B{I{channel_a_input_sel}}
            - B{I{channel_b_input_sel}}
            - B{I{channel_a_skip}}
            - B{I{channel_b_skip}}
            - B{I{channel_a_meas_tag_arm}}
            - B{I{channel_b_meas_tag_arm}}
            - B{I{memory_wrap}}
            - B{I{t0_mode}}
        """
        if self.is_initialized(device):
            arm_aux_out = self.get_arm_aux_out()

            block_arm = self.get_block_arm()

            channel_a_coupling = self.get_input_coupling(GT668.Signal.GT_SIG_A)
            channel_b_coupling = self.get_input_coupling(GT668.Signal.GT_SIG_B)
            clk_coupling = self.get_input_coupling(GT668.Signal.GT_SIG_CLK)
            arm_coupling = self.get_input_coupling(GT668.Signal.GT_SIG_ARM)

            channel_a_impedance = self.get_input_impedance(GT668.Signal.GT_SIG_A)
            channel_b_impedance = self.get_input_impedance(GT668.Signal.GT_SIG_B)
            clk_impedance = self.get_input_impedance(GT668.Signal.GT_SIG_CLK)
            arm_impedance = self.get_input_impedance(GT668.Signal.GT_SIG_ARM)

            channel_a_prescale = self.get_input_prescale(GT668.Signal.GT_SIG_A)
            channel_b_prescale = self.get_input_prescale(GT668.Signal.GT_SIG_B)
            clk_prescale = self.get_input_prescale(GT668.Signal.GT_SIG_CLK)
            arm_prescale = self.get_input_prescale(GT668.Signal.GT_SIG_ARM)

            channel_a_threshold = self.get_input_threshold(GT668.Signal.GT_SIG_A)
            channel_b_threshold = self.get_input_threshold(GT668.Signal.GT_SIG_B)

            reference_clock = self.get_reference_clock()

            channel_a_meas_enabled = self.get_meas_enable(0)
            channel_b_meas_enabled = self.get_meas_enable(1)

            channel_a_input_sel = self.get_meas_input(0)
            channel_b_input_sel = self.get_meas_input(1)

            channel_a_skip = self.get_meas_skip(0)
            channel_b_skip = self.get_meas_skip(1)

            channel_a_meas_tag_arm = self.get_meas_tag_arm(0)
            channel_b_meas_tag_arm = self.get_meas_tag_arm(1)

            memory_wrap = self.get_memory_wrap_mode()

            t0_mode = self.get_T0_mode()

            obj = {
                "arm_aux_out" : arm_aux_out,
                "block_arm" : block_arm,
                "channel_a_coupling" : channel_a_coupling,
                "channel_b_coupling" : channel_b_coupling,
                "clk_coupling" : clk_coupling,
                "arm_coupling" : arm_coupling,
                "channel_a_impedance" : channel_a_impedance,
                "channel_b_impedance" : channel_b_impedance,
                "clk_impedance" : clk_impedance,
                "arm_impedance" : arm_impedance,
                "channel_a_prescale" : channel_a_prescale,
                "channel_b_prescale" : channel_b_prescale,
                "clk_prescale" : clk_prescale,
                "arm_prescale" : arm_prescale,
                "channel_a_threshold" : channel_a_threshold,
                "channel_b_threshold" : channel_b_threshold,
                "reference_clock" : reference_clock,
                "channel_a_meas_enabled" : channel_a_meas_enabled,
                "channel_b_meas_enabled" : channel_b_meas_enabled,
                "channel_a_input_sel" : channel_a_input_sel,
                "channel_b_input_sel" : channel_b_input_sel,
                "channel_a_skip" : channel_a_skip,
                "channel_b_skip" : channel_b_skip,
                "channel_a_meas_tag_arm" : channel_a_meas_tag_arm,
                "channel_b_meas_tag_arm" : channel_b_meas_tag_arm,
                "memory_wrap" : memory_wrap,
                "t0_mode" : t0_mode
            }

            return obj
class TimetagsSet:
    """
    Object used to retreive time tags from the L{read_timetags<GT668Driver.read_timetags>} method, contains six fields:
        - B{I{channel0Tags}} - double[], Array with time tags from channel 0
        - B{I{channel0Count}} - int, Number of time tags actually read from channel 0
        - B{I{channel0Size}} - int, expected number of tags for channel 0
        - B{I{channel1Tags}} - double[], Array with time tags from channel 1
        - B{I{channel1Count}} - int, Number of time tags actually read from channel 1
        - B{I{channel1Size}} - int, expected number of tags for channel 1
    """
    def __init__(self, channel0Size=1000, channel1Size=1000):
         self.channel0Size = channel0Size
         self.channel1Size = channel1Size
         self.channel0Count = 0
         self.channel1Count = 0
         self.channel0Tags = [None] * channel0Size
         self.channel1Tags = [None] * channel1Size

    def get_channel_tags_and_count_(self, ch):
        """
        Internal method.
        Used to retreive the time tags array and tags count for a given channel.

        @param ch: channel index (int).
        @rtype: list, int
        @return: List of time tags and their count.
        """
        if ch == 0:
            return self.channel0Tags, self.channel0Count
        elif ch == 1: 
            return self.channel1Tags, self.channel1Count
        else:
            raise Exception('invalid channel index')
    
    def get_tags(self, channel, start=0, end=None, step=1):
        """
        Retrieves tags for a given channel.
        Allows defining a starting index, step, and end index.
        The returned list will be a sublist of the original created based on the parameters.
        When none of the additional parameters (start, end, step) are specified, the 
        method returns the whole list.

        @param channel: channel index number.
        @param start: starting index - index of the first element in the sublist.
        @param end: ending index - index of the last element in the sublist.
        @param step: determines the index step between the tags included in the sublist.
        @rtype: list
        @return: Sublist (or whole list) of the original time tags list.
        """
        ch_tags, ch_count = self.get_channel_tags_and_count_(channel)

        # if no parameters specified, just retun the list
        if start == 0 and end == None and step == 1:
            return ch_tags

        # if end is None, change it so the split array contains all the elements till the end
        if end == None:
            end = ch_count

        return [sample for sample in ch_tags[start:end:step]]

        
class RealTimetagsSet:
    """
    Object used to retreive time tags from the L{read_real_timetags<GT668Driver.read_real_timetags>} method, contains eight fields:
        - B{I{channel0Sec}} - int[], Array with second part of tags from channel 0
        - B{I{channel0Frac}} - double[], Array with frac part of tags from channel 0
        - B{I{channel0Count}} - int, Number of time tags actually read from channel 0
        - B{I{channel0Size}} - int, expected number of tags for channel 0
        - B{I{channel1Sec}} - int[], Array with second part of tags from channel 0
        - B{I{channel1Frac}} - double[], Array with frac part of tags from channel 0
        - B{I{channel1Count}} - int, Number of time tags actually read from channel 0
        - B{I{channel1Size}} - int, expected number of tags for channel 0
    """
    def __init__(self, channel0Size=1000, channel1Size=1000):
         self.channel0Sec = [None] * channel0Size
         self.channel1Sec = [None] * channel1Size
         self.channel0Frac = [None] * channel0Size
         self.channel1Frac = [None] * channel1Size
         
         self.channel0Count = 0
         self.channel1Count = 0

         self.channel0Size = channel0Size
         self.channel1Size = channel1Size

    def get_channel_tags_and_count_(self, ch):
        """
        Internal method.
        Used to retreive the time tags arrays and tags count for a given channel.

        @param ch: channel index (int).
        @rtype: list, list, int
        @return: List of time tags seconds, fraction and their count.
        """
        if ch == 0:
            return self.channel0Sec, self.channel0Frac, self.channel0Count
        elif ch == 1: 
            return self.channel1Sec, self.channel1Frac, self.channel1Count
        else:
            raise Exception('invalid channel index')
    
    def get_tags(self, channel, start=0, end=None, step=1):
        """
        Retrieves tags for a given channel.
        Allows defining a starting index, step, and end index.
        The returned lists will be sublists of the originals created based on the parameters.
        When none of the additional parameters (start, end, step) are specified, the 
        method returns the whole lists.

        @param channel: channel index number.
        @param start: starting index - index of the first element in the sublists.
        @param end: ending index - index of the last element in the sublists.
        @param step: determines the index step between the tags included in the sublists.
        @rtype: list[][]
        @return: A sublist (or whole list), containint two lists: list[0] - seconds list, list[1] - fractions list.
        """
        ch_tags_sec, ch_tags_frac, ch_count = self.get_channel_tags_and_count_(channel)

        # if no parameters specified, just retun the list
        if start == 0 and end == None and step == 1:
            return [ch_tags_sec, ch_tags_frac]

        # if end is None, change it so the split array contains all the elements till the end
        if end == None:
            end = ch_count

        return [
            [sample for sample in ch_tags_sec[start:end:step]],
            [sample for sample in ch_tags_frac[start:end:step]]
        ]

class RawTimetagsSet:
    """
    Object used to retreive time tags from the L{read_raw<GT668Driver.read_raw>} method, contains three fields:
        - B{I{tags}} - int[], Buffer for raw data (32-bit for each time tag)
        - B{I{count}} - int, Number of words actually read
        - B{I{size}} - int, expected number of tags for channel 0
    """
    def __init__(self, size=1000):
        self.size = size
        self.count = 0
        self.tags = [None] * size

    def get_tags(self, start=0, end=None, step=1):
        """
        Retrieves tags.
        Allows defining a starting index, step, and end index.
        The returned lists will be sublists of the originals created based on the parameters.
        When none of the additional parameters (start, end, step) are specified, the 
        method returns the whole lists.

        @param start: starting index - index of the first element in the sublists.
        @param end: ending index - index of the last element in the sublists.
        @param step: determines the index step between the tags included in the sublists.
        @rtype: list
        @return: Sublist (or whole list) of the original time tags list.
        """

        # if no parameters specified, just retun the list
        if start == 0 and end == None and step == 1:
            return self.tags

        # if end is None, change it so the split array contains all the elements till the end
        if end == None:
            end = self.count

        return [sample for sample in self.tags[start:end:step]]

class GT668Utils:
    @staticmethod
    def save_config_to_file(config, path):
        """
        This method saves configuration to JSON file.
        @param config: Configuration object to store.
        @param path: Path under which the file will be stored.
        """
        decodedConfig = GT668Utils.decodeConfig(config)
        with open(path, 'w') as outfile:
            json.dump(decodedConfig, outfile)
    @staticmethod
    def read_config_from_file(path):
        """
        This method reads config from JSON file.
        @param path: Path from which the file should be retrieved.
        @rtype: dict
        @return: Returns dictionary object holding configuration parameters with following entries
            - B{I{arm_aux_out}}
            - B{I{block_arm}}
            - B{I{channel_a_coupling}}
            - B{I{channel_b_coupling}}
            - B{I{clk_coupling}}
            - B{I{arm_coupling}}
            - B{I{channel_a_impedance}}
            - B{I{channel_b_impedance}}
            - B{I{clk_impedance}}
            - B{I{arm_impedance}}
            - B{I{channel_a_prescale}}
            - B{I{channel_b_prescale}}
            - B{I{clk_prescale}}
            - B{I{arm_prescale}}
            - B{I{channel_a_threshold}}
            - B{I{channel_b_threshold}}
            - B{I{reference_clock}}
            - B{I{channel_a_meas_enabled}}
            - B{I{channel_b_meas_enabled}}
            - B{I{channel_a_input_sel}}
            - B{I{channel_b_input_sel}}
            - B{I{channel_a_skip}}
            - B{I{channel_b_skip}}
            - B{I{channel_a_meas_tag_arm}}
            - B{I{channel_b_meas_tag_arm}}
            - B{I{memory_wrap}}
            - B{I{t0_mode}}
        """
        json_data=open(path)
        config = json.load(json_data)
        encodedConfig = GT668Utils.encodeConfig(config)
        return encodedConfig

    """
    This method recursively iterates through an object
    and converts byte literal strings to utf-8 encoded
    Strings.
    """
    @staticmethod
    def decodeConfig(d):
        for k, v in d.items():
            if isinstance(v, dict):
                GT668Utils.decodeConfig(v)
            else:
                try:
                    d[k] = v.decode("utf-8")
                except:
                    pass
        return d

    """
    This method recursively iterates through an object
    and converts utf-8 encoded strings 
    to byte literal strings.
    """
    @staticmethod
    def encodeConfig(d):
        for k, v in d.items():
            if isinstance(v, dict):
                GT668Utils.encodeConfig(v)
            else:
                try:
                    if isinstance(v, str):
                        d[k] = str.encode(v)
                except:
                    pass
        return d

class Var:
    ch_0_tags = "CH_0_TAGS"
    ch_1_tags = "CH_1_TAGS"

class File_Type:
    csv = "csv"
    txt = "txt"

class Cell:
    prefix = ""
    suffix = ""
    var = ""

class Tag:
    def __init__(self, channel, value):
        self.channel = channel
        self.value = value

class Data_Format_Factory:
    file_type = File_Type.csv
    tags_per_file = -1
    delimiter = ','
    empty_tag_representation = "---"
    file_name = "GT668_Tags"
    restart_numbering_in_new_file = False
    include_row_numbering = True
    row = None
    header = None
    store_header_in_each_file = False

class GT668DataUtils:
    @staticmethod
    def save_tags_as_simple_csv(tags, include_header, path, delimiter):
        """
        This method saves tags from both channels to simply formatted CSV file with following line format: tag_number, ch_0_tag, ch_1_tag. E.g. 2,0.123456, 0.7891011.
        Missing tags (in case one of the channels collected more) are represented with '---'. Tags are not time aligned in the file.
        @param tags: dict object containing gathered tags (see L{read_timetags<GT668Driver.read_timetags>}).
        @param include_header: bool Include header flag. True includes header as the first line, False doesn't.
        @param path: Path under which CSV file should be stored.
        @param delimiter: CSV delimiter (e.g. ',' or ';')
        """
        with open(path, 'w', ) as csvfile:
            wr =  csv.writer(csvfile, delimiter=delimiter,
                            quotechar='|', quoting=csv.QUOTE_MINIMAL, lineterminator='\n')
            if include_header == True:
                wr.writerow(['#', 'ch_0_tag', 'ch_1_tag'])

            index = len(tags.channel0Tags) if len(tags.channel0Tags) > len(tags.channel1Tags) else len(tags.channel1Tags)

            for i in range (0, index):
                row = []
                row.append(i)
                if len(tags.channel0Tags) > i:
                    row.append(tags.channel0Tags[i])
                else:
                    row.append('---')

                if len(tags.channel1Tags) > i:
                    row.append(tags.channel1Tags[i])
                else:
                    row.append('---')

                wr.writerow(row)

    @staticmethod
    def save_tags_as_simple_text(tags, include_header, path):
        """
        This method saves tags from both channels to simply formatted plain text file with following line format: tag_number  ch_0_tag  ch_1_tag. E.g. 2 0.123456  0.7891011.
        Missing tags (in case one of the channels collected more) are represented with '---'. Tags are not time aligned in the file.
        @param tags: dict object containing gathered tags (see L{read_timetags<GT668Driver.read_timetags>}).
        @param include_header: bool Include header flag. True includes header as the first line, False doesn't.
        @param path: Path under which text file should be stored.
        """
        file = open(path, "w")

        file_content = None

        if include_header == True:
                file_content = "#\tch_0_tag\tch_1_tag\n"

        index = len(tags.channel0Tags) if len(tags.channel0Tags) > len(tags.channel1Tags) else len(tags.channel1Tags)

        for i in range (0, index):
            file_content += str(i) + "\t"
            if len(tags.channel0Tags) > i:
                file_content += str(tags.channel0Tags[i]) + "\t"
            else:
                file_content += '---' + "\t"

            if len(tags.channel1Tags) > i:
                file_content += str(tags.channel1Tags[i])
            else:
                file_content += '---'

            file_content += '\n'

        file.write(file_content)
        file.close()

    @staticmethod
    def __save_tags_with_formatting(tags, data_format_factory, path, write_index, iteration):
        if data_format_factory.row is not None and len(data_format_factory.row) > 0:
            file_path = ""
            if iteration > 0:
                file_path = path + data_format_factory.file_name + "_" + str(iteration) + "." + data_format_factory.file_type
            else:
                file_path = path + data_format_factory.file_name + "." + data_format_factory.file_type

            #open file
            file = open(file_path, "w")
            file_content = ""

            #get higher array index
            max_tags = len(tags.channel0Tags) if len(tags.channel0Tags) > len(tags.channel1Tags) else len(tags.channel1Tags)
            index = max_tags

            #increment index by write index (multiple files)
            index = max_tags if index + write_index > max_tags else index + write_index

            #include header
            if data_format_factory.header is not None:
                #store header in each file
                if data_format_factory.store_header_in_each_file is True or iteration == 0:
                    file_content += data_format_factory.header + "\n"

            tags_saved = 0;

            restarted_line_numbering = 0;

            #line numbering
            for i in range(write_index, index):
                if data_format_factory.include_row_numbering is True:
                    if data_format_factory.restart_numbering_in_new_file is True:
                        file_content += str(restarted_line_numbering)
                    else:
                        file_content += str(i)

                    file_content += data_format_factory.delimiter
                    restarted_line_numbering += 1

                #tag rows
                for j in range(0, len(data_format_factory.row)):
                    #prefix
                    file_content += data_format_factory.row[j].prefix

                    #channel 0 tags
                    if data_format_factory.row[j].var == Var.ch_0_tags:
                        if len(tags.channel0Tags) > i:
                            file_content += str(tags.channel0Tags[i])
                        else:
                            file_content += data_format_factory.empty_tag_representation
                    #channel 1 tags
                    elif data_format_factory.row[j].var == Var.ch_1_tags:
                        if len(tags.channel1Tags) > i:
                            file_content += str(tags.channel1Tags[i])
                        else:
                            file_content += data_format_factory.empty_tag_representation
                    #suffix
                    file_content += data_format_factory.row[j].suffix

                    #add delimiter
                    if j < len(data_format_factory.row):
                        file_content += data_format_factory.delimiter

                #new line
                file_content += "\n"

                tags_saved += 1

                if tags_saved == data_format_factory.tags_per_file:
                    break

            file.write(file_content)
            file.close()



    @staticmethod
    def save_tags_with_formatting(tags, data_format_factory, path):
        index = len(tags.channel0Tags) if len(tags.channel0Tags) > len(tags.channel1Tags) else len(tags.channel1Tags)

        #store in one file
        if data_format_factory.tags_per_file >= index or data_format_factory.tags_per_file == -1:
            GT668DataUtils.__save_tags_with_formatting(tags, data_format_factory, path, 0, 0)
        else:
            #store in mutiple files
            num_of_file = (index / data_format_factory.tags_per_file) + 1

            for i in range(0, num_of_file):
                GT668DataUtils.__save_tags_with_formatting(tags, data_format_factory, path, i * data_format_factory.tags_per_file, i)

    @staticmethod
    def save_tags_to_time_aligned_two_collumns_CSV(tags, delimiter, ch0representation, ch1representation, path):
        """
        This method saves tags to two row time aligned CSV file. Tags are time sorted, first row contains tag vale, second row contains channel on which tag was captured.
        @param tags: dict object containing gathered tags (see L{read_timetags<GT668Driver.read_timetags>}).
        @param path: Complete path (including file name) under which file should be stored.
        @param delimiter: Delimiter e.g. ','.
        @param ch0representation: String representing channel 0.
        @param ch1representation: String representing channel 1.
        """
        index = tags.channel0Count if tags.channel0Count > tags.channel1Count else tags.channel1Count

        all_tags = []
        for i in range(0, index):
            if tags.channel0Count > i:
                all_tags.append(Tag(Var.ch_0_tags, tags.channel0Tags[i]))

            if tags.channel1Count > i:
                all_tags.append(Tag(Var.ch_1_tags, tags.channel1Tags[i]))

        sorted_tags = sorted(all_tags, key=lambda tag: tag.value)

        tag_line = ""
        channel_line = "\n"

        for i in range(0, len(sorted_tags)):
            tag_line += str(sorted_tags[i].value);
            channel_line += ch0representation if sorted_tags[i].channel == Var.ch_0_tags else ch1representation
            #channelLine.append(tags.get(i).getChannel().equals(Channel.CHANNEL_0) ? ch0representation : ch1representation);

            if i < len(sorted_tags) - 1:
                tag_line += delimiter
                channel_line += delimiter

        file_content = tag_line + channel_line
        file = open(path, "w")
        file.write(file_content)
        file.close()




class GT668:

    """
    Class containing constants for GT668 card configuration.
    """
    ## -----------------------------------------------------------------------------------------------------------------
    ## --- GT668 Constants ---------------------------------------------------------------------------------------------
    ## -----------------------------------------------------------------------------------------------------------------

    #GtiPrescale
    class Prescale:
        GT_DIV_AUTO     = 11
        GT_DIV_1        = 1
        GT_DIV_2        = 2
        GT_DIV_4        = 4
        GT_DIV_8        = 8
        GT_DIV_16       = 16
        GT_DIV_32       = 32
        GT_DIV_64       = 64
        GT_DIV_128      = 128
        GT_DIV_256      = 256
        GT_DIV_512      = 512
        GT_DIV_1024     = 1024

    #GtiArmAuxOut
    class ArmAuxOut:
        GT_AUX_OUT_BA   = b"GT_AUX_OUT_BA"
        GT_AUX_OUT_OFF  = b"GT_AUX_OUT_OFF"
        GT_AUX_OUT_TA0  = b"GT_AUX_OUT_TA0"
        GT_AUX_OUT_TA1  = b"GT_AUX_OUT_TA1"

    #GtiBlkArmSrc
    class BlkArmSrc:
        GT_BA_AUX       = b"GT_BA_AUX"
        GT_BA_CH0       = b"GT_BA_CH0"
        GT_BA_CH1       = b"GT_BA_CH1"
        GT_BA_EXT       = b"GT_BA_EXT"
        GT_BA_IMM       = b"GT_BA_IMM"
        GT_BA_OFF       = b"GT_BA_OFF"
        GT_BA_SW        = b"GT_BA_SW"

    #GtiPolarity
    class Polarity:
        GT_POL_NEG      = b"GT_POL_NEG"
        GT_POL_POS      = b"GT_POL_POS"

    #GtiSignal
    class Signal:
        GT_SIG_A        = b"GT_SIG_A"
        GT_SIG_B        = b"GT_SIG_B"
        GT_SIG_ARM      = b"GT_SIG_ARM"
        GT_SIG_CLK      = b"GT_SIG_CLK"

    #GtiCoupling
    class Coupling:
        GT_CPL_AC       = b"GT_CPL_AC"
        GT_CPL_DC       = b"GT_CPL_DC"

    #GtiImpedance
    class Impedance:
        GT_IMP_HI       = b"GT_IMP_HI"
        GT_IMP_LO       = b"GT_IMP_LO"

    #GtiThrMode
    class ThresholdMode:
        GT_THR_PERCENTS = b"GT_THR_PERCENTS"
        GT_THR_VOLTS    = b"GT_THR_VOLTS"

    #GtiInputSel
    class InputSel:
        GT_CHA_POS      = b"GT_CHA_POS"
        GT_CHA_NEG      = b"GT_CHA_NEG"
        GT_CHB_POS      = b"GT_CHB_POS"
        GT_CHB_NEG      = b"GT_CHB_NEG"
        GT_CLOCK        = b"GT_CLOCK"
        GT_AUX_SIG      = b"GT_AUX_SIG"
        GT_ARM_POS      = b"GT_ARM_POS"
        GT_ARM_NEG      = b"GT_ARM_NEG"

    #GtiTagArmSrc
    class TagArmSrc:
        GT_TA_AUX       = b"GT_TA_AUX"
        GT_TA_CAL       = b"GT_TA_CAL"
        GT_TA_EXT       = b"GT_TA_EXT"
        GT_TA_IMM       = b"GT_TA_IMM"
        GT_TA_OFF       = b"GT_TA_OFF"
        GT_TA_OTHER     = b"GT_TA_OTHER"
        GT_TA_SW        = b"GT_TA_SW"

    #GtiRefClkSrc
    class RefClkSrc:
        GT_REF_AUX      = b"GT_REF_AUX"
        GT_REF_EXTERNAL = b"GT_REF_EXTERNAL"
        GT_REF_INTERNAL = b"GT_REF_INTERNAL"
        GT_REF_PXI      = b"GT_REF_PXI"

    #GtiOutSrc
    class GtiOutSrc:
        GT_OUT_ARM_NEG  = b"GT_OUT_ARM_NEG"
        GT_OUT_ARM_POS  = b"GT_OUT_ARM_POS"
        GT_OUT_BA       = b"GT_OUT_BA"
        GT_OUT_OTHER    = b"GT_OUT_OTHER"
        GT_OUT_REALTIME = b"GT_OUT_REALTIME"
        GT_OUT_START    = b"GT_OUT_START"
        
