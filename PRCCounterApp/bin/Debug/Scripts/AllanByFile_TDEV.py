import numpy
import json
import codecs

import matplotlib.pyplot as plt
 
import allantools as at
import sys

import os
from datetime import datetime

from operator import itemgetter
import collections
import math

 
# this demonstrates how to calculate confidence intervals
# using the algorithms from Greenhall2004



# python AllanByFile_TDEV.py  temppath=D:\\Temp\\ datafile=d:\\temp\\results2.dat logfile=D:\\temp\\log\\AllanFB_TDEV4.log debug=True xscaletype=log10 maxtau=100000 errorbars=True phasetype=phase samplingrate=1.0 xscaletype=log10

filter      = 'none'
starttime    = '0'
endtime      = '0'
timetype    = 'sec'
colsplit    = ','
rowsplit    = ';'
headerfile = ''
phasetype  = 'phase'
errorbars  = 'True'
scriptname = 'AllanByFile_TDEV'
maxtau = '1000'
samplingrate = '1.0'
xscaletype = 'log10'
logfile = scriptname + '.log'
temppath = 'D:\\temp'
datafile = scriptname + '.dat'
debg='True'
stattype =['TDEV,0','ADEV,1']  # statype und graphcolorindex

measname = 'Meas'

def dateandtime():
    now = datetime.now()
    dt_string = now.strftime("%d/%m/%Y %H:%M:%S.%f")[:-3]
    return dt_string

print(dateandtime()+'->Defaults->Set Start Time:'+starttime)
print(dateandtime()+'->Defaults->Set End Time:'+endtime)
print(dateandtime()+'->Defaults->Set Timetype:'+timetype)
print(dateandtime()+'->Defaults->Set Logfile:'+logfile)
print(dateandtime()+'->Defaults->Set Temppath:'+temppath)
print(dateandtime()+'->Defaults->Set Datafiles:'+datafile)
print(dateandtime()+'->Defaults->Set Debugmode:'+debg)
print(dateandtime()+'->Defaults->Set Timetype:'+timetype)
print(dateandtime()+'->Defaults->Set Colsplit:'+colsplit)
print(dateandtime()+'->Defaults->Set Rowsplit:'+rowsplit)
print(dateandtime()+'->Defaults->Set Headerfile:'+headerfile)
print(dateandtime()+'->Defaults->Set Errorbars:'+errorbars)
print(dateandtime()+'->Defaults->Set Phasetype:'+phasetype)
print(dateandtime()+'->Defaults->Set Max TAU:'+maxtau)
print(dateandtime()+'->Defaults->Set Samplingrate:'+samplingrate)
print(dateandtime()+'->Defaults->Set X-Scaletype:'+xscaletype)
#print(dateandtime()+'->Defaults->Set Stattype:'+stattype)
print(' ')
print(dateandtime()+'->Given COMMAND LINE Parameters for Script:'+scriptname)
for line in sys.argv:
    if(line.endswith(';')): line = line[0:-1]
    linearr = line.split("=")
    if(len(linearr) > 1):
        if(linearr[0].startswith('starttime')):
            starttime = linearr[1]
            print(dateandtime()+'->Arguments->Set Start Time:'+starttime)
        if(linearr[0].startswith('endtime')):
            endtime = linearr[1]
            print(dateandtime()+'->Arguments->Set End Time:'+endtime)
        if(linearr[0].startswith('logfile')):
            logfile = linearr[1]
            print(dateandtime()+'->Arguments->Set Logfile:'+logfile)
        if(linearr[0].startswith('temp')):
            temppath = linearr[1]
            print(dateandtime()+'->Arguments->Set Temppath:'+temppath)
        if(linearr[0].startswith('datafile')):
            datafile = linearr[1]
            print(dateandtime()+'->Arguments->Set Datafiles:'+datafile)
        if(linearr[0].startswith('debug')):
            debg = linearr[1]
            print(dateandtime()+'->Arguments->Set Debugmode:'+debg)
        if(linearr[0].startswith('timetype')):
            timetype = linearr[1]
            print(dateandtime()+'->Arguments->Set Timetype:'+timetype)
        if(linearr[0].startswith('colsplit')):
            colsplit = linearr[1]
            print(dateandtime()+'->Arguments->Set Colsplit:'+colsplit)
        if(linearr[0].startswith('rowsplit')):
            rowsplit = linearr[1]
            print(dateandtime()+'->Arguments->Set Rowsplit:'+rowsplit)
        if(linearr[0].startswith('headerfile')):
            headerfile = linearr[1]
            print(dateandtime()+'->Arguments->Set Headerfile:'+headerfile)
        if(linearr[0].lower().startswith('samplingrate')):
            samplingrate = linearr[1]
            print(dateandtime()+'->Arguments->Samplingrate:'+samplingrate)
        if(linearr[0].lower().startswith('maxtau')):
            maxtau = linearr[1]
            print(dateandtime()+'->Arguments->Max TAU:'+maxtau)
        if(linearr[0].lower().startswith('phasetype')):
            phasetype = linearr[1]
            print(dateandtime()+'->Arguments->Phasetype:'+phasetype)
        if(linearr[0].lower().startswith('errorbars')):
            errorbars = linearr[1]
            print(dateandtime()+'->Arguments->Errorbars:'+errorbars)
        if(linearr[0].lower().startswith('xscaletype')):
            xscaletype = linearr[1]
            print(dateandtime()+'->Arguments->X-Scaletype:'+xscaletype)
        if(linearr[0].lower().startswith('stattype')):
            st = linearr[1].split(';')
            stattype.clear()
            for stt in st:
                stattype.append(stt);
                print(dateandtime()+'->Arguments->Add stattype:' +stt)



