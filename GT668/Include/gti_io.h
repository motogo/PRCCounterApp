#ifndef _GTI_IO_H                               /* If not already included    */
#define _GTI_IO_H                               /* define to avoid multiple   */

#if !defined (__KERNEL__)
#include <stdio.h>
#include <stdlib.h>
#ifdef LINUX
#include <unistd.h>
#if !defined (__KERNEL__)
#include <string.h>
#endif
#else
#include <windows.h>
#endif
#endif

#if defined(__cplusplus)
extern "C" {
#endif

typedef unsigned char UINT8;
typedef signed char INT8;
typedef unsigned short UINT16;
typedef signed short INT16;

#ifndef WD_VER
typedef unsigned int UINT32;
typedef int INT32;
typedef unsigned long long UINT64;
typedef long long INT64;
#endif

#ifdef LINUX
typedef unsigned long ULONG32;
typedef long LONG32;

#if !defined (__KERNEL__)
#define DWORD UINT32
#define WORD UINT16
#define BYTE UINT8
#define BOOL int
#endif
#endif

#ifdef LINUX
#define Sleep(a) usleep((a) * 1000)
#define _snprintf snprintf
#endif

#ifdef LINUX
#define GTAPI
#else
#if !defined (__KERNEL__)
#define GTAPI __stdcall
#else
#define GTAPI
#endif
#endif

#if !defined(TRUE)
#define TRUE 1
#endif

#if !defined(FALSE)
#define FALSE 0
#endif

#define MAX_DEV_NUM		(32)

typedef enum __gti_bool_tag
{
	GT_False,
	GT_True
} GT_Bool;

#ifndef GTAPI
#define   GTAPI          __stdcall
#endif

void GTAPI GtiNoKernel(void);
int GTAPI GtiBoardType(int dev);
int GTAPI GtiBoardRev(int dev);
UINT64 GTAPI GtiBoardOptions(int dev);
int GTAPI GtiEnumerateBoards(int first);
void GTAPI GtiClose(int board);
void GTAPI GtiCloseAll(void);
int GTAPI GtiOpen(int board);
int GTAPI GtiReadInfo(void *info, unsigned int info_size);
int GTAPI GtiReadCal(void *cal, unsigned int cal_size);
int GTAPI GtiWriteCal(void *cal, unsigned int cal_size);
void GTAPI GtiLoadMemory(int wrap_mode);
void GTAPI GtiFreeMemory(void);
int GTAPI GtiInitializeMemory(DWORD dwBlocks, DWORD dwBlkSize);
int GTAPI GtiReadMemory(void *Buf, unsigned int offset, unsigned int ToRead, unsigned int *ActRead);
int GTAPI GtiNumBoards(void);
int GTAPI GtiSelect(int board);
UINT32 GTAPI GtiGetMemorySize(void);
int GTAPI GtiBlockOutp(UINT16 uAddr, UINT8 ucData[], int iCount);
int GTAPI GtiBlockInp(UINT16 uAddr, UINT8 ucData[], int iCount);
int GTAPI GtiBlockOutpw(UINT16 uAddr, UINT16 usData[], int iCount);
int GTAPI GtiBlockInpw(UINT16 uAddr, UINT16 usData[], int iCount);
int GTAPI GtiInp(UINT16 uAddr);
UINT16 GTAPI GtiInpw(UINT16 uAddr);
UINT32 GTAPI GtiInp32(UINT16 uAddr);
UINT64 GTAPI GtiInp64(UINT16 uAddr);
int GTAPI GtiOutp(UINT16 uAddr, int iData);
int GTAPI GtiOutpw(UINT16 uAddr, UINT16 uData);
int GTAPI GtiOutp32(UINT16 uAddr, UINT32 udata);
int GTAPI GtiOutp64(UINT16 uAddr, UINT64 uData);

int GtiBoardNumber(int dev);
int GtiDeviceNumber(int board, int dev);

void GtiOutpSPI(unsigned int addr, unsigned int data);
unsigned char GtiInpPLL(unsigned int reg);
void GtiOutpPLL(unsigned int reg, unsigned char data);
void GtiOutpDAC(unsigned char chan, unsigned short data);
int GTAPI GtiReadFlash(unsigned int addr, unsigned char *buf, int len);

int GTAPI GtiGetPointers(DWORD *pCnt, DWORD *pBuf, DWORD NumBufs);

#ifdef __cplusplus
}
#endif

#endif

