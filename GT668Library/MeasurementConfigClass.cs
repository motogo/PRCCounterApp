
using Enums;
using MessageFormLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace GT668Library
{
    public enum eDatasource 
    {
        [EnumDescription("Textfile")]
        file =0,
        [EnumDescription("Database LiteDB")]
        liteDB =1,
        [EnumDescription("AVAR File")]
        AVARfile = 2,
        [EnumDescription("Time Analyzer File")]
        timeAnalyzerFile = 3
    }
    [Serializable]
    public enum eMeasDevice
    {
        [EnumDescription("GT900IP-USB3")]
        GT900IP_USB3 = 0,
        [EnumDescription("GT668")]
        GT668 = 1,
        [EnumDescription("Other")]
        Other = 9
    }
    [Serializable]
    public class ResultDefinition
    {
        [XmlElement("Path")]
        public string Path = string.Empty;
        [XmlElement("FilePattern")]
        public string FilePattern = string.Empty;
        [XmlElement("DataFormat")]
        public string DataFormat = string.Empty;
        [XmlElement("DataSource")]
        public eDatasource DataSource = eDatasource.file;
        [XmlElement("Active")]
        public bool Active = false;
    }


    public enum eMeasType 
    {
        [EnumDescription("pps A-B")]
        pps_a_b =0,
        [EnumDescription("frequency B")]
        freq_a =1,
        [EnumDescription("freq phase A-B")]
        freq_a_b =2
    }
    public enum eClockFreq {Mhz5,Mhz10};

    [Serializable]
    public class MeasurementConfigClass
    {
        private string MainPfad = System.Environment.CurrentDirectory;
        public string XMLName;

        [XmlElement("MeasurmentDevice")]
        public eMeasDevice measDevice;

        [XmlElement("MeasurmentAPI")]
        public string measAPI;

        [XmlElement("MeasurmentName")]
        public string measName;
        [XmlElement("MeasurmentInfo")]
        public string measInfo;
        [XmlElement("Timestamp")]
        public DateTime stamp;

        [XmlElement("Meastype")]
        public eMeasType measType = eMeasType.pps_a_b;
        [XmlElement("BoardNumber")]
        public int board = 0;
        [XmlElement("SleepAfterSingleMeasurment")]
        public int sleepAfterSingleMeasurement = 850;
        public int sleepAfterSingleRead = 5;
        public int loops;
        public bool enableChannel0 = true;
        public bool enableChannel1 = true;
        public uint numTag0 = 1;
        public uint numTag1 = 1;
        public bool doCalibration;
        public double inputThresholdA = 0.5;
        public double inputThresholdB = 0.5;
        public double clockThreshold = 0.5;
        public GT668Class.GtiThrMode inputThresholdModeA = GT668Class.GtiThrMode.GT_THR_VOLTS;
        public GT668Class.GtiThrMode inputThresholdModeB = GT668Class.GtiThrMode.GT_THR_VOLTS;
        public GT668Class.GtiThrMode clockThresholdMode = GT668Class.GtiThrMode.GT_THR_VOLTS;
        public uint measSkipChannel0 = 1;
        public uint measSkipChannel1 = 1;
        public uint measGateChannel0 = 1;
        public uint measGateChannel1 = 1;
        public GT668Class.GtiCoupling inputCouplingA = GT668Class.GtiCoupling.GT_CPL_DC;
        public GT668Class.GtiCoupling inputCouplingB = GT668Class.GtiCoupling.GT_CPL_DC;
        public GT668Class.GtiImpedance inputImpendanceA = GT668Class.GtiImpedance.GT_IMP_LO; //50 Ohm
        public GT668Class.GtiImpedance inputImpendanceB = GT668Class.GtiImpedance.GT_IMP_LO; //50 Ohm
        public GT668Class.GtiRefClkSrc referenceClock = GT668Class.GtiRefClkSrc.GT_REF_EXTERNAL;
        public eClockFreq clockFrequenz = eClockFreq.Mhz10;
        public GT668Class.GtiPrescale prescaleA = GT668Class.GtiPrescale.GT_DIV_1024;
        public GT668Class.GtiPrescale prescaleB = GT668Class.GtiPrescale.GT_DIV_1024;
        public GT668Class.GtiInputSel inputChannel0Signal = GT668Class.GtiInputSel.GT_CHA_POS;
        public GT668Class.GtiInputSel inputChannel1Signal = GT668Class.GtiInputSel.GT_CHB_POS;
        public bool memoryWrap = true;
        public double userDefinedYOffset = 0.0;

        public bool showAllErrors = false;
        public bool showResults = true;
        public bool restartMeasurementAfterLoop = false;

        public string YLegendName = "Y";
        public string XLegendName = "Y";
        public string GraphLegendName = "graph";
        public int ScaleYAxis = 9;  //z.b. für ns

        [XmlElement("ResultDefinitions")]
        public List<ResultDefinition> ResultDefinitions = new List<ResultDefinition>();


        private bool loadOK = false;

        private static readonly object _lock_this = new object();
        static private volatile MeasurementConfigClass instance = null;
        static public MeasurementConfigClass Instance()
        {

            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new MeasurementConfigClass();
                }
            }

            return (instance);
        }



        public string GetAppBegriff(string Path)
        {

            string newPath;
            if (Path != null)
            {
                newPath = Path;
                if (newPath.IndexOf(Application.StartupPath.TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Application.StartupPath.TrimEnd('\\'), "[ApplicationPath]");

                if (newPath.IndexOf(Application.UserAppDataPath.TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Application.UserAppDataPath.TrimEnd('\\'), "[UserAppDataPath]");

                if (newPath.IndexOf(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd('\\'), "[UserApplicationData]");

                if (newPath.IndexOf(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).TrimEnd('\\'), "[CommonApplicationData]");

                if (newPath.IndexOf(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86).TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86).TrimEnd('\\'), "[CommonFilesPath]");

                if (newPath.IndexOf(Environment.GetEnvironmentVariable("temp").TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetEnvironmentVariable("temp").TrimEnd('\\'), "[LocalTempPath]");

                if (newPath.IndexOf(Environment.GetEnvironmentVariable("temp", EnvironmentVariableTarget.Machine).TrimEnd('\\')) >= 0)
                    newPath = newPath.Replace(Environment.GetEnvironmentVariable("temp", EnvironmentVariableTarget.Machine).TrimEnd('\\'), "[WinTempPath]");

                return (newPath);
            }
            else return (null);

        }

        public string GetPath(string orgPath)
        {
            //   if (string.IsNullOrEmpty(orgPath)) return "none";
            if (string.IsNullOrEmpty(orgPath)) return "";

            string newpath = orgPath;

            if (newpath.IndexOf("[ProgramFilesFolder]") >= 0)
                newpath = newpath.Replace("[ProgramFilesFolder]", Application.StartupPath.TrimEnd('\\'));
            if (newpath.IndexOf("[ApplicationPath]") >= 0)
                newpath = newpath.Replace("[ApplicationPath]", Application.StartupPath.TrimEnd('\\'));
            if (newpath.IndexOf("[UserAppDataPath]") >= 0)
                newpath = newpath.Replace("[UserAppDataPath]", Application.UserAppDataPath.TrimEnd('\\'));
            if (newpath.IndexOf("[WinTempPath]") >= 0)
                newpath = newpath.Replace("[WinTempPath]", Environment.GetEnvironmentVariable("temp", EnvironmentVariableTarget.Machine).TrimEnd('\\'));
            if (newpath.IndexOf("[LocalTempPath]") >= 0)
                newpath = newpath.Replace("[LocalTempPath]", Environment.GetEnvironmentVariable("temp").TrimEnd('\\'));
            if (newpath.IndexOf("[CommonApplicationData]") >= 0)
                newpath = newpath.Replace("[CommonApplicationData]", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData).TrimEnd('\\'));
            if (newpath.IndexOf("[UserApplicationData]") >= 0)
                newpath = newpath.Replace("[UserApplicationData]", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).TrimEnd('\\'));

            if (newpath.IndexOf("[CommonFilesPath]") >= 0)
                newpath = newpath.Replace("[CommonFilesPath]", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86).TrimEnd('\\'));

            ;

            return (newpath);
        }

        public bool Deserialize(string FileName)
        {
            bool ok;
            XmlReader reader;
            try
            {
                this.XMLName = FileName;
                XmlSerializer serializer = new XmlSerializer(typeof(MeasurementConfigClass));
                Stream fs = new FileStream(FileName, FileMode.Open);
                reader = new XmlTextReader(fs);
                var PF = (MeasurementConfigClass)serializer.Deserialize(reader);
                reader.Close();

                this.measName   = PF.measName;
                this.measDevice = PF.measDevice;
                this.measAPI    = PF.measAPI;
                this.measInfo   = PF.measInfo;
                this.enableChannel0 = PF.enableChannel0;
                this.enableChannel1 = PF.enableChannel1;
                this.measGateChannel0 = PF.measGateChannel0;
                this.measGateChannel1 = PF.measGateChannel1;
                this.measSkipChannel0 = PF.measSkipChannel0;
                this.measSkipChannel1 = PF.measSkipChannel1;
                this.measType = PF.measType;
                this.memoryWrap = PF.memoryWrap;
                this.numTag0 = PF.numTag0;
                this.numTag1 = PF.numTag1;
                this.prescaleA = PF.prescaleA;
                this.prescaleB = PF.prescaleB;
                this.referenceClock = PF.referenceClock;
                this.restartMeasurementAfterLoop = PF.restartMeasurementAfterLoop;
                this.showAllErrors = PF.showAllErrors;
                this.showResults = PF.showResults;
                this.sleepAfterSingleMeasurement = PF.sleepAfterSingleMeasurement;
                this.sleepAfterSingleRead = PF.sleepAfterSingleRead;
                this.userDefinedYOffset = PF.userDefinedYOffset;
                this.YLegendName = PF.YLegendName;
                this.XLegendName = PF.XLegendName;
                this.GraphLegendName = PF.GraphLegendName;
                this.ScaleYAxis      = PF.ScaleYAxis;
                this.stamp = PF.stamp;
                this.ResultDefinitions = new List<ResultDefinition>();
                for (int i = 0; i < PF.ResultDefinitions.Count; i++)
                {
                    var rd = new ResultDefinition();
                    rd.Path             = GetPath(PF.ResultDefinitions[i].Path);
                    rd.DataFormat       = PF.ResultDefinitions[i].DataFormat.Replace("%", "<").Replace("*", ">");
                    rd.Active           = PF.ResultDefinitions[i].Active;
                    rd.FilePattern      = PF.ResultDefinitions[i].FilePattern;
                    rd.DataSource       = PF.ResultDefinitions[i].DataSource;
                    this.ResultDefinitions.Add(rd);
                }

                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
                loadOK = ok;
                
                SEMessageBox.ShowDialog("#Konfiguration der Anwendung konnte nicht geladen werden.", $@"#{ex.Message}",  SEMessageBoxIcon.Exclamation, SEMessageBoxButtons.OK);

                return (ok);

            }
            finally
            {

            }
            loadOK = ok;
            return (ok);
        }

        public void SerializeCurrent()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MeasurementConfigClass));
            XmlQualifiedName q1 = new XmlQualifiedName("", "");
            XmlQualifiedName[] names = { q1 };
            XmlSerializerNamespaces test = new XmlSerializerNamespaces(names);
            Stream writer = new FileStream(this.XMLName, FileMode.Create);

            for (int i = 0; i < this.ResultDefinitions.Count; i++)
            {
                this.ResultDefinitions[i].Path = GetAppBegriff(this.ResultDefinitions[i].Path);
            }
            
            serializer.Serialize(writer, this, test);
            writer.Close();
        }

        public void CreateDefaultConfig_Frequency_A()
        {        
            this.measName = "Default config done by application";
            this.measInfo = "Frequency measurment channel A";
            this.measType = eMeasType.freq_a;
            this.GraphLegendName = EnumHelper.GetDescription(this.measType);
            this.YLegendName = "frequency (Mhz)";
            this.XLegendName = "timestamp (s)";
            this.board = 0;
            this.memoryWrap = false;
            this.sleepAfterSingleMeasurement = 850;
            this.sleepAfterSingleRead = 5;
            this.loops = 0;
            this.stamp = DateTime.Now;
            this.numTag0 = 2U;
            this.numTag1 = 0U;
            this.enableChannel0 = true;
            this.enableChannel1 = false;
            this.doCalibration = false;
            this.inputChannel0Signal = GT668Class.GtiInputSel.GT_CHA_POS;
            this.inputChannel1Signal = GT668Class.GtiInputSel.GT_CHB_POS;

            this.prescaleA = GT668Class.GtiPrescale.GT_DIV_16; // or DIV_4 when skipchannel == 2499
            this.prescaleB = GT668Class.GtiPrescale.GT_DIV_AUTO;
            this.measSkipChannel0 = 624; // or 2499 when prescaleA == DIV_4
            this.measSkipChannel1 = 0U;

            /*
            this.prescaleA = GT668Class.GtiPrescale.GT_DIV_4;
            this.prescaleB = GT668Class.GtiPrescale.GT_DIV_AUTO;
            this.measSkipChannel0 = 2499;
            this.measSkipChannel1 = 0U;
            */

            this.inputThresholdA = 0.7;
            this.inputThresholdB = 0.7;
            this.clockThreshold = 0.7;
            this.inputThresholdModeA = GT668Class.GtiThrMode.GT_THR_VOLTS;
            this.inputThresholdModeB = GT668Class.GtiThrMode.GT_THR_VOLTS;
            this.clockThresholdMode = GT668Class.GtiThrMode.GT_THR_VOLTS;
            this.inputCouplingA = GT668Class.GtiCoupling.GT_CPL_AC;
            this.inputCouplingB = GT668Class.GtiCoupling.GT_CPL_AC;
            this.referenceClock = GT668Class.GtiRefClkSrc.GT_REF_EXTERNAL;
            this.clockFrequenz = eClockFreq.Mhz10;
            this.inputImpendanceA = GT668Class.GtiImpedance.GT_IMP_LO;
            this.inputImpendanceB = GT668Class.GtiImpedance.GT_IMP_LO;
            this.showAllErrors = false;
            this.showResults = true;
            this.restartMeasurementAfterLoop = false;

            this.userDefinedYOffset = 0;

            this.ResultDefinitions.Clear();

            ResultDefinition rs = new ResultDefinition();
            rs.DataFormat = "<datastamp>,<value>;";
            rs.Path = $@"{Application.StartupPath}\Results\";
            rs.FilePattern = $@"AutogeneratedResultFile_<ticks>.dat";
            rs.Active = true;
            rs.DataSource = eDatasource.file;

            this.ResultDefinitions.Add(rs);

            rs = new ResultDefinition();
            rs.DataFormat = "<datastamp,format=F3> <value>";
            rs.Path = $@"{Application.StartupPath}\Results\";
            rs.FilePattern = $@"AVARAutogeneratedResultFile_<ticks>.dat";
            rs.Active = true;
            rs.DataSource = eDatasource.AVARfile;

            this.ResultDefinitions.Add(rs);

            rs = new ResultDefinition();
            rs.DataFormat = "<datastamp> <value>";
            rs.Path = $@"{Application.StartupPath}\Results\";
            rs.FilePattern = $@"DBAutogeneratedResultFile_<ticks>.db";
            rs.Active = true;
            rs.DataSource = eDatasource.liteDB;

            this.ResultDefinitions.Add(rs);

            this.XMLName = $@"{Application.StartupPath}\Config\Frequency_A_Autogenerated_{StaticMeasFunctions.GetActDateTimeCnt()}.xml";

        }
        public void CreateDefaultConfig_Phase_A_B()
        {
            this.measName = "Default config done by application";
            this.measInfo = "Phase measurment channel A-B";
            this.measType = eMeasType.pps_a_b;
            this.GraphLegendName = EnumHelper.GetDescription(this.measType);
            this.YLegendName = "offset (ns)";
            this.XLegendName = "timestamp (s)";

            this.board = 0;
            this.memoryWrap = false;
            this.sleepAfterSingleMeasurement = 850; //ms
            this.sleepAfterSingleRead = 5; //ms
            this.loops = 0;
            this.stamp = DateTime.Now;
            this.numTag0 = 1U;
            this.numTag1 = 1U;
            this.enableChannel0 = true;
            this.enableChannel1 = true;
            this.doCalibration = false;
            this.inputChannel0Signal = GT668Class.GtiInputSel.GT_CHA_POS;
            this.inputChannel1Signal = GT668Class.GtiInputSel.GT_CHB_POS;
            this.measSkipChannel0 = 0U;
            this.measSkipChannel1 = 0U;
            this.inputThresholdA = 0.7;
            this.inputThresholdB = 0.7;
            this.clockThreshold = 0.7;
            this.inputThresholdModeA = GT668Class.GtiThrMode.GT_THR_VOLTS;
            this.inputThresholdModeB = GT668Class.GtiThrMode.GT_THR_VOLTS;
            this.clockThresholdMode = GT668Class.GtiThrMode.GT_THR_VOLTS;
            this.inputCouplingA = GT668Class.GtiCoupling.GT_CPL_DC;
            this.inputCouplingB = GT668Class.GtiCoupling.GT_CPL_DC;
            this.referenceClock = GT668Class.GtiRefClkSrc.GT_REF_EXTERNAL;
            this.clockFrequenz = eClockFreq.Mhz10;
            this.inputImpendanceA = GT668Class.GtiImpedance.GT_IMP_LO;
            this.inputImpendanceB = GT668Class.GtiImpedance.GT_IMP_LO;
            this.showAllErrors = false;
            this.showResults = true;
            this.restartMeasurementAfterLoop = false;
            this.userDefinedYOffset = 0;

            this.prescaleA = GT668Class.GtiPrescale.GT_DIV_AUTO;
            this.prescaleB = GT668Class.GtiPrescale.GT_DIV_AUTO;
            this.ResultDefinitions.Clear();

            ResultDefinition rs = new ResultDefinition();
            rs.DataFormat = "<datastamp>,<value>;";
            rs.Path = $@"{Application.StartupPath}\Results\";
            rs.FilePattern = $@"AutogeneratedResultFile_<ticks>.dat";
            rs.Active = true;
            rs.DataSource = eDatasource.file;
            this.ResultDefinitions.Add(rs);

            rs = new ResultDefinition();
            rs.DataFormat = "<datastamp,format=F3> <value>";
            rs.Path = $@"{Application.StartupPath}\Results\";
            rs.FilePattern = $@"AVARAutogeneratedResultFile_<ticks>.dat";
            rs.Active = true;
            rs.DataSource = eDatasource.AVARfile;

            this.ResultDefinitions.Add(rs);

            this.XMLName = $@"{Application.StartupPath}\Config\Phase_A_B_Autogenerated_{StaticMeasFunctions.GetActDateTimeCnt()}.xml";
        }
        public void CreateDefaultConfig_Frequency_A_B()
        {
            this.measName = "Default config done by application";
            this.measInfo = "Frequency measurment channel A-B";
            this.measType = eMeasType.freq_a_b;
            this.GraphLegendName = EnumHelper.GetDescription(this.measType);
            this.YLegendName = "offset (ns)";
            this.XLegendName = "timestamp (s)";
            this.board = 0;
            this.memoryWrap = false;
            this.sleepAfterSingleMeasurement = 850; //ms
            this.sleepAfterSingleRead = 5; //ms
            this.loops = 0;
            this.stamp = DateTime.Now;
            this.numTag0 = 1U;
            this.numTag1 = 1U;
            this.enableChannel0 = true;
            this.enableChannel1 = true;
            this.doCalibration = false;
            this.inputChannel0Signal = GT668Class.GtiInputSel.GT_CHA_POS;
            this.inputChannel1Signal = GT668Class.GtiInputSel.GT_CHB_POS;
            this.prescaleA = GT668Class.GtiPrescale.GT_DIV_1;
            this.prescaleB = GT668Class.GtiPrescale.GT_DIV_1;
            this.measSkipChannel0 = 2499; // 624
            this.measSkipChannel1 = 2499; // 624
            this.inputThresholdA = 0.7;
            this.inputThresholdB = 0.7;
            this.clockThreshold = 0.7;
            this.inputThresholdModeA = GT668Class.GtiThrMode.GT_THR_VOLTS;
            this.inputThresholdModeB = GT668Class.GtiThrMode.GT_THR_VOLTS;
            this.clockThresholdMode = GT668Class.GtiThrMode.GT_THR_VOLTS;
            this.inputCouplingA = GT668Class.GtiCoupling.GT_CPL_DC;
            this.inputCouplingB = GT668Class.GtiCoupling.GT_CPL_DC;
            this.referenceClock = GT668Class.GtiRefClkSrc.GT_REF_EXTERNAL;
            this.clockFrequenz = eClockFreq.Mhz10;
            this.inputImpendanceA = GT668Class.GtiImpedance.GT_IMP_LO;
            this.inputImpendanceB = GT668Class.GtiImpedance.GT_IMP_LO;
            this.showAllErrors = false;
            this.showResults = true;
            this.restartMeasurementAfterLoop = false;
            this.userDefinedYOffset = 0;

            this.ResultDefinitions.Clear();

            ResultDefinition rs = new ResultDefinition();
            rs.DataFormat = "<datastamp>,<value>;";
            rs.Path = $@"{Application.StartupPath}\Results\";
            rs.FilePattern = $@"AutogeneratedResultFile_<ticks>.dat";
            rs.Active = true;
            rs.DataSource = eDatasource.file;
            this.ResultDefinitions.Add(rs);

            rs = new ResultDefinition();
            rs.DataFormat = "<datastamp,format=F3> <value>";
            rs.Path = $@"{Application.StartupPath}\Results\";
            rs.FilePattern = $@"AVARAutogeneratedResultFile_<ticks>.dat";
            rs.Active = true;
            rs.DataSource = eDatasource.AVARfile;

            this.ResultDefinitions.Add(rs);

            this.XMLName = $@"{Application.StartupPath}\Config\Phase_A_B_Autogenerated_{StaticMeasFunctions.GetActDateTimeCnt()}.xml";
        }
    }
}