phase = []



def collectGraph(filter,starttime,endtime,phase,temppath,plt,n,scale,errorbars,phasetype,samplingrate,stattype,graphlegend):
    print(dateandtime()+'->doing collectGraph')
    #print('DeviceName:'+filter)
    #print('Start MJD:'+starttime)
    #print('End MJD:'+endtime)
    #print('Datafile loaded:'+datafile)
    print(dateandtime()+'->Phaselength:'+str(len(phase)))
    #print('phasetype:'+phasetype)
    npoints = len(phase)

    #sys.exit()
   
    # normal TDEV computation, giving naive 1/sqrt(N) errors
    adevtype = stattype
    print(dateandtime()+'->Doing:'+adevtype)
    #(taus,devs,errs,ns) = at.tdev(phase, taus=scale, data_type=phasetype)
   

    if(adevtype == 'TDEV'):
        (taus,devs,errs,ns) = at.tdev(phase, taus=scale, data_type=phasetype)
    elif(adevtype == 'MDEV'):
        (taus,devs,errs,ns) = at.mdev(phase, taus=scale, data_type=phasetype)
    elif(adevtype == 'OADEV'):        
        (taus,devs,errs,ns) = at.oadev(phase, taus=scale, data_type=phasetype)
    elif(adevtype == 'ADEV'): 
        (taus,devs,errs,ns) = at.adev(phase, taus=scale, data_type=phasetype)
    else:
        print('No Statistiktype given (ADEV,TDV,OADEV,MDEV)')
        sys.exit(0)
    print(dateandtime()+'->Done:'+adevtype)


    print(dateandtime()+'->n:',n)
    mark = '.'
    col = 'red'
    colmark = 'r.'
    # [ '-' | '--' | '-.' | ':' | 'steps' | ...]
    linesty = '-'
    if int(n) == 0:
        col = 'red'
        mark = '.'
        colmark = 'r.'
    elif int(n) == 1:
        col = 'blue'
        mark = '*'
        colmark = 'b.'
    elif int(n) == 2:
        col = 'green'
        mark = 'x'
        colmark = 'g.'
    elif int(n) == 3:
        col = 'cyan'
        mark = '+'
        colmark = 'c.'
    elif int(n) == 4:
        col = 'black'
        mark = '+'
        colmark = 'b.'
    
    #pltlabel = filter+', n='+str(npoints)
    pltlabel = graphlegend
    print(dateandtime()+'Set->pltlabel:',pltlabel)
    print(dateandtime()+'Set->colmark:',colmark)
    print(dateandtime()+'Set->col:',col)
    print(dateandtime()+'Set->mark:',mark)

    if(errorbars):
        # Confidence-intervals for each (tau,adev) pair separately.
        cis=[]
        for (t,dev) in zip(taus,devs):
            # Greenhalls EDF (Equivalent Degrees of Freedom)
            # alpha     +2,...,-4   noise type, either estimated or known
            # d         1 first-difference variance, 2 allan variance, 3 hadamard variance
            #           we require: alpha+2*d >1     (is this ever false?)
            # m         tau/tau0 averaging factor
            # N         number of phase observations
            edf = at.edf_greenhall( alpha=0, d=2, m=t, N=len(phase), overlapping = True, modified=True )
            # with the known EDF we get CIs 
            # for 1-sigma confidence we set
            # ci = scipy.special.erf(1/math.sqrt(2)) = 0.68268949213708585
            (lo,hi) = at.confidence_interval( dev=dev, ci=0.68268949213708585, edf=edf )
            cis.append( (lo,hi) )
 
        # now we are ready to print and plot the results
        print (dateandtime()+"->    Tau\tmin Dev\t\tDev\t\tMax Dev")
        taus2=[]
        devs2=[]
        cis2=[]
        for (tau,dev,ci) in zip(taus,devs,cis):
            if(float(tau) <= float(maxtau)):
                print (dateandtime()+'->use:',float(tau),dev,ci)
                cis2.append(ci)
                taus2.append(tau)
                devs2.append(dev)
            else:
                print (dateandtime()+'->not use:',float(tau),dev,ci)
            #print ("%d \t %f \t %f \t %f") % (tau, ci[0], dev, ci[1] )
        print(dateandtime()+'->plot with errorbars')
        print(dateandtime()+'->colmark:',colmark)
        print(dateandtime()+'->col:',col)
        print(dateandtime()+'->mark:',mark)
        err_lo = [ d-ci[0] for (d,ci) in zip(devs2,cis2)]
        err_hi = [ ci[1]-d for (d,ci) in zip(devs2,cis2)]
        plt.errorbar(taus2, devs2,color=col, yerr=[ err_lo, err_hi ] ,linestyle=linesty,fmt='-o', label = pltlabel)
    else:
        print(dateandtime()+'->plot without errorbars')
        print(dateandtime()+'->colmark:',colmark)
        print(dateandtime()+'->col:',col)
        print(dateandtime()+'->mark:',mark)
        plt.plot(taus, devs,color=col, marker='o', linestyle=linesty,label = pltlabel)

    plt.xlabel('Tau (s)')    
    plt.ylabel('σ(Tau)')
    
    # just to check plot the intervals as dots also
    # plt.plot(taus, [ci[0] for ci in cis],colmark)
    # plt.plot(taus, [ci[1] for ci in cis],colmark)
    fn = logfile
    file = open(fn,'w')  
    file.write('end')  
    file.close()  


