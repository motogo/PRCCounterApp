#ifndef _GTTDB_H                               /* If not already included    */
#define _GTTDB_H                               /* define to avoid multiple   */

#include "gti_io.h"

#define GTSYS_ERR_NO_ERROR      (0)
#define GTSYS_ERR_NOT_FOUND		(1001)
#define GTSYS_ERR_INVALID_PARAM (1002)
#define GTSYS_ERR_INTERNAL      (1003)
#define GTSYS_ERR_AT_FAILED     (1004)
#define GTSYS_ERR_TB_TUNE       (1005)
#define GTSYS_ERR_NO_GPS        (1006)

// Options for selecting system reference on the Time Distribution board
// the refernce will be distributed to all GT668 boards in the system
// (though the setup of the board can ignore it ans use the board's
// external or internal reference).
typedef enum __gt_sys_reference_tag
{
	GTSYS_REF_INT,		// System internal timebase
	GTSYS_REF_EXT,		// System external reference (connector in the back)
	GTSYS_REF_AUTO,		// If 5MHz or 10Mhz signal is detected on the external connector - select external, otherwise - internal
	GTSYS_REF_GPS,		// Use the available GPS (the function GTSysGetStatus can tell which, if any, GPS is installed).
} GTSysReference; 

// Options for selecting the system arming on the Time Distribution board
// the arming will be distributed to all GT668 boards in the system
// (though the setup of the board can ignore it ans use the board's
// external or internal reference).
// NOTE: The GTSYS_ARM_SYS option will select the local arming of the master
// site which is sent to the Time Distribution Board and from there it
// is distributed to all sites.
typedef enum __gt_sys_arm_source_tag
{
	GTSYS_ARM_SYS,		// Use Arming from the master site
	GTSYS_ARM_EXT,		// Use external arming (connector in the back)
	GTSYS_ARM_1PPS		// Use 1PPS arming. The 1PPS will come from the GPS - if it's used, or will be generated from whatever reference is used.
} GTSysArmSource;

// Time Distribution Board status bits
typedef enum __gt_sys_status_tag
{
	GTSYS_NONE = 0,			// No status bits set
	GTSYS_REF_CHANGED = 1,	// Signal on the external reference connector changed
	GTSYS_REF_FOUND = 2,	// Signal of 5MHz or 10MHz is available on external reference connector
	GTSYS_REF_5MHz = 4,		// Signal on external reference connector is 5MHz.
	GTSYS_GPS_LOCKED = 8	// GPS signal locked and timebase is locked to 10MHz from it.
} GTSysStatus;

// Installed GPS module
typedef enum __gt_sys_gps_type_tag
{
	GTSYS_GPS_NONE = 0,		// No GPS installed.
	GTSYS_GPS_LTE_LITE,		// GPS is LTE-Lite from Jackson Labs
	GTSYS_GPS_LC_1X1,		// GPS is LC_1x1 from Jackson Labs
	GTSYS_GPS_LN_RUB		// GPS is GRClok-1500 Rubidium from Spectratime
} GTSysGPSType;

// Get code of last error from GTSYS library
int GTAPI GTSysGetError(void);

// Clear last error
void GTAPI GTSysClearError(void);

// Translate error code to text message
int GTAPI GTSysGetErrorMessage(int err, char *buf, unsigned int buf_size);

// Initialize GTSYS library.
// master is the master site from which arming is received when arm source is GTSYS_ARM_SYS
// comm_port is the name of the COM port to use (for exampled "COM1" on Windows, or "/dev/ttyS0" on Linux).
GT_Bool GTAPI GTSysInitialize(int master, const char *comm_port);

GT_Bool GTAPI GTSysInitializeEx(GT_Bool keep, int master, const char *comm_port);

// Close GTSYS library
void GTAPI GTSysClose(void);

// Check if library is initialized
GT_Bool GTAPI GTSysIsInitialized(void);

// Read Time Distribution Board h/w revision
GT_Bool GTAPI GTSysGetHWRevision(unsigned int *rev);

// Read Time Distribution Board FPGA revision code
GT_Bool GTAPI GTSysGetFpgaRevision(unsigned int *rev);

// Read Time Distribution Board serial number
GT_Bool GTAPI GTSysGetSerialNumber(unsigned int *sn);

// Select reference clock option
// see definition of GTSysReference for valid values
GT_Bool GTAPI GTSysSetReference(GTSysReference ref);

// Get current selected reference clock option
// see definition of GTSysReference for valid values
GT_Bool GTAPI GTSysGetReference(GTSysReference *ref);

// Select source of arming to be distributed
// see definition of GTSysArmSource for valid values
GT_Bool GTAPI GTSysSetArmSource(GTSysArmSource src);

// Get current selected source of arming
// see definition of GTSysArmSource for valid values
GT_Bool GTAPI GTSysGetArmSource(GTSysArmSource *src);

// Set ARM input threshold (ignored if arming selection is not GTSYS_ARM_EXT)
// If perc is GT_True val is in percents.
// If perc is GT_False val is in Volts.
// NOTE: The external arming signal should be connected and active when this
// function is called with perc equal GT_True (so that the system can measure the
// signal peaks and calculate the threshold voltage)
GT_Bool GTAPI GTSysSetArmThreshold(GT_Bool perc, double val);

// Get current setting of ARM input threshold
// see GTSysSetArmThreshold for arguments meaning
GT_Bool GTAPI GTSysGetArmThreshold(GT_Bool *perc, double *val);

// Get actual ARM input threshold voltage
// When GTSysSetArmThreshold is called with perc equal GT_True this function
// can be used to find what voltage was used
GT_Bool GTAPI GTSysGetArmActualThreshold(double *val);

// Read status and GPS module type
// see definitions of GTSysStatus and GTSysGPSType
GT_Bool GTAPI GTSysGetStatus(GTSysStatus *stat, GTSysGPSType *gps);

// Get UTC real time from GPS. This is the time at the last 1PPS>
GT_Bool GTAPI GTSysGetGPSRealTime(unsigned int *time);

// Get UTC time of the last calibration
unsigned int GTAPI GTSysGetCalTime(void);

#endif

