using BasicClassLibrary;
using Enums;
using GT668Library;
using GuideTech;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRCCounterApp
{
    public class MeasurementClass
    {
        private System.ComponentModel.BackgroundWorker measWorker;
        private MeasurementConfigClass mcc;
        string InfoLine = "LOG";
        string ErrorLine = "ERROR_LOG";
        string DataLine = "DATA";
        string DataAttributesLine = "DATA_ATTRIBUTES";
        string ControlLine = "CONTROL";
        string STARTMEAS = "START_MEAS";
        string STOPMEAS = "STOP_MEAS";

        public ResultDatas rd = null;
        public NotifiesClass nf = new NotifiesClass();

        public MeasurementClass(MeasurementConfigClass measConfig, bool worker)
        {
            mcc = measConfig;
            
            nf = new NotifiesClass();
            nf.Register4Info(InfoRaised);
            nf.Register4Error(ErrorRaised);
            if (worker)
            {
                measWorker = new System.ComponentModel.BackgroundWorker();
                this.measWorker.WorkerReportsProgress = true;
                this.measWorker.WorkerSupportsCancellation = true;
                this.measWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.measWorker_DoWork);
                this.measWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.measWorker_ProgressChanged);
                this.measWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.measWorker_RunWorkerCompleted);
            }
        }
        void ErrorRaised(object sender, MessageEventArgs k)
        {

        }

        

        void InfoRaised(object sender, MessageEventArgs k)
        {
            if (k.Key.ToString() == DataLine)
            {
                if (k.Data != null)
                {
                    var dt = (ResultDataClass)k.Data;
                    rd.Results = dt;
                    rd.WriteData();
                }
            }
            else if (k.Key.ToString() == DataAttributesLine)
            {
                rd.WriteAttributeData(k.Meldung);
            }     
        }

        public void Run()
        {
            Info(0, false, ControlLine, STARTMEAS);
            measWorker.RunWorkerAsync();
        }
        public void RunDirect()
        {
            var ob = new GT900USBClass();
            ob.measConfig = mcc;
            bool ok = false;

            if (ob.measConfig.measType == eMeasType.pps_a_b)
            {
                ok = WorkerPrepareInstrumentPPS_A_B(ob,false);
            }
            else if (ob.measConfig.measType == eMeasType.freq_a)
            {
                ok = WorkerPrepareInstrumentFEQUENCY_A(ob,false);
            }
            if (ok)
            {
                Thread.Sleep(200);
                StartingMeasurement(ob, false);
                Thread.Sleep(200);
                WorkerRunMeasurement(ob, false);
            }
        }

        public void Stop()
        {
            nf.AddToINFO($@"Closing Measurment.");
            Application.DoEvents();
            measWorker.CancelAsync();

            while (measWorker.CancellationPending)
            {
                nf.AddToINFO($@"Cancellation pending...", InfoLine);
                Thread.Sleep(1000);
                measWorker.Dispose();
                Application.DoEvents();
            }
            nf.AddToINFO($@"Measurment is closed.", InfoLine);
            WorkerEndOutput();
            Application.DoEvents();
        }

        bool isBusy(bool worker)
        {
            if (!worker) return true;
            return (measWorker.IsBusy) && (!measWorker.CancellationPending);
        }

        void WorkerRunMeasurement(GT900USBClass ob, bool worker)
        {
            if (ob == null) return;
            Error(0, worker, $@"Test ErrorLog");
            uint ActNumTags0 = 0;
            uint ActNumTags1 = 0;

            double start_time = ob.ReadSysTime();
            int cmd_cnt = 0;
            Info(++cmd_cnt, worker, InfoLine, $@"StartTime:{start_time}");

            int akt = 0;
            ob.Run = true;
            Thread.Sleep(ob.measConfig.sleepAfterSingleMeasurement);

            while ((akt < ob.measConfig.loops || ob.measConfig.loops <= 0) && isBusy(worker) && (ob.Run))
            {
                double time = ob.ReadSysTime() - start_time;
                if (ob.measConfig.showAllErrors)
                {
                    int er = ob.GetError();
                    if (er > 0)
                    {
                        Info(++cmd_cnt, worker, InfoLine, $@"ERROR->ReadSysTime->{akt}->Time:{time}->Error:{er}");
                    }
                }

                if (akt > ob.measConfig.loops && ob.measConfig.loops > 0) break;
                int readCnt = 0;

                var r1 = new GT668Class.GtiRealTime[2];
                var r2 = new GT668Class.GtiRealTime[2];
                double result = double.MinValue;
                double resulttime = 0;
                if (ob.measConfig.measType == eMeasType.freq_a)
                {
                    ActNumTags0 = 0U;
                    ActNumTags1 = 0U;
                    while ((ActNumTags0 != ob.measConfig.numTag0) &&(ob.Run) && isBusy(worker))
                    {
                        ob.ReadTimetagsEx(ref r1[0], ob.measConfig.numTag0, ref ActNumTags0, ref r2[0], ob.measConfig.numTag1, ref ActNumTags1);
                        int errRead = ob.GetError();
                        Thread.Sleep(ob.measConfig.sleepAfterSingleRead);
                        if(errRead > 0)
                        {
                            Error(++cmd_cnt, worker, $@"ERROR->{ob.GetErrorMessage(errRead)}->StopMeasurement");
                            ob.StopMeasurements();
                            ob.ClearError();
                            Thread.Sleep(50);
                            Error(++cmd_cnt, worker,  $@"RestartMeasurement");
                            ob.StartMeasurements();
                            Error(++cmd_cnt, worker,  $@"Measurement Restarted");
                            readCnt = 0;
                        }
                        readCnt++;
                    }

                    if (ob.Run)
                    {
                        resulttime = ob.ReadSysTime();
                        result = (Math.Abs(10000.0 / ((r1[1].Seconds + r1[1].Fraction) - (r1[0].Seconds + r1[0].Fraction)))) + ob.measConfig.userDefinedYOffset;
                    }
                }
                else if(ob.measConfig.measType == eMeasType.freq_a_b)
                {
                    ActNumTags0 = 0;
                    ActNumTags1 = 0;
                    readCnt = 0;
                    double tm = 0.0;
                    while (((ActNumTags0 <= 0) || (ActNumTags1 <= 0)) && ob.Run && isBusy(worker))
                    {
                        ob.ReadTimetagsEx(ref r1[0], ob.measConfig.numTag0, ref ActNumTags0, ref r2[0], ob.measConfig.numTag1, ref ActNumTags1);
                        Thread.Sleep(ob.measConfig.sleepAfterSingleRead);
                        int errRead = ob.GetError();
                        //tm = ob.ReadSysTime() - start_time;
                        if (errRead > 0)
                        {
                            Error(++cmd_cnt, worker, $@"{tm}: ERROR->{ob.GetErrorMessage(errRead)}->StopMeasurement");
                            ob.StopMeasurements();
                            ob.ClearError();
                            Thread.Sleep(50);
                            Error(++cmd_cnt, worker, $@"{tm}: RestartMeasurement");
                            ob.StartMeasurements();
                            tm = ob.ReadSysTime() - start_time;
                            Error(++cmd_cnt, worker, $@"{tm}: Measurement Restarted");
                            readCnt = 0;
                        }
                        
                        readCnt++;
                    }
                    if (ob.Run)
                    {
                        tm = ob.ReadSysTime() - start_time;
                        resulttime = Math.Round(tm,6);
                        result = (r1[0].Fraction - r2[0].Fraction) + ob.measConfig.userDefinedYOffset;
                    }
                }
                else if (ob.measConfig.measType == eMeasType.pps_a_b)
                {
                    ActNumTags0 = 0;
                    ActNumTags1 = 0;
                    readCnt = 0;
                    while (((ActNumTags0 <= 0) || (ActNumTags1 <= 0) || (resulttime <= 0)) && ob.Run && isBusy(worker))
                    {
                        ob.ReadTimetagsEx(ref r1[0], ob.measConfig.numTag0, ref ActNumTags0, ref r2[0], ob.measConfig.numTag1, ref ActNumTags1);
                        Thread.Sleep(ob.measConfig.sleepAfterSingleRead);
                        int errRead = ob.GetError();

                        if (errRead > 0)
                        {
                            Error(++cmd_cnt, worker, $@"ERROR->{ob.GetErrorMessage(errRead)}->StopMeasurement");
                            ob.StopMeasurements();
                            ob.ClearError();
                            Thread.Sleep(50);
                            Error(++cmd_cnt, worker, $@"RestartMeasurement");
                            ob.StartMeasurements();
                            Error(++cmd_cnt, worker, $@"Measurement Restarted");
                            readCnt = 0;
                        }

                        readCnt++;

                        if (ob.Run)
                        {
                            resulttime = r1[0].Seconds;
                        }
                    }
                    if (ob.Run)
                    {
                        result = (r1[0].Fraction - r2[0].Fraction) + ob.measConfig.userDefinedYOffset;
                    }
                }

                int err = ob.GetError();
                if (err > 0)
                {
                    Info(++cmd_cnt, worker, InfoLine, $@"ERROR->{akt}->Time:{time}->CountTags:{ob.measConfig.numTag0},ReadTags:{ActNumTags0}->Error:{err}");
                    ob.ClearError();
                }

                time = ob.ReadSysTime() - start_time;
                if (ob.measConfig.showAllErrors)
                {
                    err = ob.GetError();
                    if (err > 0)
                    {
                        Info(++cmd_cnt, worker, InfoLine, $@"ERROR->ReadSysTime->{akt}->Time:{time}->Error:{err}");
                    }
                }

                if ((result > double.MinValue) && (ob.Run))
                {
                    if(ActNumTags0 > 1)
                    {
                        Console.WriteLine();
                    }
                    if (ob.measConfig.showResults)
                    {
                        var rd = new ResultDataClass();
                        rd.ID = Guid.NewGuid();
                        rd.STAMP = DateTime.Now;
                        
                        if (ob.measConfig.measType == eMeasType.pps_a_b)
                        {
                            rd.VALUE = result;
                            rd.DATASTAMP = resulttime;
                            Info(++cmd_cnt,worker, DataLine, $@"    Tag({readCnt}): tag0->{ActNumTags0},tag1->{ActNumTags1}->{rd.DATASTAMP}={rd.VALUE}", rd);
                        }
                        else if (ob.measConfig.measType == eMeasType.freq_a_b)
                        {
                            rd.VALUE = result;
                            rd.DATASTAMP = resulttime;
                            Info(++cmd_cnt, worker, DataLine, $@"    Tag({readCnt}): tag0->{ActNumTags0},tag1->{ActNumTags1}->{rd.DATASTAMP}={rd.VALUE}", rd);
                        }
                        else if (ob.measConfig.measType == eMeasType.freq_a)
                        {
                            rd.VALUE = result;
                            rd.DATASTAMP = resulttime;
                            Info(++cmd_cnt, worker, DataLine, $@"    Tag({readCnt}): tag0->{ActNumTags0},tag1->{ActNumTags1}->{rd.DATASTAMP}={rd.VALUE}", rd);
                            Thread.Sleep(200);
                        }
                    }
                    else
                    {
                        err = ob.GetError();
                        Info(++cmd_cnt, worker, InfoLine, $@"{akt}->Time:{time}->CountTags:{ob.measConfig.numTag0},ReadTags:{ActNumTags0},{ActNumTags1}->Error:{err}");
                    }

                    if (ob.measConfig.restartMeasurementAfterLoop && ob.Run)
                    {
                        ob.StopMeasurements();
                        Info(++cmd_cnt, worker, InfoLine, $@"Measurement stopped");
                        ob.StartMeasurements();
                        Info(++cmd_cnt, worker, InfoLine, $@"Measurement started");
                    }
                    if(ob.Run) ob.Sleep();
                    akt++;
                    Application.DoEvents();
                }
            }
            Info(++cmd_cnt, worker, InfoLine, $@"Measurement loop stopped.");
            ob.Run = false;
            ob.CloseMeasurement();
            Cancel(worker);
        }

        public void Cancel(bool worker)
        {
            if (!worker) return;
            if ((measWorker.IsBusy) && (!measWorker.CancellationPending)) measWorker.CancelAsync();
        }

        void Info(int cnt,bool worker, string key, string info, ResultDataClass data=null)
        {
            if (worker)
            {
                measWorker.ReportProgress(cnt, new ReportDataClass(key, info, data));
            }
            else
            {
                if ((key == InfoLine)||(key == ControlLine))
                {
                    nf.AddToINFO(info, key);
                }
                else if ((key == DataLine)&&(data != null))
                {
                    nf.AddToINFO(info, key, data);
                }
            }
        }
        void Error(int cnt, bool worker, string info)
        {
            if (worker)
            {
                measWorker.ReportProgress(cnt, new ReportDataClass(ErrorLine, info));
            }
            else
            {
                nf.AddToERROR(info, ErrorLine);
            }
        }


        public bool TestFreq(int board, int Frequency, int ch, GT900USBClass ob)
        {
            double[] numArray = new double[2];
            bool flag = true;
           
            ob.Select(board);
            GT668Class.GtiBlkArmSrc src = GT668Class.GtiBlkArmSrc.GT_BA_OFF;
            GT668Class.GtiPolarity pol = GT668Class.GtiPolarity.GT_POL_POS;
            bool level = false;
            ob.GetBlockArm(ref src, ref pol, ref level);
            GT668Class.GtiArmAuxOut aux_out = GT668Class.GtiArmAuxOut.GT_AUX_OUT_OFF;
            ob.GetArmAuxOut(ref aux_out);
            GT668Class.GtiPrescale presc = GT668Class.GtiPrescale.GT_DIV_AUTO;
            ob.GetInputPrescale(GT668Class.GtiSignal.GT_SIG_A, ref presc);
            int ch1 = ch;
            int num1 = 0;
            uint num2 = checked((uint)num1);
            ref uint local1 = ref num2;
            ob.GetMeasSkip(ch1, ref local1);
            int num3 = checked((int)num2);
            double num4;
            if (Frequency == 1)
            {
                ob.SetInputPrescale(GT668Class.GtiSignal.GT_SIG_A, GT668Class.GtiPrescale.GT_DIV_1);
                ob.SetMeasSkip(ch, 0U);
                num4 = 1.0;
            }
            else
            {
                ob.SetInputPrescale(GT668Class.GtiSignal.GT_SIG_A, GT668Class.GtiPrescale.GT_DIV_4);
                ob.SetMeasSkip(ch, 2499U);
                num4 = 10000.0;
            }
            ob.SetBlockArm(GT668Class.GtiBlkArmSrc.GT_BA_IMM, GT668Class.GtiPolarity.GT_POL_POS, false);
            ob.SetArmAuxOut(GT668Class.GtiArmAuxOut.GT_AUX_OUT_OFF);
            ob.StartMeasurements();
            uint num5 = 0;
            uint num6 = 2;
            double num7 = ob.ReadSysTime();
            do
            {
                uint num8 = 0;
                double num9 = 0.0;
                uint num10 = 0;
                if (ch == 0)
                {
                    ref double local2 = ref numArray[checked((int)num5)];
                    int num11 = (int)checked(num6 - num5);
                    ref uint local3 = ref num8;
                    num9 = 0.0;
                    ref double local4 = ref num9;
                    num10 = 0U;
                    ref uint local5 = ref num10;
                    ob.ReadTimetags(ref local2, (uint)num11, ref local3, ref local4, 0U, ref local5);
                }
                else
                {
                    num9 = 0.0;
                    ref double local2 = ref num9;
                    num10 = 0U;
                    ref uint local3 = ref num10;
                    ref double local4 = ref numArray[checked((int)num5)];
                    int num11 = (int)checked(num6 - num5);
                    ref uint local5 = ref num8;
                    ob.ReadTimetags(ref local2, 0U, ref local3, ref local4, (uint)num11, ref local5);
                }
                checked { num5 += num8; }
            }
            while (ob.ReadSysTime() - num7 <= 0.05 && (int)num5 != (int)num6);
            ob.StopMeasurements();
            if (num5 == 2U)
            {
                double num8 = num4 / (numArray[1] - numArray[0]);
                if (Frequency == 1)
                    flag = false;
                else if (Math.Abs(num8 - 10000000.0) / 10000000.0 > 1E-05)
                    flag = false;
            }
            else if (Frequency != 1)
                flag = false;
            ob.SetInputPrescale(GT668Class.GtiSignal.GT_SIG_A, presc);
            ob.SetMeasSkip(ch, checked((uint)num3));
            ob.SetBlockArm(src, pol, level);
            ob.SetArmAuxOut(aux_out);
            return flag;
        }


        public bool TestSignals(GT900USBClass ob, int Frequency)
        {
            string Left = "";
            int nBoards = 1;
            double num1 = ob.ReadSysTime();
            int num2 = checked(nBoards - 1);
            int index = 0;
            while (index <= num2)
            {
                int ch = 0;
                do
                {
                    if (!TestFreq(index, Frequency, ch,ob))
                    {
                        Left = Left + "->Slot {index} Ch {ch}";
                    }
                    checked { ++ch; }
                }
                while (ch <= 1);
                checked { ++index; }
            }
            double num3 = ob.ReadSysTime() - num1;
            if (!string.IsNullOrEmpty(Left)) return true;

            MessageBox.Show("Error",$@"Signals on the following inputs do not match the configured frequency:{Environment.NewLine}{Left}",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            return false;
        }

        bool WorkerPrepareInstrumentFREQUENCY_A_B(GT900USBClass ob, bool worker)
        {
            int cmd_cnt = 0;
            MeasurementConfigClass mcc = ob.measConfig;

            //Info(++cmd_cnt, worker, InfoLine, $@"Allocating API..."));
            Info(++cmd_cnt, worker, InfoLine, $@"Allocating API {ob.GetDriverVersion()}...");
            Thread.Sleep(1000);

            Info(++cmd_cnt, worker, InfoLine, $@"Initializing the instruments board {mcc.board} and sets to current...");
            //Info(++cmd_cnt, worker, InfoLine, $@"Initializing the instruments board {mcc.board} and sets to current..."));
            bool ok = ob.Initialize(mcc.board);

            Info(++cmd_cnt, worker, InfoLine, $@"Initializing -- >{ok} Error:{ob.GetError()}");

            ob.Select(mcc.board);
            string bm = ob.GetBoardModel();
            Info(++cmd_cnt, worker, InfoLine, $@"Version:{bm}");


            Info(++cmd_cnt, worker, InfoLine, $@"Initializing the current board {mcc.board} to default and sets the reference to internal clock.");
            ob.InitDefault(false);
            Info(++cmd_cnt, worker, InfoLine, $@"Default Initializing -- >{ok} Error:{ob.GetError()}");

            if (mcc.doCalibration)
            {
                Info(++cmd_cnt, worker, InfoLine, $@"Calibrating...");
                ok = ob.SelfCal();
                Info(++cmd_cnt, worker, InfoLine, $@"Calibrating --> {ok} Error:{ob.GetError()}");
                ob.ClearError();
            }

            if (mcc.enableChannel0)
            {
                ob.SetMeasEnable(0, true);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set MeasEnable{Environment.NewLine} --> {ok} Error:{ob.GetError()}");
            }
            else
            {
                ob.SetMeasEnable(0, false);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set not MeasEnable{Environment.NewLine} --> {ok} Error:{ob.GetError()}");
            }

            if (mcc.enableChannel1)
            {
                Info(++cmd_cnt, worker, InfoLine, $@" Channel {1} set MeasEnable");
                ob.SetMeasEnable(1, true);
            }
            else
            {
                Info(++cmd_cnt, worker, InfoLine, $@" Channel {1} set not MeasEnable");
                ob.SetMeasEnable(1, false);
            }
            Info(++cmd_cnt, worker, InfoLine, $@" --> {ok} err:{ob.GetError()}");

            ok = ob.SetMeasInput(0, mcc.inputChannel0Signal);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set Meas Input to {EnumHelper.GetDescription(mcc.inputChannel1Signal)} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetMeasInput(1, mcc.inputChannel1Signal);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel {1} set Meas Input to {EnumHelper.GetDescription(mcc.inputChannel1Signal)} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetMeasSkip(0, mcc.measSkipChannel0);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set Meas Skip to {mcc.measSkipChannel0} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetMeasSkip(1, mcc.measSkipChannel1);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel {1} set Meas Skip to {mcc.measSkipChannel1} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputThreshold(GT668Class.GtiSignal.GT_SIG_A, mcc.inputThresholdModeA, mcc.inputThresholdA);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel threshold Input A set to {mcc.clockThreshold} [{EnumHelper.GetDescription(mcc.inputThresholdModeA)}] --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputThreshold(GT668Class.GtiSignal.GT_SIG_B, mcc.inputThresholdModeB, mcc.inputThresholdB);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel threshold Input B set to {mcc.inputThresholdB} [{EnumHelper.GetDescription(mcc.inputThresholdModeB)}] --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputThreshold(GT668Class.GtiSignal.GT_SIG_CLK, mcc.inputThresholdModeB, mcc.clockThreshold);
            Info(++cmd_cnt, worker, InfoLine, $@"Clock threshold set to {mcc.clockThreshold} [{EnumHelper.GetDescription(mcc.clockThresholdMode)}] --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputCoupling(GT668Class.GtiSignal.GT_SIG_A, mcc.inputCouplingA);
            Info(++cmd_cnt, worker, InfoLine, $@"Set Input Coupling Input A to {EnumHelper.GetDescription(mcc.inputCouplingA)} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputCoupling(GT668Class.GtiSignal.GT_SIG_B, mcc.inputCouplingB);
            Info(++cmd_cnt, worker, InfoLine, $@"Set Input Coupling Input B to {EnumHelper.GetDescription(mcc.inputCouplingB)} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputImpendance(GT668Class.GtiSignal.GT_SIG_A, mcc.inputImpendanceA);
            Info(++cmd_cnt, worker, InfoLine, $@"Set impedance Input A to {EnumHelper.GetDescription(mcc.inputImpendanceA)} termination --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputImpendance(GT668Class.GtiSignal.GT_SIG_B, mcc.inputImpendanceB);
            Info(++cmd_cnt, worker, InfoLine, $@"Set impedance Input B to {EnumHelper.GetDescription(mcc.inputImpendanceB)} termination --> {ok} Error:{ob.GetError()}");


            ok = ob.SetInputPrescale(GT668Class.GtiSignal.GT_SIG_A, mcc.prescaleA);

            Info(++cmd_cnt, worker, InfoLine, $@"Set InputPrescale Input A to {EnumHelper.GetDescription(mcc.prescaleA)} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputPrescale(GT668Class.GtiSignal.GT_SIG_B, mcc.prescaleB);

            Info(++cmd_cnt, worker, InfoLine, $@"Set InputPrescale Input B to {EnumHelper.GetDescription(mcc.prescaleB)} --> {ok} Error:{ob.GetError()}");

            ob.SetBlockArm(GT668Class.GtiBlkArmSrc.GT_BA_IMM, GT668Class.GtiPolarity.GT_POL_POS, false);
            ob.SetArmAuxOut(GT668Class.GtiArmAuxOut.GT_AUX_OUT_OFF);

            if (mcc.memoryWrap)
            {
                ok = ob.SetMemoryWrapMode(true);
                Info(++cmd_cnt, worker, InfoLine, $@"Set MemoryWrapMode to TRUE --> {ok} Error:{ob.GetError()}");
            }
            else
            {
                ok = ob.SetMemoryWrapMode(false);
                Info(++cmd_cnt, worker, InfoLine, $@"Set MemoryWrapMode to FALSE --> {ok} Error:{ob.GetError()}");
            }

            ob.SetT0Mode(false, true);



            ok = ob.SetMeasGate(0, mcc.measGateChannel0);
            Info(++cmd_cnt, worker, InfoLine, $@"Set MeasGate ch0 to {mcc.measGateChannel0} --> {ok} Error:{ob.GetError()}");
            ok = ob.SetMeasGate(1, mcc.measGateChannel1);
            Info(++cmd_cnt, worker, InfoLine, $@"Set MeasGate ch1 to {mcc.measGateChannel1} --> {ok} Error:{ob.GetError()}");

            //    GT668Def.GT668GetTotalPrescale(0, ref presc1);
            //    GT668Def.GT668GetTotalPrescale(1, ref presc2);

            return ok;
        }

        bool StartingMeasurement(GT900USBClass ob, bool worker)
        {
            Info(1, worker, InfoLine, $@"Waiting for measurements");
            bool ok = ob.StartMeasurements();                    /* reset measurement memory   */
            Info(2, worker, InfoLine, $@"Measurement started --> {ok}");

            Info(0, worker, DataAttributesLine, $@"#startdate:{DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss")}");
            Info(0, worker, DataAttributesLine, $@"#measoffset:{ob.measConfig.userDefinedYOffset}");
            Info(0, worker, DataAttributesLine, $@"#titel:{ob.measConfig.measName}");
            Info(0, worker, DataAttributesLine, $@"#xtitel:{ob.measConfig.XLegendName}");
            Info(0, worker, DataAttributesLine, $@"#ytitel:{ob.measConfig.YLegendName}");
            Info(0, worker, DataAttributesLine, $@"#yscale:{ob.measConfig.ScaleYAxis}");
            Info(0, worker, DataAttributesLine, $@"#legend:{ob.measConfig.GraphLegendName}");
            Info(0, worker, DataAttributesLine, $@"#color:blue");
            Info(0, worker, DataAttributesLine, $@"#marker:0");
            Info(0, worker, DataAttributesLine, $@"#subplot:0");
            Info(0, worker, DataAttributesLine, $@"#colsplit:,");
            Info(0, worker, DataAttributesLine, $@"#rowsplit:;");
            Info(0, worker, DataAttributesLine, $@"#measname:{ob.measConfig.measName}");

            return ok;
        }

        bool WorkerPrepareInstrumentPPS_A_B(GT900USBClass ob, bool worker)
        {
            int cmd_cnt = 0;
            MeasurementConfigClass mcc = ob.measConfig;

            //Info(++cmd_cnt, worker, InfoLine, $@"Allocating API..."));
            Info(++cmd_cnt,worker,InfoLine, $@"Allocating API {ob.GetDriverVersion()}...");
            Thread.Sleep(1000);

            Info(++cmd_cnt, worker, InfoLine, $@"Initializing the instruments board {mcc.board} and sets to current...");
            //Info(++cmd_cnt, worker, InfoLine, $@"Initializing the instruments board {mcc.board} and sets to current..."));
            bool ok = ob.Initialize(mcc.board);

            Info(++cmd_cnt, worker, InfoLine, $@"Initializing -- >{ok} Error:{ob.GetError()}");

            ob.Select(mcc.board);
            string bm = ob.GetBoardModel();
            Info(++cmd_cnt, worker, InfoLine, $@"Version:{bm}");


            Info(++cmd_cnt, worker, InfoLine, $@"Initializing the current board {mcc.board} to default and sets the reference to internal clock.");
            ob.InitDefault(false);
            Info(++cmd_cnt, worker, InfoLine, $@"Default Initializing -- >{ok} Error:{ob.GetError()}");

            if (mcc.doCalibration)
            {
                Info(++cmd_cnt, worker, InfoLine, $@"Calibrating...");
                ok = ob.SelfCal();
                Info(++cmd_cnt, worker, InfoLine, $@"Calibrating --> {ok} Error:{ob.GetError()}");
                ob.ClearError();
            }

            if (mcc.enableChannel0)
            {
                ob.SetMeasEnable(0, true);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set MeasEnable{Environment.NewLine} --> {ok} Error:{ob.GetError()}");
            }
            else
            {
                ob.SetMeasEnable(0, false);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set not MeasEnable{Environment.NewLine} --> {ok} Error:{ob.GetError()}");
            }

            if (mcc.enableChannel1)
            {
                Info(++cmd_cnt, worker, InfoLine, $@" Channel {1} set MeasEnable");
                ob.SetMeasEnable(1, true);
            }
            else
            {
                Info(++cmd_cnt, worker, InfoLine, $@" Channel {1} set not MeasEnable");
                ob.SetMeasEnable(1, false);
            }
            Info(++cmd_cnt, worker, InfoLine, $@" --> {ok} err:{ob.GetError()}");

            ok = ob.SetMeasInput(0, mcc.inputChannel0Signal);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set Meas Input to {EnumHelper.GetDescription(mcc.inputChannel1Signal)} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetMeasInput(1, mcc.inputChannel1Signal);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel {1} set Meas Input to {EnumHelper.GetDescription(mcc.inputChannel1Signal)} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetMeasSkip(0, mcc.measSkipChannel0);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set Meas Skip to {mcc.measSkipChannel0} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetMeasSkip(1, mcc.measSkipChannel1);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel {1} set Meas Skip to {mcc.measSkipChannel1} --> {ok} Error:{ob.GetError()}");
            

            ok = ob.SetInputThreshold(GT668Class.GtiSignal.GT_SIG_A, mcc.inputThresholdModeA, mcc.inputThresholdA);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel threshold Input A set to {mcc.clockThreshold} [{EnumHelper.GetDescription(mcc.inputThresholdModeA)}] --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputThreshold(GT668Class.GtiSignal.GT_SIG_B, mcc.inputThresholdModeB, mcc.inputThresholdB);
            Info(++cmd_cnt, worker, InfoLine, $@"Channel threshold Input B set to {mcc.inputThresholdB} [{EnumHelper.GetDescription(mcc.inputThresholdModeB)}] --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputThreshold(GT668Class.GtiSignal.GT_SIG_CLK, mcc.inputThresholdModeB, mcc.clockThreshold);
            Info(++cmd_cnt, worker, InfoLine, $@"Clock threshold set to {mcc.clockThreshold} [{EnumHelper.GetDescription(mcc.clockThresholdMode)}] --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputCoupling(GT668Class.GtiSignal.GT_SIG_A, mcc.inputCouplingA);
            Info(++cmd_cnt, worker, InfoLine, $@"Set Input Coupling Input A to {EnumHelper.GetDescription(mcc.inputCouplingA)} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputCoupling(GT668Class.GtiSignal.GT_SIG_B, mcc.inputCouplingB);
            Info(++cmd_cnt, worker, InfoLine, $@"Set Input Coupling Input B to {EnumHelper.GetDescription(mcc.inputCouplingB)} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputImpendance(GT668Class.GtiSignal.GT_SIG_A, mcc.inputImpendanceA);
            Info(++cmd_cnt, worker, InfoLine, $@"Set impedance Input A to {EnumHelper.GetDescription(mcc.inputImpendanceA)} termination --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputImpendance(GT668Class.GtiSignal.GT_SIG_B, mcc.inputImpendanceB);
            Info(++cmd_cnt, worker, InfoLine, $@"Set impedance Input B to {EnumHelper.GetDescription(mcc.inputImpendanceB)} termination --> {ok} Error:{ob.GetError()}");


            ok = ob.SetInputPrescale(GT668Class.GtiSignal.GT_SIG_A, mcc.prescaleA);
            
            Info(++cmd_cnt, worker, InfoLine, $@"Set InputPrescale Input A to {EnumHelper.GetDescription(mcc.prescaleA)} --> {ok} Error:{ob.GetError()}");

            ok = ob.SetInputPrescale(GT668Class.GtiSignal.GT_SIG_B, mcc.prescaleB);
            
            Info(++cmd_cnt, worker, InfoLine, $@"Set InputPrescale Input B to {EnumHelper.GetDescription(mcc.prescaleB)} --> {ok} Error:{ob.GetError()}");

            if (mcc.memoryWrap)
            {
                ok = ob.SetMemoryWrapMode(true);
                Info(++cmd_cnt, worker, InfoLine, $@"Set MemoryWrapMode to TRUE --> {ok} Error:{ob.GetError()}");
            }
            else
            {
                ok = ob.SetMemoryWrapMode(false);
                Info(++cmd_cnt, worker, InfoLine, $@"Set MemoryWrapMode to FALSE --> {ok} Error:{ob.GetError()}");
            }

            ok = ob.SetMeasGate(0, mcc.measGateChannel0);
            Info(++cmd_cnt, worker, InfoLine, $@"Set MeasGate ch0 to {mcc.measGateChannel0} --> {ok} Error:{ob.GetError()}");
            ok = ob.SetMeasGate(1, mcc.measGateChannel1);
            Info(++cmd_cnt, worker, InfoLine, $@"Set MeasGate ch1 to {mcc.measGateChannel1} --> {ok} Error:{ob.GetError()}");

        //    GT668Def.GT668GetTotalPrescale(0, ref presc1);
        //    GT668Def.GT668GetTotalPrescale(1, ref presc2);

            return ok;
        }

        bool WorkerPrepareInstrumentFEQUENCY_A(GT900USBClass ob,bool worker)
        {
            int cmd_cnt = 0;
            MeasurementConfigClass mcc = ob.measConfig;

            Info(++cmd_cnt, worker, InfoLine, $@"Allocating API {ob.GetDriverVersion()}...");
            Thread.Sleep(1000);

            Info(++cmd_cnt, worker, InfoLine, $@"Initializing the instruments board {mcc.board} and sets to current...");
            bool ok = ob.Initialize(mcc.board);

            ob.Select(mcc.board);
            string bm = ob.GetBoardModel();
            Info(++cmd_cnt, worker, InfoLine, $@"Version:{bm}");


            Info(++cmd_cnt, worker, InfoLine, $@"Initializing -- >{ok} Error:{ob.GetError()}");

            Info(++cmd_cnt, worker, InfoLine, $@"Initializing the current board {mcc.board} to default and sets the reference to internal clock.");
            ob.InitDefault(false);
            Info(++cmd_cnt, worker, InfoLine, $@"Default Initializing -- >{ok} Error:{ob.GetError()}");

            if (mcc.doCalibration)
            {
                Info(++cmd_cnt, worker, InfoLine, $@"Calibrating...");
                ok = ob.SelfCal();
                Info(++cmd_cnt, worker, InfoLine, $@"Calibrating --> {ok} err:{ob.GetError()}");
                ob.ClearError();
            }

            if (mcc.enableChannel0)
            {
                ob.SetMeasEnable(0, true);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set MeasEnable{Environment.NewLine} --> {ok} Error:{ob.GetError()}");
            }
            else
            {
                ob.SetMeasEnable(0, false);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set not MeasEnable{Environment.NewLine} --> {ok} Error:{ob.GetError()}");
            }

            if (mcc.enableChannel1)
            {
                Info(++cmd_cnt, worker, InfoLine, $@" Channel {1} set MeasEnable");
                ob.SetMeasEnable(1, true);
            }
            else
            {
                Info(++cmd_cnt, worker, InfoLine, $@" Channel {1} set not MeasEnable");
                ob.SetMeasEnable(1, false);
            }
            Info(++cmd_cnt, worker, InfoLine, $@" --> {ok} err:{ob.GetError()}");

            double posv2 = 0.0;
            double negv2 = 0.0;
            double freq = 5000.0;
            //  freq = 1.0;

            if (mcc.enableChannel0)
            {
                ok = ob.SetMeasInput(0, mcc.inputChannel0Signal);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set Meas Input to {EnumHelper.GetDescription(mcc.inputChannel1Signal)} --> {ok} Error:{ob.GetError()}");
                ok = ob.SetMeasSkip(0, mcc.measSkipChannel0);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel {0} set Meas Skip to {mcc.measSkipChannel0} --> {ok} Error:{ob.GetError()}");

                ok = ob.SetInputThreshold(GT668Class.GtiSignal.GT_SIG_A, mcc.inputThresholdModeA, mcc.inputThresholdA);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel threshold Input A set to {mcc.inputThresholdA} [{EnumHelper.GetDescription(mcc.inputThresholdModeA)}] --> {ok} Error:{ob.GetError()}");
                ok = ob.SetInputCoupling(GT668Class.GtiSignal.GT_SIG_A, mcc.inputCouplingA);
                Info(++cmd_cnt, worker, InfoLine, $@"Set Input Coupling Input A to {EnumHelper.GetDescription(mcc.inputCouplingA)} --> {ok} Error:{ob.GetError()}");
                ok = ob.SetInputImpendance(GT668Class.GtiSignal.GT_SIG_A, mcc.inputImpendanceA);
                Info(++cmd_cnt, worker, InfoLine, $@"Set impedance Input A set to {EnumHelper.GetDescription(mcc.inputImpendanceA)} termination --> {ok} Error:{ob.GetError()}");
                ob.MeasureAmplitude(GT668Class.GtiSignal.GT_SIG_A, ref posv2, ref negv2, freq);
                Info(++cmd_cnt, worker, InfoLine, $@"Amplitude {EnumHelper.GetDescription(GT668Class.GtiSignal.GT_SIG_A)} {posv2} {negv2} {freq} --> {ok} Error:{ob.GetError()}");
                ok = ob.SetInputPrescale(GT668Class.GtiSignal.GT_SIG_A, mcc.prescaleA);                
                Info(++cmd_cnt, worker, InfoLine, $@"Set InputPrescale Input A to {EnumHelper.GetDescription(mcc.prescaleA)} --> {ok} Error:{ob.GetError()}");
            }
            else
            {
                ok = ob.SetMeasInput(1, mcc.inputChannel1Signal);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel {1} set Meas Input to {EnumHelper.GetDescription(mcc.inputChannel1Signal)} --> {ok} Error:{ob.GetError()}");
                ok = ob.SetMeasSkip(1, mcc.measSkipChannel1);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel {1} set Meas Skip to {mcc.measSkipChannel1} --> {ok} Error:{ob.GetError()}");

                ok = ob.SetInputThreshold(GT668Class.GtiSignal.GT_SIG_B, mcc.inputThresholdModeB, mcc.inputThresholdB);
                Info(++cmd_cnt, worker, InfoLine, $@"Channel threshold Input B set to {mcc.inputThresholdB} [{EnumHelper.GetDescription(mcc.inputThresholdModeB)}] --> {ok} Error:{ob.GetError()}");
                ok = ob.SetInputCoupling(GT668Class.GtiSignal.GT_SIG_B, mcc.inputCouplingB);
                Info(++cmd_cnt, worker, InfoLine, $@"Set Input Coupling Input B to {EnumHelper.GetDescription(mcc.inputCouplingB)} --> {ok} Error:{ob.GetError()}");
                ok = ob.SetInputImpendance(GT668Class.GtiSignal.GT_SIG_B, mcc.inputImpendanceB);
                Info(++cmd_cnt, worker, InfoLine, $@"Set impedance Input B set to {EnumHelper.GetDescription(mcc.inputImpendanceB)} termination --> {ok} Error:{ob.GetError()}");
                ob.MeasureAmplitude(GT668Class.GtiSignal.GT_SIG_B, ref posv2, ref negv2, freq);
                Info(++cmd_cnt, worker, InfoLine, $@"Amplitude {EnumHelper.GetDescription(GT668Class.GtiSignal.GT_SIG_B)} {posv2} {negv2} {freq} --> {ok} Error:{ob.GetError()}");
                ok = ob.SetInputPrescale(GT668Class.GtiSignal.GT_SIG_B, mcc.prescaleB);
                Info(++cmd_cnt, worker, InfoLine, $@"Set InputPrescale Input B to {EnumHelper.GetDescription(mcc.prescaleB)} --> {ok} Error:{ob.GetError()}");
            }

            freq = 10000.0;
            freq = 1.0;
            ob.MeasureAmplitude(GT668Class.GtiSignal.GT_SIG_CLK, ref posv2, ref negv2, freq);
            if (posv2 - negv2 < 0.25)
            {
                Info(++cmd_cnt, worker, InfoLine, $@"No extern signal detected Reference clock not set to external  {freq}--> {ok} Error:No External clock detected");
            }
            else
            {
                ok = ob.SetReferenceClock(GT668Class.GtiRefClkSrc.GT_REF_EXTERNAL, mcc.clockFrequenz == eClockFreq.Mhz5, false);
                Info(++cmd_cnt, worker, InfoLine, $@"Set Reference clock external {EnumHelper.GetDescription(mcc.clockFrequenz)} --> {ok} Error:{ob.GetError()}");
            }

            ok = ob.SetReferenceClock(GT668Class.GtiRefClkSrc.GT_REF_EXTERNAL, mcc.clockFrequenz == eClockFreq.Mhz5, false);
            Info(++cmd_cnt, worker, InfoLine, $@"Set Reference clock external {EnumHelper.GetDescription(mcc.clockFrequenz)} --> {ok} Error:{ob.GetError()}");


            /*
            ok = ob.SetMeasGate(0, 1000);
            Info(++cmd_cnt, worker, InfoLine, $@"Set MeasGate0 to {1} --> {ok} Error:{ob.GetError()}");
            ok = ob.SetMeasGate(1, 1000);
            Info(++cmd_cnt, worker, InfoLine, $@"Set MeasGate1 to {1} --> {ok} Error:{ob.GetError()}");
            */


            //  bool init = ob.Initialize(0);
           


           // ob.SetReferenceClock(GT668Class.GtiRefClkSrc.GT_REF_INTERNAL, false, false);
            ob.SetBlockArm(GT668Class.GtiBlkArmSrc.GT_BA_IMM, GT668Class.GtiPolarity.GT_POL_POS, false);
            ob.SetArmAuxOut(GT668Class.GtiArmAuxOut.GT_AUX_OUT_OFF);
            
            if (mcc.memoryWrap)
            {
                ok = ob.SetMemoryWrapMode(true);
                Info(++cmd_cnt, worker, InfoLine, $@"Set MemoryWarapMode TRUE --> {ok} Error:{ob.GetError()}");
            }
            else
            {
                ok = ob.SetMemoryWrapMode(false);
                Info(++cmd_cnt, worker, InfoLine, $@"Set MemoryWarapMode FALSE --> {ok} Error:{ob.GetError()}");
            }
            ob.SetT0Mode(false, true);

            Info(++cmd_cnt, worker, InfoLine, $@"Waiting for measurements");
            
            ok = ob.BlockArmCommand(true);
            Info(++cmd_cnt, worker, InfoLine, $@"Block FALSE --> {ok} Error:{ob.GetError()}");
            ok = ob.BlockArmCommand(false);


            return ok;
        }

        private void measWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var ob = new GT900USBClass();
            ob.measConfig = mcc;
            bool ok = false;
            
            if (ob.measConfig.measType == eMeasType.pps_a_b)
            {
                ok = WorkerPrepareInstrumentPPS_A_B(ob,true);
            }
            else if (ob.measConfig.measType == eMeasType.freq_a)
            {
                ok = WorkerPrepareInstrumentFEQUENCY_A(ob,true);
            }
            else if (ob.measConfig.measType == eMeasType.freq_a_b)
            {
                ok = WorkerPrepareInstrumentFREQUENCY_A_B(ob, true);
                ok = WorkerPrepareInstrumentFREQUENCY_A_B(ob, true);
            }
            else
            {
                measWorker.ReportProgress(1, new ReportDataClass(InfoLine, $@"No Meastype specified --> {ok}"));
            }
            if (ok)
            {
                Thread.Sleep(200);
                StartingMeasurement(ob,true);
                Thread.Sleep(200);
                WorkerRunMeasurement(ob,true);
                while ((measWorker.IsBusy) && (!measWorker.CancellationPending))
                {
                    Thread.Sleep(100);
                }
                
            }
            if (ob != null) ob.Run = false;
        }

        private void measWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if ((measWorker.IsBusy) && (!measWorker.CancellationPending))
            {
                var data = (ReportDataClass)e.UserState;
                if (data.key == InfoLine)
                {
                    nf.AddToINFO(data.info, data.key);
                }
                else if (data.key == ErrorLine)
                {
                    nf.AddToERROR(data.info, data.key);
                }
                else if (data.key == DataLine)
                {
                    nf.AddToINFO(data.info, data.key, data.data);
                }
                else if (data.key == DataAttributesLine)
                {
                    nf.AddToINFO(data.info, data.key);
                }
            }
        }

        private void measWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            WorkerEndOutput();
            Info(0, false, ControlLine, $@"Measurement loop stopped.");
            Info(0, false, ControlLine, STOPMEAS);
        }

        public void WorkerEndOutput()
        {
            rd.Close(); //Schliesst Filehandle für Resultdatei
           
        }
    }
}
