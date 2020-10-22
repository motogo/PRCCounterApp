using BasicClassLibrary;
using Enums;
using GT668Library;
using GuideTech;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PRCCounterApp;
using PRCCounterApp.Globales;
using PRCLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuideTech
{
   
    public partial class Form1 : Form
    {
        readonly NotifiesClass nf = new NotifiesClass();
        string InfoLine = "LOG";
        string AppInfoLine = "APP_LOG";
        string ErrorLine = "ERROR_LOG";
        string AppErrorLine = "APP_ERROR_LOG";
        string DataLine = "DATA";
        string STARTMEAS = "START_MEAS";
        string STOPMEAS = "STOP_MEAS";
        string ControlLine = "CONTROL";

        void ErrorRaised(object sender, MessageEventArgs k)
        {
            if (k.Key.ToString() == ErrorLine)
            {
                txtActInfo.Text = k.Meldung;
                if (ckDebugmode.Checked) Console.WriteLine(k.Meldung);
                rtResultsErrorLog.AppendText($@"{k.Meldung}{Environment.NewLine}");
                if (cbUpdateErrorLogEveryNewEntry.Checked) rtResultsErrorLog.ScrollToCaret();
            }

        }

        void InfoRaised(object sender, MessageEventArgs k)
        {
            if (k.Key.ToString() == InfoLine)
            {
                txtActInfo.Text = k.Meldung;
                if (ckDebugmode.Checked) Console.WriteLine(k.Meldung);

                if (cbResultLogActive.Checked)
                {
                    rtResultLogs.AppendText($@"{k.Meldung}{Environment.NewLine}");
                    rtResultLogs.ScrollToCaret();
                }
            }
            else if (k.Key.ToString() == DataLine)
            {
                txtActInfo.Text = k.Meldung;
                if (cbResultLogActive.Checked)
                { 
                    rtResultLogs.AppendText($@"{k.Meldung}{Environment.NewLine}");
                    rtResultLogs.ScrollToCaret();
                }
                if (k.Data != null)
                {
                    var dt = (ResultDataClass) k.Data;
                    DataRow dr = dsResults.Tables[0].NewRow();
                    dr.ItemArray = new object[] {dt.ID ,dt.STAMP,dt.DATASTAMP, dt.VALUE,k.Meldung };
                    dsResults.Tables[0].Rows.Add(dr);
                    bsResults.Position = bsResults.Count;
                }
            }
            else if (k.Key.ToString() == ControlLine)
            {
                if (k.Meldung.StartsWith(STARTMEAS))
                {
                    hsStop.Enabled = true;
                    hsRun.Enabled = false;
                }
                else if (k.Meldung.StartsWith(STOPMEAS))
                {
                    hsStop.Enabled = false;
                    hsRun.Enabled = true;
                }
            }
            else if (k.Key.ToString() == AppInfoLine)
            {                
                //if (ckDebugmode.Checked) Console.WriteLine(k.Meldung);
                rtbAppLog.AppendText($@"{k.Meldung}{Environment.NewLine}");
                //if (cbUpdateLogEveryNewEntry.Checked) rtResultLogs.ScrollToCaret();
            }
        }

        

        public Form1()
        {
            InitializeComponent();
            nf.Register4Info(InfoRaised);
            nf.Register4Error(ErrorRaised);
            nf.InfoGranularity = eMessageGranularity.normal;


            /*
            machinename = Environment.MachineName;
            temppath = Path.GetTempPath();
            apppath = Path.GetDirectoryName(assbly.Location);
            */
            
            /*
            ConfigClass.Instance().WriteDefaultConfig($@"{Application.StartupPath}\Config\{appname}Config.xml");
            ConfigClass.Instance().XMLName = $@"{Application.StartupPath}\Config\{appname}Config.xml";
            ConfigClass.Instance().SerializeCurrent();
            */
            
            
            
        }

        private void btnIsMaster_Click(object sender, EventArgs e)
        {
            txtResultIsMaster.Text = string.Empty;
            ob.ClearError();
            bool ok = ob.IsMaster();
            int err = ob.GetError();
            txtResultIsMaster.Text = $@"{ok} Error:{ob.GetErrorMessage(err)}";
        }

        private void btnGetBoardModel_Click(object sender, EventArgs e)
        {
            txtResultBoardModel.Text = string.Empty;
            ob.ClearError();
            string bm = ob.GetBoardModel();
            int err = ob.GetError();
            txtResultBoardModel.Text = $@"{bm} Error:{ob.GetErrorMessage(err)}";
        }

        private void btnGetSerial_Click(object sender, EventArgs e)
        {
            txtResultSerial.Text = string.Empty;
            ob.ClearError();
            string bm = ob.GT668GetSerialNumberStr();
            int err = ob.GetError();
            txtResultSerial.Text = $@"{bm} Error:{ob.GetErrorMessage(err)}";
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            int n = StaticFunctionsClass.ToIntDef(txtBoard.Text, -1);
            if (n < 0) return;
            txtResultInitialize.Text = string.Empty;
            ob.ClearError();
            ob.Initialize(n);
            int err = ob.GetError();
            txtResultInitialize.Text = $@"Initialize{n}->{ob.GetErrorMessage(err)}";
        }

        private void btnInitDefault_Click(object sender, EventArgs e)
        {
            txtInitDefault.Text = string.Empty;
            ob.ClearError();
            ob.InitDefault(ckSetClock.Checked);
            int err = ob.GetError();
            txtInitDefault.Text = $@"InitDefault({ckSetClock.Checked})->{ob.GetErrorMessage(err)}";
        }

        public static string ByteArrayToString(uint[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        private uint ActRaw=0U;
        private uint[] RawData=new uint[1000];
        private uint Offset=0U;
        private uint RawCount=1000U;
        private uint ReadCount=6U;
        



        public ResultDatas PrepareOutput()
        {
            string now = DateTime.Now.ToShortDateString().Replace(".", "_") + "_" + DateTime.Now.ToLongTimeString().Replace(":", "_");
            ResultDatas rd = new ResultDatas();
            rd.ResultOut = GetResultFormats();
            return rd;
        }

        public string GetFilenemeFromPattern(string filepattern)
        {
            string f = filepattern.Replace("<ticks>",StaticMeasFunctions.GetActDateTimeCnt().ToString());
            return f;
        }

        public List<ResultOutClass> GetResultFormats()
        {
            var rc= new List<ResultOutClass>();
            bsOutputDefinition.Position = 0;
            for(int i =0; i < bsOutputDefinition.Count; i++)
            {
                bsOutputDefinition.Position = i;
                DataRowView ob = (DataRowView)bsOutputDefinition.Current;
                string fmt = ob.Row["outdefFORMAT"].ToString();
                string resultpath = ob.Row["outdefPATH"].ToString();
                string resultfile = ob.Row["outdefFILEPATTERN"].ToString();
                string resultdatasource = ob.Row["outdefDATASOURCE"].ToString();
                bool active = (bool) ob.Row["outdefACTIVE"];
                ResultOutClass r = new ResultOutClass();
                r.format = fmt;
                r.ResultFile = $@"{resultpath}\{GetFilenemeFromPattern(resultfile)}";
                if (resultdatasource == EnumHelper.GetDescription(eDatasource.liteDB))
                {
                    r.DataSource = eDatasource.liteDB;
                }
                else if (resultdatasource == EnumHelper.GetDescription(eDatasource.file))
                {
                    r.DataSource = eDatasource.file;
                }
                if(r.DataSource == eDatasource.file)
                {
                    r.fl = new StreamWriter(r.ResultFile, true);
                    r.Active = active;
                }
                rc.Add(r);
            }
            return rc;
        }

        MeasurementClass mc = null;

        private void hsRun_Click(object sender, EventArgs e)
        {
            
        }

       
        private void BetGetMeasInput_Click(object sender, EventArgs e)
        {
            int ch = StaticFunctionsClass.ToIntDef(txtCh2.Text, -1);
            if (ch < 0) return;
            
            var sel = GT900USBClass.GtiInputSel.GT_CLOCK;
            ob.GetMeasInput(ch, ref sel);
            txtMeasInput.Text = sel.ToString();
             
        }

        private void btnGetDriverVersion_Click(object sender, EventArgs e)
        {
            
            string str = ob.GetDriverVersion();
            txtDriver.Text = str;
        }

        private void SetMeasInputA_Click(object sender, EventArgs e)
        {
            int ch = StaticFunctionsClass.ToIntDef(txtInputA.Text, -1);
            if (ch < 0) return;
            

            if(ob != null) ob.SetMeasInput(ch, GT668Class.GtiInputSel.GT_CHA_POS);
        }

        private void btnSetInputB_Click(object sender, EventArgs e)
        {
            int ch = StaticFunctionsClass.ToIntDef(txtInputB.Text, -1);
            if (ch < 0) return;
            
            if (ob != null) ob.SetMeasInput(ch, GT668Class.GtiInputSel.GT_CHB_POS);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*
            this.RawData = new uint[checked((int)((long)this.ReadCount - 1L) + 1)];
            richTextBox1.AppendText($@"Data:{ReadData(ob)}{Environment.NewLine}");
            */
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DebugForm db = new DebugForm();
            db.ShowDialog();
        }

        private void btnCalibrate_Click_1(object sender, EventArgs e)
        {
            
            bool ok = ob.SelfCal();
            uint ct = ob.GetCalTime();
            int err = ob.GetError();
            txtCalibrate.Text = $@"{ok} caltime:{ct} error:{ob.GetErrorMessage(err)}";
        }

        private void btnSetRealtime_Click(object sender, EventArgs e)
        {
            int sec = StaticFunctionsClass.ToIntDef(txtSetRealtime.Text, -1);
            if (sec < 0) return;
            
            uint sec1 = 0;
            uint sec2 = 0;

            bool ok1 = ob.GetRealTime(ref sec1);
            int err1 = ob.GetError();
            txtGetRealtime1.Text = $@"{ok1} time:{sec1} error:{ob.GetErrorMessage(err1)}";
            bool ok  = ob.SetRealTime((uint) sec, true);
            bool ok2 = ob.GetRealTime(ref sec2);
            int err2 = ob.GetError();
            txtGetRealtime2.Text = $@"{ok2} time:{sec2} error:{ob.GetErrorMessage(err2)}";
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSleep_TextChanged(object sender, EventArgs e)
        {
            txtSleep.BackColor = Color.White;
            
        }

        

        private void hsAssignLoops_Click(object sender, EventArgs e)
        {
            int n = handleClickInt(txtLoops, hsAssignLoops);
          //  if (ob == null) return;
          //  ob.measConfig.loops = n;
        }

        private int handleClickInt(object sender, SeControlsLib.HotSpot btn)
        {
            var txt = (TextBox)sender;
            int n = StaticFunctionsClass.ToIntDef(txt.Text, -1);
            if (n < 0)
            {
                txt.BackColor = Color.White;
                btn.Enabled = true;
                return n;
            }
            txt.BackColor = Color.Lime;
            btn.Enabled = false;
            return n;
        }
        private double handleClickDouble(object sender, SeControlsLib.HotSpot btn)
        {
            var txt = (TextBox)sender;
            double n = StaticFunctionsClass.ToDoubleDef(txt.Text, -1);
            if (n < 0)
            {
                txt.BackColor = Color.White;
                btn.Enabled = true;
                return n;
            }
            txt.BackColor = Color.Lime;
            btn.Enabled = false;
            return n;
        }

        public FileStream RedirectConsoleToFile(string logfile)
        {
            FileStream fs = null;
            try
            {
                if (File.Exists(logfile))
                {
                    fs = new FileStream(logfile, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                }
                else
                {
                    fs = new FileStream(logfile, FileMode.CreateNew, FileAccess.Write, FileShare.ReadWrite);
                }
            }
            catch
            {

            }
            if (fs != null)
            {
                var streamwriter = new StreamWriter(fs, Encoding.UTF8);
                streamwriter.AutoFlush = true;
                Console.SetOut(streamwriter);
                Console.SetError(streamwriter);
            }
            return (fs);
        }
        public void RedirectConsoleToDefault()
        {
            var so = new StreamWriter(Console.OpenStandardOutput());
            so.AutoFlush = true;
            var soe = new StreamWriter(Console.OpenStandardError());
            soe.AutoFlush = true;
            Console.SetOut(so);
            Console.SetError(soe);
        }

        


        public void ShowStatistikGraph(FileInfo fi)
        {
        // D:\Projekte2015\PRCMeasSolution\Anwendung\Scripts\AllanByFile_TDEV.py temppath = D:\Projekte2015\PRCCounterApp\PRCCounterApp\bin\Debug\Temp datafile = D:\PRCCounterApp\Results\AutogeneratedResultFile_160355499.dat logfile = D:\Projekte2015\PRCCounterApp\PRCCounterApp\bin\Debug\Temp\AllanFB_TDEV4.log debug = True xscaletype = log10 maxtau = 100000 errorbars = True phasetype = phase samplingrate = 1.0 xscaletype = log10 stattype = ADEV,0; TDEV,1; OADEV,2; MDEV,3
            if (Directory.Exists(ConfigClass.Instance().LogPath) && Directory.Exists(ConfigClass.Instance().TempPath))
            {
                string cmd = $@"python";
                Process ps = new Process();
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.CreateNoWindow = true;
               
                psi.FileName = cmd;
                string stattype = string.Empty;
                int colinx = 0;
                if(ckTDEV.Checked)
                {
                    stattype += string.IsNullOrEmpty(stattype) ? $@" stattype=TDEV,{colinx++}" : $@";TDEV,{colinx++}";
                }
                if (ckADEV.Checked)
                {
                    stattype += string.IsNullOrEmpty(stattype) ? $@" stattype=ADEV,{colinx++}" : $@";ADEV,{colinx++}";
                }
                if (ckOADEV.Checked)
                {
                    stattype += string.IsNullOrEmpty(stattype) ? $@" stattype=OADEV,{colinx++}" : $@";OADEV,{colinx++}";
                }
                if (ckMDEV.Checked)
                {
                    stattype += string.IsNullOrEmpty(stattype) ? $@" stattype=MDEV,{colinx++}" : $@";MDEV,{colinx++}";
                }


                if (cbUseHeaderfile.Checked)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($@"#starttime:0");
                    sb.AppendLine($@"#endtime:0");
                    sb.AppendLine($@"#offset:0.0");
                    sb.AppendLine($@"#titel:{actMeasConfiguration.measName} {actMeasConfiguration.measType} {actMeasConfiguration.measType} mit GT900, 1.7.1 USB3");
                    sb.AppendLine($@"#xtitel:{actMeasConfiguration.XLegendName}");
                    sb.AppendLine($@"#ytitel:{actMeasConfiguration.YLegendName}");
                    sb.AppendLine($@"#yscale:{actMeasConfiguration.ScaleYAxis}");
                    sb.AppendLine($@"#legend:{actMeasConfiguration.GraphLegendName}");
                    sb.AppendLine($@"#color:blue");
                    sb.AppendLine($@"#marker:*");
                    sb.AppendLine($@"#subplot:0");
                    sb.AppendLine($@"#colsplit:,");
                    sb.AppendLine($@"#rowsplit:;");
                    sb.AppendLine($@"#temp:D:\temp");
                    sb.AppendLine($@"#logfile:D:\temp\log\log.txt");
                    sb.AppendLine($@"#measname:messung");
                    try
                    {
                        File.WriteAllText($@"{ConfigClass.Instance().TempPath}\header.dat", sb.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($@"{ex.Message}", "Error ShowGraph", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    psi.Arguments = $@"{ConfigClass.Instance().ScriptPath}\AllanByFile_TDEV.py temppath={ConfigClass.Instance().TempPath} datafile={fi.FullName} logfile={ConfigClass.Instance().TempPath}\AllanFB_TDEV4.log  headerfile={ConfigClass.Instance().TempPath}\header.dat debug=True xscaletype=log10 maxtau=100000 errorbars=True phasetype=phase samplingrate=1.0 xscaletype=log10{stattype}";
                    //psi.Arguments = $@"{ConfigClass.Instance().ScriptPath}\MultiPhaseLineByFile5.py logfile={ConfigClass.Instance().LogPath}\MultiPhaseLineByFile5.log temppath={ConfigClass.Instance().TempPath} datafile={fi.FullName} headerfile={ConfigClass.Instance().TempPath}\header.dat debug=true colsplit=, rowsplit=; timetype=sec outliers={txtOutliers.Text}";
                }
                else
                {
                    psi.Arguments = $@"{ConfigClass.Instance().ScriptPath}\AllanByFile_TDEV.py temppath={ConfigClass.Instance().TempPath} datafile={fi.FullName} logfile={ConfigClass.Instance().TempPath}\AllanFB_TDEV4.log debug=True xscaletype=log10 maxtau=100000 errorbars=True phasetype=phase samplingrate=1.0 xscaletype=log10{stattype}";
                    //psi.Arguments = $@"{ConfigClass.Instance().ScriptPath}\MultiPhaseLineByFile5.py logfile={ConfigClass.Instance().LogPath}\MultiPhaseLineByFile5.log temppath={ConfigClass.Instance().TempPath} datafile={fi.FullName} debug=true colsplit=, rowsplit=; timetype=sec outliers={txtOutliers.Text}";
                }

                //psi.Arguments = $@"D:\Projekte2015\PRCMeasSolution\Anwendung\scripts\MultiPhaseLineByFile5.py logfile=d:\temp temppath=d:\temp datafile=d:\prccounterapp\results\AutogeneratedResultFile_146692217.dat headerfile=d:\temp\header.dat debug=true colsplit=, rowsplit=; timetype=sec";

                //psi.RedirectStandardOutput = true;

                nf.AddToINFO($@"python {psi.Arguments}", AppInfoLine);
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                ps.StartInfo = psi;
                bool ok = ps.Start();
            }
            else
            {

                MessageBox.Show($@"Temp:{ConfigClass.Instance().TempPath}{Environment.NewLine}Log:{ConfigClass.Instance().LogPath}", "Path not exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void ShowGraph(FileInfo fi)
        {
             if(Directory.Exists(ConfigClass.Instance().LogPath)&&Directory.Exists(ConfigClass.Instance().TempPath))
             {
                string cmd = $@"python";
                Process ps = new Process();
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.FileName = cmd;


                if (cbUseHeaderfile.Checked)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($@"#startmjd:0");
                    sb.AppendLine($@"#endmjd:0");
                    sb.AppendLine($@"#offset:0.0");
                    sb.AppendLine($@"#titel:{actMeasConfiguration.measName} {actMeasConfiguration.measType} {actMeasConfiguration.measType} mit GT900, 1.7.1 USB3");
                    sb.AppendLine($@"#xtitel:{actMeasConfiguration.XLegendName}");
                    sb.AppendLine($@"#ytitel:{actMeasConfiguration.YLegendName}");
                    sb.AppendLine($@"#yscale:{actMeasConfiguration.ScaleYAxis}");
                    sb.AppendLine($@"#legend:{actMeasConfiguration.GraphLegendName}");
                    sb.AppendLine($@"#color:blue");
                    sb.AppendLine($@"#marker:*");
                    sb.AppendLine($@"#subplot:0");
                    sb.AppendLine($@"#colsplit:,");
                    sb.AppendLine($@"#rowsplit:;");
                    sb.AppendLine($@"#temp:D:\temp");
                    sb.AppendLine($@"#logfile:D:\temp\log\log.txt");
                    sb.AppendLine($@"#measname:messung");
                    try
                    {
                        File.WriteAllText($@"{ConfigClass.Instance().TempPath}\header.dat", sb.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($@"{ex.Message}", "Error ShowGraph", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    psi.Arguments = $@"{ConfigClass.Instance().ScriptPath}\MultiPhaseLineByFile5.py logfile={ConfigClass.Instance().LogPath}\MultiPhaseLineByFile5.log temppath={ConfigClass.Instance().TempPath} datafile={fi.FullName} headerfile={ConfigClass.Instance().TempPath}\header.dat debug=true colsplit=, rowsplit=; timetype=sec outliers={txtOutliers.Text}";                    
                }
                else
                {
                    psi.Arguments = $@"{ConfigClass.Instance().ScriptPath}\MultiPhaseLineByFile5.py logfile={ConfigClass.Instance().LogPath}\MultiPhaseLineByFile5.log temppath={ConfigClass.Instance().TempPath} datafile={fi.FullName} debug=true colsplit=, rowsplit=; timetype=sec outliers={txtOutliers.Text}";
                }

                //psi.Arguments = $@"D:\Projekte2015\PRCMeasSolution\Anwendung\scripts\MultiPhaseLineByFile5.py logfile=d:\temp temppath=d:\temp datafile=d:\prccounterapp\results\AutogeneratedResultFile_146692217.dat headerfile=d:\temp\header.dat debug=true colsplit=, rowsplit=; timetype=sec";
                
                psi.RedirectStandardOutput = true;

                nf.AddToINFO($@"python {psi.Arguments}", AppInfoLine);
                ps.StartInfo = psi;
                bool ok = ps.Start();
            }
            else
            {
               
                MessageBox.Show($@"Temp:{ConfigClass.Instance().TempPath}{Environment.NewLine}Log:{ConfigClass.Instance().LogPath}", "Path not exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MeasurementConfigToUI(MeasurementConfigClass mcc)
        {
            txtBoard.Text = mcc.board.ToString();
            txtSleep.Text = mcc.sleepAfterSingleMeasurement.ToString();
            txtLoops.Text = mcc.loops.ToString();
            gbActCommand.Text = $@"Act measurement:{mcc.measName}";
            txtMeasinfo.Text = mcc.measInfo;
            txtMeasname.Text = mcc.measName;
            txtYLegend.Text = mcc.YLegendName;
            txtXLegend.Text = mcc.XLegendName;
            txtGraphLegend.Text = mcc.GraphLegendName;

            txtNumTags0.Text = mcc.numTag0.ToString();
            txtNumTags1.Text = mcc.numTag1.ToString();
            ckChannel0.Checked = mcc.enableChannel0;
            ckChannel1.Checked = mcc.enableChannel1;
            ckCal.Checked = mcc.doCalibration;
            rbChannelAPositiveVoltage.Checked = mcc.inputChannel0Signal == GT668Class.GtiInputSel.GT_CHA_POS;
            rbChannelBPositiveVoltage.Checked = mcc.inputChannel1Signal == GT668Class.GtiInputSel.GT_CHB_POS;
            
            txtMeasSkipCh0.Text     = mcc.measSkipChannel0.ToString();
            txtMeasSkipCh1.Text     = mcc.measSkipChannel1.ToString();
            txtMeasGate0.Text       = mcc.measGateChannel0.ToString();
            txtMeasGate1.Text       = mcc.measGateChannel1.ToString();
            txtThresholdA.Text      = mcc.inputThresholdA.ToString();
            txtThresholdB.Text      = mcc.inputThresholdB.ToString();
            txtThresholdClock.Text  = mcc.clockThreshold.ToString();
            txtYOffset.Text         = mcc.userDefinedYOffset.ToString();
            txtScaleYAxis.Text      = mcc.ScaleYAxis.ToString();
            /*
            mcc.inputThresholdModeA = GT668Class.GtiThrMode.GT_THR_VOLTS;
            mcc.inputThresholdModeB = GT668Class.GtiThrMode.GT_THR_VOLTS;
            mcc.clockThresholdMode = GT668Class.GtiThrMode.GT_THR_VOLTS;
            */

            rbChannelACouplingDC.Checked    = mcc.inputCouplingA == GT668Class.GtiCoupling.GT_CPL_DC;
            rbChannelBCouplingDC.Checked    = mcc.inputCouplingB == GT668Class.GtiCoupling.GT_CPL_DC;
            rbClockUseExtern.Checked        = mcc.referenceClock == GT668Class.GtiRefClkSrc.GT_REF_EXTERNAL;
            rbClock10MHZ.Checked            = mcc.clockFrequenz == eClockFreq.Mhz10;
            rbChannelAImpedanceLO.Checked   = mcc.inputImpendanceA == GT668Class.GtiImpedance.GT_IMP_LO;
            rbChannelBImpedanceLO.Checked   = mcc.inputImpendanceB == GT668Class.GtiImpedance.GT_IMP_LO;
            rbChannelACouplingDC.Checked    = mcc.inputCouplingA == GT668Class.GtiCoupling.GT_CPL_DC;
            rbChannelBCouplingDC.Checked    = mcc.inputCouplingB == GT668Class.GtiCoupling.GT_CPL_DC;
            ckReadAllErrors.Checked         = mcc.showAllErrors;
            ckShowResults.Checked           = mcc.showResults;
            ckNewMeas.Checked               = mcc.restartMeasurementAfterLoop;
            ckMemoryWrap.Checked            = mcc.memoryWrap;
            rbPhaseAB.Checked               = mcc.measType == eMeasType.pps_a_b;
            rbFrequencyA.Checked            = mcc.measType == eMeasType.freq_a;
            rbFrequency_A_B.Checked         = mcc.measType == eMeasType.freq_a_b;
            cbPrescaleA.SelectedItem        = (GT668Class.GtiPrescale) mcc.prescaleA;
            cbPrescaleB.SelectedItem        = (GT668Class.GtiPrescale) mcc.prescaleB;

            dsOutputDefintion.Tables[0].Rows.Clear();


            for (int i = 0; i < mcc.ResultDefinitions.Count; i++)
            {
                var row = dsOutputDefintion.Tables[0].NewRow();
                row["outdefID"] = Guid.NewGuid();
                row["outdefACTIVE"] =   (object) mcc.ResultDefinitions[i].Active;
                row["outdefFORMAT"] = mcc.ResultDefinitions[i].DataFormat;
                row["outdefPATH"] = mcc.ResultDefinitions[i].Path;
                row["outdefFILEPATTERN"] = mcc.ResultDefinitions[i].FilePattern;
                row["outdefDATASOURCE"] = EnumHelper.GetDescription(mcc.ResultDefinitions[i].DataSource);


                dsOutputDefintion.Tables[0].Rows.Add(row);
            }
            txtConfigurationFile.Text = mcc.XMLName;
        }
        private MeasurementConfigClass GetMeasurementConfigFromUI()
        {
            MeasurementConfigClass mcc = new MeasurementConfigClass();
            mcc.board                       = Int32.Parse(txtBoard.Text);
            mcc.sleepAfterSingleMeasurement = Int32.Parse(txtSleep.Text);
            mcc.loops               = Int32.Parse(txtLoops.Text);                        
            mcc.stamp               = DateTime.Now;
            mcc.measInfo            = txtMeasinfo.Text;
            mcc.measName            = txtMeasname.Text;
            mcc.YLegendName         = txtYLegend.Text;
            mcc.XLegendName         = txtXLegend.Text;
            mcc.ScaleYAxis          = StaticFunctionsClass.ToIntDef(txtScaleYAxis.Text.Replace(".", ","), 9);
            mcc.GraphLegendName     = txtGraphLegend.Text;
            mcc.numTag0             = UInt32.Parse(txtNumTags0.Text);
            mcc.numTag1             = UInt32.Parse(txtNumTags1.Text);
            mcc.enableChannel0      = ckChannel0.Checked;
            mcc.enableChannel1      = ckChannel1.Checked;
            mcc.doCalibration       = ckCal.Checked;
            mcc.inputChannel0Signal = rbChannelAPositiveVoltage.Checked ? GT668Class.GtiInputSel.GT_CHA_POS : GT668Class.GtiInputSel.GT_CHA_NEG;
            mcc.inputChannel1Signal = rbChannelBPositiveVoltage.Checked ? GT668Class.GtiInputSel.GT_CHB_POS : GT668Class.GtiInputSel.GT_CHB_NEG;
            mcc.measSkipChannel0    = uint.Parse(txtMeasSkipCh0.Text);
            mcc.measSkipChannel1    = uint.Parse(txtMeasSkipCh1.Text);
            mcc.measGateChannel0    = (uint) StaticFunctionsClass.ToIntDef(txtMeasGate0.Text.Replace(".", ","), 1);
            mcc.measGateChannel1    = (uint) StaticFunctionsClass.ToIntDef(txtMeasGate1.Text.Replace(".", ","), 1);
            mcc.inputThresholdA     = StaticFunctionsClass.ToDoubleDef(txtThresholdA.Text.Replace(".",","),  1.0);
            mcc.inputThresholdB     = StaticFunctionsClass.ToDoubleDef(txtThresholdB.Text.Replace(".", ","), 1.0);
            mcc.clockThreshold      = StaticFunctionsClass.ToDoubleDef(txtThresholdClock.Text.Replace(".", ","), 1.0);
            mcc.inputThresholdModeA = GT668Class.GtiThrMode.GT_THR_VOLTS;
            mcc.inputThresholdModeB = GT668Class.GtiThrMode.GT_THR_VOLTS;
            mcc.clockThresholdMode  = GT668Class.GtiThrMode.GT_THR_VOLTS;
            mcc.inputCouplingA      = rbChannelACouplingDC.Checked ? GT668Class.GtiCoupling.GT_CPL_DC : GT668Class.GtiCoupling.GT_CPL_AC;
            mcc.inputCouplingB      = rbChannelBCouplingDC.Checked ? GT668Class.GtiCoupling.GT_CPL_DC : GT668Class.GtiCoupling.GT_CPL_AC;
            mcc.referenceClock      = rbClockUseExtern.Checked ? GT668Class.GtiRefClkSrc.GT_REF_EXTERNAL : GT668Class.GtiRefClkSrc.GT_REF_INTERNAL;
            mcc.clockFrequenz       = rbClock10MHZ.Checked ? eClockFreq.Mhz10 : eClockFreq.Mhz5;
            mcc.inputImpendanceA    = rbChannelAImpedanceLO.Checked ? GT668Class.GtiImpedance.GT_IMP_LO : GT668Class.GtiImpedance.GT_IMP_HI;
            mcc.inputImpendanceB    = rbChannelBImpedanceLO.Checked ? GT668Class.GtiImpedance.GT_IMP_LO : GT668Class.GtiImpedance.GT_IMP_HI;
            mcc.showAllErrors       = ckReadAllErrors.Checked;
            mcc.showResults         = ckShowResults.Checked;
            mcc.restartMeasurementAfterLoop = ckNewMeas.Checked;
            mcc.userDefinedYOffset = StaticFunctionsClass.ToDoubleDef(txtYOffset.Text.Replace(".", ","), 0.0);
            if (rbPhaseAB.Checked)
            {
                mcc.measType        = eMeasType.pps_a_b;
            }
            else if(rbFrequencyA.Checked)
            {
                mcc.measType        = eMeasType.freq_a;
            }
            else if (rbFrequency_A_B.Checked)
            {
                mcc.measType = eMeasType.freq_a_b;
            }

            mcc.prescaleA = (GT668Class.GtiPrescale) cbPrescaleA.SelectedItem;
            mcc.prescaleB = (GT668Class.GtiPrescale) cbPrescaleB.SelectedItem;
            bsOutputDefinition.Position = 0;
           
            for(int i = 0; i < bsOutputDefinition.Count; i++)
            {
                DataRowView citem = (DataRowView)bsOutputDefinition.Current;
                Guid gid    = (Guid) citem.Row.ItemArray[0];
                string path = citem.Row.ItemArray[1].ToString();
                string fmt  = citem.Row.ItemArray[2].ToString();
                bool act    = (bool) citem.Row.ItemArray[3];
                string fn   = citem.Row.ItemArray[4].ToString();
                string ds = citem.Row.ItemArray[5].ToString();


                ResultDefinition rs  = new ResultDefinition();
                rs.DataFormat = fmt;
                rs.Path = path;
                rs.FilePattern = fn;
                rs.Active = act;
                if (ds == EnumHelper.GetDescription(eDatasource.file))
                {
                    rs.DataSource = eDatasource.file;
                }
                else if (ds == EnumHelper.GetDescription(eDatasource.AVARfile))
                {
                    rs.DataSource = eDatasource.AVARfile;
                }
                if (ds == EnumHelper.GetDescription(eDatasource.liteDB))
                {
                    rs.DataSource = eDatasource.liteDB;
                }
                if (ds == EnumHelper.GetDescription(eDatasource.timeAnalyzerFile))
                {
                    rs.DataSource = eDatasource.timeAnalyzerFile;
                }
                mcc.ResultDefinitions.Add(rs);
                bsOutputDefinition.Position++;             
            }
            mcc.XMLName = txtConfigurationFile.Text;
            return mcc;
        }

        private void hsCloseApp_Click(object sender, EventArgs e)
        {
            if (hsStop.Enabled)
            {
                if (MessageBox.Show("There is an running measurment ongoing.\r\nDo you want to stop for closing application", "Measurement is running", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    mc.Stop();
                    Application.DoEvents();
                    while (hsStop.Enabled)
                    {
                        Thread.Sleep(100);
                    }
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void ConfigAddOutputDefinition()
        {
            List<ResultDefinition> rs = ConfigClass.Instance().ResultDefinitions;
            foreach (ResultDefinition res in rs)
            {
                var row = dsOutputDefintion.Tables[0].NewRow();
                row["outdefID"] = Guid.NewGuid();
                row["outdefACTIVE"] = (object)true;
                row["outdefFORMAT"] =  res.DataFormat;
                row["outdefPATH"] = $@"{res.Path}\{res.FilePattern}_{DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss_f")}.dat";
                dsOutputDefintion.Tables[0].Rows.Add(row);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pa = StaticAppFunctions.GetProgrammAttributes(System.Reflection.Assembly.GetExecutingAssembly());
            this.Text = $@"{pa.AppName} (c) SoftEnd V{pa.AppVersion}";

            cbPrescaleA.Items.Clear();
            cbPrescaleB.Items.Clear();

            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_1);
            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_2);
            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_4);
            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_8);
            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_16);
            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_32);
            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_64);
            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_128);
            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_256);
            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_512);
            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_1024);
            cbPrescaleA.Items.Add(GT668Class.GtiPrescale.GT_DIV_AUTO);

            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_1);
            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_2);
            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_4);
            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_8);
            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_16);
            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_32);
            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_64);
            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_128);
            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_256);
            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_512);
            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_1024);
            cbPrescaleB.Items.Add(GT668Class.GtiPrescale.GT_DIV_AUTO);

            cbPrescaleA.SelectedItem = GT668Class.GtiPrescale.GT_DIV_AUTO;
            cbPrescaleB.SelectedItem = GT668Class.GtiPrescale.GT_DIV_AUTO;

            string appConf = $@"{Application.StartupPath}\Config\{pa.AppName}Config.xml";
            if (!File.Exists(appConf))
            {
                MessageBox.Show($@"No Application confiuration {appConf} exists.{Environment.NewLine}A default configuration will be created.", "App Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConfigClass.Instance().WriteDefaultConfig(appConf);
            }
            ConfigClass.Instance().Deserialize(appConf);
            if (File.Exists(ConfigClass.Instance().LastMeasurementConfigFile))
            {
                MeasurementConfigClass mcc = new MeasurementConfigClass();
                mcc.Deserialize($@"{ConfigClass.Instance().LastMeasurementConfigFile}");
                MeasurementConfigToUI(mcc);
                txtConfigurationFile.Text = mcc.XMLName;
                actMeasConfiguration = mcc;
            }
            else
            {
                var mc = new MeasurementConfigClass();
                mc.CreateDefaultConfig_Phase_A_B();
                MeasurementConfigToUI(mc);
                actMeasConfiguration = mc;
            }






            
            
           // this.ConfigAddOutputDefinition();
            // LoadDefaultConfig();
            SetDefaultUI();
            CheckedChanged();
            hsRun.Enabled = true;
            hsStop.Enabled = false;
        }

        public void LoadDefaultConfig()
        {
            var mcc = new MeasurementConfigClass();
            FileInfo fi = new FileInfo($@"{Application.StartupPath}\Config\lastMeasconf.xml");
            if (fi.Exists)
            {
                if (mcc.Deserialize(fi.FullName))
                {
                    MeasurementConfigToUI(mcc);
                    actMeasConfiguration = mcc;
                    gbMeasinfo.Text = "Measinfo (Last used measconfiguration)";
                    return;
                }
            }
            
            fi = new FileInfo($@"{Application.StartupPath}\Config\defaultMeasconf.xml");
            if (fi.Exists)
            {
                if (mcc.Deserialize(fi.FullName))
                {
                    MeasurementConfigToUI(mcc);
                    actMeasConfiguration = mcc;
                    gbMeasinfo.Text = "Measinfo (Default measconfiguration)";
                    return;
                }
            }

            mcc.CreateDefaultConfig_Phase_A_B();
            MeasurementConfigToUI(mcc);
            gbMeasinfo.Text = "Measinfo (Newly autogeneratet measconfiguration)";
            actMeasConfiguration = mcc;
        }

        private void bsOutputDefinition_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView ob = (DataRowView)bsOutputDefinition.Current;
                if (ob != null)
                {
                    txtMeasResultDefinitionPath.Text        = ob.Row["outdefPATH"].ToString();
                    txtMeasResultDefinitionFilePattern.Text = ob.Row["outdefFILEPATTERN"].ToString();
                    txtMeasResultDefinitionFormat.Text      = ob.Row["outdefFORMAT"].ToString();
                    ckMeasResultDefinitionActive.Checked    = (bool)ob.Row["outdefACTIVE"];
                    string datasource                       = ob.Row["outdefDATASOURCE"].ToString();
                    rbResultFile.Checked                    = (datasource == EnumHelper.GetDescription(eDatasource.file));
                    rbResultLiteDB.Checked                  = (datasource == EnumHelper.GetDescription(eDatasource.liteDB));
                }
            }
            catch
            {

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int n = StaticFunctionsClass.ToIntDef(txtSelectDev.Text, -1);
            if (n < 0) return;
            
            ob.ClearError();
            ob.Select(n);
            int err = ob.GetError();
            txtSelectDeviceResult.Text = $@"Select({n})->{ob.GetErrorMessage(err)}";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int nb = StaticFunctionsClass.ToIntDef(txtPhysBd.Text, -1);
            int nd = StaticFunctionsClass.ToIntDef(txtVirtDev.Text, -1);
            if (nd < 0) return;
            if (nb < 0) return;
            
            txtAssignResult.Text = string.Empty;
            ob.ClearError();
            bool erg = ob.AssignBoardNumber(nd, nb);
            int err = ob.GetError();
            txtAssignResult.Text = $@"{erg}->{ob.GetErrorMessage(err)}";
        }

        GT900USBClass ob = new GT900USBClass();

        private void btnSystemInit_Click(object sender, EventArgs e)
        {
            int dev = StaticFunctionsClass.ToIntDef(txtSystemInitDev.Text, -1);
            int mask = StaticFunctionsClass.ToIntDef(txtSystemInitDevMask.Text, -1);
            if (dev < 0) return;
            if (mask < 0) return;
            
            txtResultSystemInit.Text = string.Empty;
            ob.ClearError();
            bool erg = ob.SystemInitialize(dev, (uint) mask);
            int err = ob.GetError();
            txtResultSystemInit.Text = $@"{erg}->{ob.GetErrorMessage(err)}";
        }

        private void btnGetBoard_Click(object sender, EventArgs e)
        {
            txtResuldBoardError.Text = string.Empty;
            ob.ClearError();
            int erg = ob.EnumerateBoards(ckFirst.Checked);
            int err = ob.GetError();
            txtResultBoard.Text = erg.ToString();
            txtResuldBoardError.Text = $@"{erg}->{ob.GetErrorMessage(err)}";
        }

        private void btnIsInit_Click(object sender, EventArgs e)
        {
            int dev = StaticFunctionsClass.ToIntDef(txtIsInitDev.Text, -1);
            if (dev < 0) return;

            txtResultIsInitDev.Text = string.Empty;
            ob.ClearError();
            bool erg = ob.IsInitialized(dev);
            int err = ob.GetError();
            txtResultIsInitDev.Text = $@"{erg}->{ob.GetErrorMessage(err)}";
        }

        private void btnCloseDevice_Click(object sender, EventArgs e)
        {
            txtResultCloseDevice.Text = string.Empty;
            ob.ClearError();
            ob.CloseMeasurement();
            int err = ob.GetError();
            txtResultCloseDevice.Text = $@"Close()->{ob.GetErrorMessage(err)}";
        }

        private void btnRecreateAPI_Click(object sender, EventArgs e)
        {
            ob = new GT900USBClass();
        }

        private void btnSystemCLose_Click(object sender, EventArgs e)
        {
            txtResultCloseDevice.Text = string.Empty;
            ob.ClearError();
            ob.SystemClose();
            int err = ob.GetError();
            txtResultCloseDevice.Text = $@"SystemClose()->{ob.GetErrorMessage(err)}";
        }

        private void btnBoardRevision_Click(object sender, EventArgs e)
        {
            txtErrorBoardRevision.Text = string.Empty;
            txtResultBoardRevision.Text = string.Empty;

            ob.ClearError();
            uint br = 0;
            bool ok = ob.GetBoardRevision(ref br);
            int err = ob.GetError();
            txtErrorBoardRevision.Text = br.ToString();
            txtResultBoardRevision.Text = $@"BoardRevision()->Done: {ok}->{ob.GetErrorMessage(err)}";
        }

       

        private void ckDebugmode_CheckedChanged(object sender, EventArgs e)
        {
            SetDefaultUI();
        }

        private void SetDefaultUI()
        {
            ID.Visible          = ckDebugmode.Checked;
            INFO.Visible        = ckDebugmode.Checked;
            outdefID.Visible    = ckDebugmode.Checked;
            tabControlMeasurements.TabPages.Remove(tabPageCounterTesting);
            if (ckDebugmode.Checked)
            {
                tabControlMeasurements.TabPages.Add(tabPageCounterTesting);
            }
        }

        private void ckChannel1_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged();
        }
        private void CheckedChanged()
        {
            if(ckChannel0.Checked)
            {
                txtNumTags0.Enabled = true;
                txtMeasSkipCh0.Enabled = true;
                txtThresholdA.Enabled = true;
                cbPrescaleA.Enabled = true;
            }
            else
            {
                txtNumTags0.Enabled = false;
                txtMeasSkipCh0.Enabled = false;
                txtThresholdA.Enabled = false;
                cbPrescaleA.Enabled = false;
            }

            if (ckChannel1.Checked)
            {
                txtNumTags1.Enabled = true;
                txtMeasSkipCh1.Enabled = true;
                txtThresholdB.Enabled = true;
                cbPrescaleB.Enabled = true;
            }
            else
            {
                txtNumTags1.Enabled = false;
                txtMeasSkipCh1.Enabled = false;
                txtThresholdB.Enabled = false;
                cbPrescaleB.Enabled = false;
            }
        }

        private void ckChannel0_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged();
        }

        private DataRow RbToDatasource(DataRow row)
        {
            if (rbResultLiteDB.Checked)
            {
                row["outdefDATASOURCE"] = EnumHelper.GetDescription(eDatasource.liteDB);
            }
            else if (rbResultFile.Checked)
            {
                row["outdefDATASOURCE"] = EnumHelper.GetDescription(eDatasource.file);
            }
            else if (rbAVARFile.Checked)
            {
                row["outdefDATASOURCE"] = EnumHelper.GetDescription(eDatasource.AVARfile);
            }
            else if (rbTimeAnalyzerFile.Checked)
            {
                row["outdefDATASOURCE"] = EnumHelper.GetDescription(eDatasource.timeAnalyzerFile);
            }
            return row;
        }

        private void hsAddMeasResultDefinition_Click(object sender, EventArgs e)
        {
            var row = dsOutputDefintion.Tables[0].NewRow();
            row["outdefID"]     = Guid.NewGuid();
            row["outdefACTIVE"] = (object)true;
            row["outdefFORMAT"] = txtMeasResultDefinitionFormat.Text;
            row["outdefPATH"]   = txtMeasResultDefinitionPath.Text;
            row["outdefFILEPATTERN"]   = txtMeasResultDefinitionFilePattern.Text;
            RbToDatasource(row);

            dsOutputDefintion.Tables[0].Rows.Add(row);
        }

        private void hsRemoveMeasResultDefinition_Click(object sender, EventArgs e)
        {
            if (bsOutputDefinition.Current == null) return;
            if (MessageBox.Show("Delete resultfile configuration", "Do you really want to delete this entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DataRowView ob = (DataRowView)bsOutputDefinition.Current;
                ob.Row.Delete();
            }
        }

        private void rbUseClock_CheckedChanged(object sender, EventArgs e)
        {
            if(rbClockUseExtern.Checked)
            {
                rbClock10MHZ.Enabled = true;
                rbClock5MHZ.Enabled = true;
            }
            else if (rbUseInternClock.Checked)
            {
                rbClock10MHZ.Enabled = false;
                rbClock5MHZ.Enabled = false;
            }
        }

        private void btnRunDirect_Click(object sender, EventArgs e)
        {
            INFO.Visible = ckDebugmode.Checked;
            var mcc = GetMeasurementConfigFromUI();

            mc = new MeasurementClass(mcc,false);
            mc.rd = PrepareOutput();
            mc.nf.Register4Info(InfoRaised);
            mc.nf.Register4Error(ErrorRaised);
            mc.RunDirect();
        }

        MeasurementConfigClass actMeasConfiguration = null;
        private void hsLoadConfigurationFile_Click(object sender, EventArgs e)
        {
            if(ofdLoadConfiguration.ShowDialog() == DialogResult.OK)
            {
                MeasurementConfigClass mcc = new MeasurementConfigClass();
                mcc.Deserialize($@"{ofdLoadConfiguration.FileName}");
                MeasurementConfigToUI(mcc);
                txtConfigurationFile.Text = mcc.XMLName;
                actMeasConfiguration = mcc;
            }
        }

        private void SetColorErr(Control ctrl)
        {
            ctrl.BackColor = Color.Salmon;
        }

        private void SetColorOk(Control ctrl)
        {
            ctrl.BackColor = Color.White;
        }

        private bool MeasConfigUI_OK()
        {
            bool ok = false;
            if(txtMeasname.Text.Length > 0)
            {
                ok = true;
            }
            else
            {
                SetColorErr(txtMeasname);
            }
            return ok;
        }

        private void hsSaveMeasconfiguration_Click(object sender, EventArgs e)
        {
            if (MeasConfigUI_OK())
            {
                var mcc = GetMeasurementConfigFromUI();
                FileInfo fi = new FileInfo(mcc.XMLName);
                DirectoryInfo di = new DirectoryInfo(fi.DirectoryName);
                if (di.Exists) sfdMeasconfiguration.InitialDirectory = di.FullName;
                sfdMeasconfiguration.FileName = fi.Name;
                if (sfdMeasconfiguration.ShowDialog() == DialogResult.OK)
                {
                    mcc.XMLName = sfdMeasconfiguration.FileName;
                    mcc.SerializeCurrent();
                    actMeasConfiguration = mcc;
                    txtConfigurationFile.Text = actMeasConfiguration.XMLName;
                }
            }
            else
            {
                MessageBox.Show("Check marked fields, needed content !!!","Error Measconfig");
            }
        }

        private void txtMeasname_TextChanged(object sender, EventArgs e)
        {
            SetColorOk((Control)sender);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (actMeasConfiguration != null)
            {
                if (File.Exists(actMeasConfiguration.XMLName))
                {
                    ConfigClass.Instance().LastMeasurementConfigFile = actMeasConfiguration.XMLName;
                }
                ConfigClass.Instance().SerializeCurrent();
            }
        }
 
        private void hsSaveLogs_Click(object sender, EventArgs e)
        {
            if (sfdLogs.ShowDialog() == DialogResult.OK)
            {
                bool upd = cbResultLogActive.Checked;
                cbResultLogActive.Checked = false;
                rtResultLogs.SaveFile(sfdLogs.FileName);
                cbResultLogActive.Checked = upd;
            }
        }

        private void hsSetPhase_A_B_Click(object sender, EventArgs e)
        {
            actMeasConfiguration.CreateDefaultConfig_Phase_A_B();
            MeasurementConfigToUI(actMeasConfiguration);
        }

        private void hsSetFrequencyMeasurment_A_Click(object sender, EventArgs e)
        {
            actMeasConfiguration.CreateDefaultConfig_Frequency_A();
            MeasurementConfigToUI(actMeasConfiguration);
        }

        private void hs_SetFrequency_A_B_Click(object sender, EventArgs e)
        {
            actMeasConfiguration.CreateDefaultConfig_Frequency_A_B();
            MeasurementConfigToUI(actMeasConfiguration);
        }

        private void hsRun_Click_1(object sender, EventArgs e)
        {
            INFO.Visible = ckDebugmode.Checked;
            rtResultsErrorLog.Clear();
            rtResultLogs.Clear();
            dsResults.Tables[0].Rows.Clear();
            actMeasConfiguration = GetMeasurementConfigFromUI();
            mc = new MeasurementClass(actMeasConfiguration,true);
            mc.rd = PrepareOutput();
            mc.nf.Register4Info(InfoRaised);
            mc.nf.Register4Error(ErrorRaised);
            mc.Run();            
        }

        private void hsStop_Click(object sender, EventArgs e)
        {
            mc.Stop();
            Application.DoEvents();
        }

        private void hsSaveErrorLogs_Click(object sender, EventArgs e)
        {
            if (sfdLogs.ShowDialog() == DialogResult.OK)
            {
                bool upd = cbResultLogActive.Checked;
                cbUpdateErrorLogEveryNewEntry.Checked = false;
                rtResultsErrorLog.SaveFile(sfdLogs.FileName);
                cbUpdateErrorLogEveryNewEntry.Checked = upd;
            }
        }

        private void TestFreq()
        {
            MeasurementClass mc = new MeasurementClass(actMeasConfiguration,false);

            mc.TestSignals(ob, 10000000);
        }


        private void hsTestFrequency_Click(object sender, EventArgs e)
        {
            TestFreq();
        }

        private void hsRunGraph_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                FileInfo fi = (FileInfo) dataGridView1.SelectedRows[0].Tag;
                ShowGraph(fi);
                RedirectConsoleToDefault();
            }
        }
        private void hsRefreshFiles_Click(object sender, EventArgs e)
        {
            RefreshAllFiles();
        }
        private void RefreshFiles()
        {
            if (actMeasConfiguration == null) return;
            
            foreach (ResultDefinition rd in actMeasConfiguration.ResultDefinitions)
            {
                if (rd.DataSource == eDatasource.file)
                {
                    txtFilesPath.Text = rd.Path;
                }
            }
            RefreshAllFiles();
            
        }

        private void RefreshAllFiles()
        {
            if (actMeasConfiguration == null) return;
            string fn = txtFilesPath.Text;
            
            DirectoryInfo di = new DirectoryInfo(fn);
            if (di.Exists)
            {
                FileInfo[] files = di.GetFiles();
                gbFileInfos.Text = $@"Files ({files.Length})";
                dataGridView1.Rows.Clear();
                foreach (FileInfo fi in files)
                {
                    int i = dataGridView1.Rows.Add(new object[] { fi.Name, fi.CreationTime, fi.Length });
                    dataGridView1.Rows[i].Tag = fi;
                }
                dataGridView1.Sort(colFileCreate, ListSortDirection.Descending);
            }
        }

        private void txtMeasResultDefinitionPath_TextChanged(object sender, EventArgs e)
        {
            txtFilesPath.Text = txtMeasResultDefinitionPath.Text;
        }

        private void hsOutlier9_Click(object sender, EventArgs e)
        {
            txtOutliers.Text = "1E-9";
        }

        private void hsOutliers6_Click(object sender, EventArgs e)
        {
            txtOutliers.Text = "1E-6";
        }

        private void hsOutliers3_Click(object sender, EventArgs e)
        {
            txtOutliers.Text = "1E-3";
        }

        private void hotSpot1_Click(object sender, EventArgs e)
        {
            txtOutliers.Text = "0";
        }

        private void tabControlMeasurements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlMeasurements.SelectedTab == tabPageMeasFiles)
            {
                RefreshFiles();
            }
            if(tabControlMeasurements.SelectedTab == tabPageAppConfiguration)
            {
                xmlEditSimpleUserControl1.LoadXmlFromFile($@"{Application.StartupPath}\config\PRCCounterAppConfig.xml");
            }
        }

        private void txtFilesPath_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void hotSpot2_Click(object sender, EventArgs e)
        {
            if(fbdResultFiles.ShowDialog() == DialogResult.OK)
            {
                txtFilesPath.Text = fbdResultFiles.SelectedPath;
                RefreshAllFiles();
            }
        }

        private void pbMeastype_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPhaseAB.Checked)
            {
                txtGraphLegend.Text = EnumHelper.GetDescription(eMeasType.pps_a_b);
            }
            else if (rbFrequency_A_B.Checked)
            {
                txtGraphLegend.Text = EnumHelper.GetDescription(eMeasType.freq_a_b);
            }
            else if (rbFrequencyA.Checked)
            {
                txtGraphLegend.Text = EnumHelper.GetDescription(eMeasType.freq_a);
            }
        }

        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Tag != null)
                {
                    FileInfo fi = (FileInfo)dataGridView1.SelectedRows[0].Tag;
                    
                    rtbDataFile.Clear();
                    try
                    {
                        if (fi.Length > 10000)
                        {
                            StreamReader sr = new StreamReader(fi.FullName);
                            string myLine;
                            int count_lines = 0;
                            int max_lines = 1000;

                            while (((myLine = sr.ReadLine()) != null) && (count_lines < max_lines))
                            {
                                rtbDataFile.AppendText(myLine + "\n");
                                count_lines++;

                            }
                        }
                        else
                        {
                            rtbDataFile.LoadFile(fi.FullName, RichTextBoxStreamType.PlainText);
                        }
                    }
                    catch(Exception ex)
                    {
                        rtbDataFile.AppendText(ex.Message + "\n");
                    }
                    //rtbDataFile.LoadFile(fi.FullName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void hsUpdateMeasResultDefinition_Click(object sender, EventArgs e)
        {
            DataRowView ob = (DataRowView)bsOutputDefinition.Current;
            if (ob != null)
            {
                ob.Row["outdefPATH"] = txtMeasResultDefinitionPath.Text;
                ob.Row["outdefFILEPATTERN"] = txtMeasResultDefinitionFilePattern.Text;
                ob.Row["outdefFORMAT"] = txtMeasResultDefinitionFormat.Text;
                ob.Row["outdefACTIVE"] = (object) ckMeasResultDefinitionActive.Checked;
                RbToDatasource(ob.Row);
            }
        }

        private void txtConfigurationFile_TextChanged(object sender, EventArgs e)
        {
            txtActConfigurationFile.Text = txtConfigurationFile.Text;
        }

        private void hsShowGraphStatistik_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                FileInfo fi = (FileInfo)dataGridView1.SelectedRows[0].Tag;
                ShowStatistikGraph(fi);
                RedirectConsoleToDefault();
            }
        }
    }
}
