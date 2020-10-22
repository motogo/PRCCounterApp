# -*- coding: utf-8 -*-
import json
import csv
from ctypes import *
import ctypes
import platform
from sqlite3.dbapi2 import Time


class GTSYSDriver:
    """
    Class containing GTSYS manipulation methods (initialization, calibration, configuration, measurements etc.).
    """
    ## -----------------------------------------------------------------------------------------------------------------
    ## --- class constructor -------------------------------------------------------------------------------------------
    ## -----------------------------------------------------------------------------------------------------------------
    def __init__(self):
        try:
            self.os = platform.system()
            if self.os == 'Windows':
                self.lib = cdll.LoadLibrary('PyGTSYS.dll')
                print("PyGTSYSLib: Windows lib loaded successfully.")
            elif self.os == 'Linux':
                self.lib = cdll.LoadLibrary('libPyGTSYS.so')
                print("PyGTSYSLib: Linux lib loaded successfully.")

        except Exception as e:
            print(e)

    def get_error(self):
        """
        This function retrieves the last error encountered.
        @rtype:  int
        @return: Returns the error code (0 means no error). Use I{L{get_error_message<GT668Driver.get_error_message>}} to translate it to an error message.
        """
        ret = self.lib.getError()
        return c_int(ret).value

    def clear_error(self):
        """
        This function clears the current error.
        """
        self.lib.clearError()

    def get_error_message(self, error):
        """
        This function translates an error code (returned from L{get_error<GT668Driver.get_error>}) in to an error message.
        @type error: int
        @param error: Error code
        @rtype: string
        @return: The error message
        """
        self.lib.getErrorMessage.argtypes = [c_int, POINTER(c_char_p), c_uint]
        c_message = c_char_p(b"")
        c_error = c_int(int(error))
        c_size = c_uint(512)

        ret = self.lib.getErrorMessage(c_error, c_message, c_size)
        return c_message.value.decode("utf-8")

    def initialize(self, master, comm_port):
        """
        Initialize GTSYS library.
        @type master: int
        @param master: the master site from which arming is received when arm source is I{GTSYS_ARM_SYS}.
        @type comm_port: string
        @param comm_port: the name of the COM port to use (for exampled "COM1" on Windows, or "/dev/ttyS0" on Linux).
        @rtype: bool
        @return: Returns I{False} if initialization failed, I{True} if initialization was successful.
        """
        self.lib.initialize.argtypes = [c_int, c_char_p]
        c_comm_port = c_char_p(comm_port)
        ret = self.lib.initialize(int(master), c_comm_port)
        return c_bool(ret).value

    def close(self):
        """This function closes the GTSYS library."""
        self.lib.close()

    def is_initialized(self):
        """
        This function checks if a board is initialized.
        @rtype:   bool
        @return:  Returns I{True} if initialized, I{False} if not.
        """
        ret = self.lib.isInitialized()
        return c_bool(ret).value

    def get_HWR_Revision(self):
        """
        Reads Time Distribution Board h/w revision.
        @rtype: None / int
        @return: If the reading was successful, the function returns the revision code, else it returns I{None}.
        """
        self.lib.getHWRevision.argtypes = [POINTER(c_uint)]
        c_rev = c_uint(0)
        ret = self.lib.getHWRevision(c_rev)
        if not c_bool(ret).value:
            return None
        else:
            return c_rev.value
    
    def get_HWR_Revision_test(self):
        self.lib.getHWRevision_test.argtypes = [POINTER(c_uint)]
        c_rev = c_uint(0)
        ret = self.lib.getHWRevision_test(c_rev)
        if not c_bool(ret).value:
            return None
        else:
            return c_rev.value

    def get_Fpga_Revision(self):
        """
        Reads Time Distribution Board FPGA revision code.
        @rtype: None / int
        @return: If the reading was successful, the function returns the revision code, else it returns I{None}.
        """
        self.lib.getFpgaRevision.argtypes = [POINTER(c_uint)]
        c_rev = c_uint(0)
        ret = self.lib.getFpgaRevision(c_rev)
        if not c_bool(ret).value:
            return None
        else:
            return c_rev.value

    def set_reference(self, reference):
        """
        Select reference clock option.
        @type  reference: int
        @param reference: see L{GTSysReference<GTSYS.GTSysReference>}
            - L{GTSYS_REF_INT<GTSYS.GTSysReference.GTSYS_REF_INT>} - System internal timebase
            - L{GTSYS_REF_EXT<GTSYS.GTSysReference.GTSYS_REF_EXT>} - System external reference (connector in the back)
            - L{GTSYS_REF_AUTO<GTSYS.GTSysReference.GTSYS_REF_AUTO>} - If 5MHz or 10Mhz signal is detected on the external connector - select external, otherwise - internal
            - L{GTSYS_REF_GPS<GTSYS.GTSysReference.GTSYS_REF_GPS>} - Use the available GPS (the function GTSysGetStatus can tell which, if any, GPS is installed).

        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setReference.argtypes = [c_char_p(0)]
        c_ref = c_char_p(reference)
        ret = self.lib.setReference(c_ref)
        return c_bool(ret).value

    def set_reference_test(self, reference):
        self.lib.setReference_test.argtypes = [c_char_p(0)]
        c_ref = c_char_p(reference)
        ret = self.lib.setReference_test(c_ref)
        return c_bool(ret).value

    def get_reference(self):
        """
        Get current selected reference clock option.
        @rtype: None / int
        @return: If the reading was successful, the function returns the selected reference clock 
            (see L{GTSysReference<GTSYS.GTSysReference>} for valid values), 
            else it returns I{None}.
        """
        self.lib.getReference.argtypes = [POINTER(c_int)]
        c_ref = c_int(0)
        ret = self.lib.getReference(c_ref)
        if not c_bool(ret).value:
            return None
        else:
            return c_int(c_ref).value

    def get_reference_test(self):
        self.lib.getReference_test.argtypes = [POINTER(c_int)]
        c_ref = c_int(0)
        ret = self.lib.getReference_test(c_ref)
        if not c_bool(ret).value:
            return None
        else:
            return c_int(c_ref).value

    def set_arm_source(self, arm_source):
        """
        Select source of arming to be distributed.
        @type  arm_source: int
        @param arm_source: see L{GTSysArmSource<GTSYS.GTSysArmSource>}
            - L{GTSYS_ARM_SYS<GTSYS.GTSysArmSource.GTSYS_ARM_SYS>} - Use Arming from the master site
            - L{GTSYS_ARM_EXT<GTSYS.GTSysArmSource.GTSYS_ARM_EXT>} - Use external arming (connector in the back)
            - L{GTSYS_ARM_1PPS<GTSYS.GTSysArmSource.GTSYS_ARM_1PPS>} - Use 1PPS arming. The 1PPS will come from the GPS - if it's used, or will be generated from whatever reference is used.

        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.
        """
        self.lib.setArmSource.argtypes = [c_char_p(0)]
        c_armSrc = c_char_p(arm_source)
        ret = self.lib.setArmSource(c_armSrc)
        return c_bool(ret).value

    def get_arm_source(self):
        """
        Get current selected source of arming.
        @rtype: None / int
        @return: If the reading was successful, the function returns the selected source of arming 
            (see L{GTSysArmSource<GTSYS.GTSysArmSource>} for valid values), 
            else it returns I{None}.
        """
        self.lig.getArmSource.argtypes = [POINTER(c_int)]
        c_armSrc = c_int(0)
        ret = self.lib.getArmSource(c_armSrc)
        if not c_bool(ret).value:
            return None
        else:
            return c_int(ret).value

    def set_arm_threshold(self, perc, val):
        """
        Set ARM input threshold (ignored if arming selection is not I{GTSYS_ARM_EXT}).
        @type perc: bool
        @param perc: If I{True}, the I{val} is in percents, else the I{val} is in Volts.
        @type val: Double
        @param val: value of the input threshold (interpretation depends on the I{perc} value).
        @rtype:   bool
        @return:  Returns I{False} if setting failed, I{True} if setting was successful.

        B{NOTE}: The external arming signal should be connected and active when this
        function is called with perc equal True (so that the system can measure the
        signal peaks and calculate the threshold voltage)
        """
        self.lib.setArmThreshold.argtypes = [c_bool, c_double]
        c_perc = c_bool(perc)
        c_val = c_double(val)
        ret = self.lib.setArmThreshold(c_perc, c_val)
        return c_bool(ret).value

    def get_arm_threshold(self):
        """
        Get current setting of ARM input threshold.
        @return: If the reading was successful, the function returns an I{Object} with
        {
            'perc' : <Bool>,
            'value': <Double>
        }
        (see L{set_arm_threshold<GTSYSDriver.set_arm_threshold>} for valid values),
        else it returns I{None}.
        """
        self.lib.getArmThreshold.argtypes = [POINTER(c_bool), POINTER(c_double)]
        c_perc = c_bool(0)
        c_val = c_double(0)
        ret = self.lib.getArmThreshold(c_perc, c_val)
        obj = {
            'perc' : c_perc.value,
            'value' : c_val.value
        }
        if not c_bool(ret).value:
            return None
        else:
            return obj

    def get_arm_actual_threshold(self):
        """
        Get actual ARM input threshold voltage.
        When GTSysSetArmThreshold is called with perc equal GT_True this function
        can be used to find what voltage was used.
        @rtype: None / double
        @return: If the reading was successful, and the I{set_arm_threshold} function was called with I{perc} = I{True},
        the function returns voltage used,
        else it returns I{None}.
        """
        self.lib.getArmActualThreshold.argtypes = [POINTER(c_double)]
        c_val = c_double(0)
        ret = self.lib.getArmActualThreshold(c_val)
        if not c_bool(ret).value:
            return None
        else:
            return c_val.value

    def get_status(self):
        """
        Read status and GPS module type.
        @rtype: object
        @return: An object with I{stat} and I{gps} parameters corresponding to the
        L{GTSysStatus<GTSYS.GTSysStatus>} and L{GTSysGPSType<GTSYS.GTSysGPSType>} values.
        """
        self.lib.getStatus.argtypes = [POINTER(c_int), POINTER(c_int)]
        c_stat = c_int(0)
        c_gps = c_int(0)
        ret = self.lib.getStatus(c_stat, c_gps)
        obj = {
            'stat': c_stat.value,
            'gps': c_gps.value,
        }
        if not c_bool(ret).value:
            return None
        else:
            return obj

    def get_status_test(self):
        self.lib.getStatus_test.argtypes = [POINTER(c_int), POINTER(c_int)]
        c_stat = c_int(0)
        c_gps = c_int(0)
        self.lib.getStatus_test(c_stat, c_gps)
        obj = {
            'stat': c_stat.value,
            'gps': c_gps.value,
        }
        if not c_bool(ret).value:
            return None
        else:
            return obj

    def get_GPS_real_time(self):
        """
        Get UTC real time from GPS. This is the time at the last 1PPS.
        @rtype: int
        @return: If the reading was successful, the function returns UTC real time,
        else it returns I{None}.
        """
        self.lib.getGPSRealTime.argtypes = [POINTER(c_uint)]
        c_time = c_uint(0)
        ret = self.lib.getGPSRealTime(c_time)
        if not c_bool(ret).value:
            return None
        else:
            return c_time.value

    def get_cal_time(self):
        """
        Get UTC time of the last calibration.
        @rtype: int
        @return: UTC time of the last calibration
        """
        ret = self.lib.getCalTime()
        return c_uint(ret).value

class GTSYS:
    """
    Class containing constants for GTSYS configuration.
    """
    ## -----------------------------------------------------------------------------------------------------------------
    ## --- GTSYS Constants ---------------------------------------------------------------------------------------------
    ## -----------------------------------------------------------------------------------------------------------------
    class GTSysReference:
        """
        Options for selecting system reference on the Time Distribution board
        the reference will be distributed to all GT668 boards in the system
        (though the setup of the board can ignore it and use the board's
        external or internal reference).
        """
        GTSYS_REF_INT   = 0		## System internal timebase
        GTSYS_REF_EXT   = 1		## System external reference (connector in the back)
        GTSYS_REF_AUTO  = 2		## If 5MHz or 10Mhz signal is detected on the external connector - select external, otherwise - internal
        GTSYS_REF_GPS   = 3		## Use the available GPS (the function GTSysGetStatus can tell which, if any, GPS is installed).
    
    class GTSysArmSource:
        """
        Options for selecting the system arming on the Time Distribution board
        the arming will be distributed to all GT668 boards in the system
        (though the setup of the board can ignore it ans use the board's
        external or internal reference).
        B{NOTE}: The I{GTSYS_ARM_SYS} option will select the local arming of the master
        site which is sent to the Time Distribution Board and from there it
        is distributed to all sites.
        """
        GTSYS_ARM_SYS   = 0     ## Use Arming from the master site
        GTSYS_ARM_EXT   = 1     ## Use external arming (connector in the back)
        GTSYS_ARM_1PPS  = 2     ## Use 1PPS arming. The 1PPS will come from the GPS - if it's used, or will be generated from whatever reference is used.

    class GTSysStatus:
        """
        Time Distribution Board status bits
        """
        GTSYS_NONE          = 0	    ## No status bits set
        GTSYS_REF_CHANGED   = 1	    ## Signal on the external reference connector changed
        GTSYS_REF_FOUND     = 2	    ## Signal of 5MHz or 10MHz is available on external reference connector
        GTSYS_REF_5MHz      = 4	    ## Signal on external reference connector is 5MHz.
        GTSYS_GPS_LOCKED    = 8	    ## GPS signal locked and timebase is locked to 10MHz from it.

    class GTSysGPSType:
        """
        Installed GPS module
        """
        GTSYS_GPS_NONE      = 0		## No GPS installed.
        GTSYS_GPS_LTE_LITE  = 1		## GPS is LTE-Lite from Jackson Labs
        GTSYS_GPS_LC_1X1    = 2		## GPS is LC_1x1 from Jackson Labs
        GTSYS_GPS_LN_RUB    = 3	    ## GPS is Low Noise Rubidium from Jackson Labs
    