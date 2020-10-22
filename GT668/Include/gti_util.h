#ifndef _GTI_UTIL_H                               /* If not already included    */
#define _GTI_UTIL_H                               /* define to avoid multiple   */

#if defined(__cplusplus)
extern "C" {
#endif

#define GTI_ERROR_OPTIONS       -100
#define GTI_ERROR_RANGE         -101

int GTAPI GtiFormatBySignificance(unsigned int opt, int digits, double rslt, char *buf);
int GTAPI GtiFormatByResolution(unsigned int opt, int least_dig, double rslt, char *buf);
int GTAPI GtiFormatConfig(char dec_point, char thous_sep, char frac_sep);
int GTAPI GtiFormatSetEngUnits(char *new_units);

// Options for GtiFormatByxxxx opt parameter

#define GTI_FORMAT_MASK 0x0F
#define GTI_FORMAT_STD  0x00
#define GTI_FORMAT_ENG  0x01
#define GTI_FORMAT_SCI  0x02

#define GTI_FMT_ENG_UNITS 0x100    // Use units (p, n, u, m, K, M, G)

int GTAPI GtiAxisRange(int maxdiv, double margin, double minv, double maxv, double *first, double *last, int *num);

// Find number of significant digits
int GTAPI GtiGetDigitsByResolution(double rslt, int least_dig, int *digits);
int GTAPI GtiGetDigitsBySignificance(int digits_per_sec, double time_interval, int *digits);
double GTAPI GtiReadSysTime(void);

#ifdef __cplusplus
}
#endif

#endif