scale = 'octave'
scalen = 2
if(xscaletype == 'log10'):
    scale = 'decade'
    scalen = 10
elif(xscaletype == 'all'):
    scale = 'all'
    scalen = 1
plt.figure(figsize=(12,8))
plt.grid()
plt.gca().set_xscale('log',basex=scalen)
plt.gca().set_yscale('log',basey=scalen)

n = -1
dfiles = datafile.split(",")

for dfile in dfiles:
    gshow = False
    print('Datafile to load:'+dfile)
    for filelineno, line in enumerate(open(dfile, encoding="utf-8")):
        line = line.strip()
        if(line.startswith('#starttime:')):
            starttime = line[10:]
            print(dateandtime()+'->Defaults->Start Time:'+starttime)
        elif(line.startswith('#endtime:')):
            endtime = line[8:]
            print(dateandtime()+'->Defaults->End Time:'+endtime)
        elif(line.startswith('#end')):
            n = n+1
            print(dateandtime()+'->call collectGraph #end')
            print(n)
            gshow=True
            collectGraph(filter,starttime,endtime,phase,temppath,plt,n,scale,errorbars,phasetype,samplingrate,stattype)
            phase.clear()
        elif(line.startswith('#measname:')):
            phase.clear()
            filter = line[10:]
            print(dateandtime()+'->Defaults->Measname:'+filter)
        elif (line[:1] in '+-0123456789'):
            xexist = False
            xval=0.0
            if(colsplit in line):
                vals = line.split(colsplit)
                xval = vals[0]
                yval = vals[1]
                xexist = True
            else:
                yval = line
            if(rowsplit in yval):
                yvals = yval.split(rowsplit)
                val = yvals[0]
            else: 
                val=yval

            if((xexist) and (float(starttime) != float(endtime))):
                if((float(xval) <= float(endtime)) and (float(xval) >= float(starttime))):
                    phase.append(float(val))
            else:
                phase.append(float(val))
            
    print(len(phase))
    if((len(phase) > 0)and(not gshow)):
        n = n+1
        print(dateandtime()+'->call collectGraph')
        print(n)
        #inx = 0
        for nstr in stattype:
            strarr = nstr.split(',')
            ng = strarr[1]
            stype = strarr[0]
            gl = stype
            print(ng)
            print(stype)
            #inx=inx+1
            collectGraph(filter,starttime,endtime,phase,temppath,plt,ng,scale,errorbars,phasetype,samplingrate,stype,gl)
        
        phase.clear()

dt = 'Statistics for '+ measname + '('
for nstr in stattype:
    strarr = nstr.split(',')
    stype = strarr[0]
    dt = dt + stype + ','
print(starttime)
print(endtime)
if(float(starttime) == float(endtime)):
    dt = dt[0:-1] + ")"
else:
    dt = dt[0:-1] + "):%s - %s" % (starttime,endtime)

plt.title(dt)
legend = plt.legend(loc='best', shadow=True, fontsize='medium')
#plt.savefig('D:\\temp\\test.png');

plt.show()

