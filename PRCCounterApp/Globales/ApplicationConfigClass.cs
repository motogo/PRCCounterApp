using Enums;
using GT668Library;
using Initialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace GuideTech
{
    
    [Serializable]
    public class ConfigClass : ApplicationPathClass
    {
        [XmlElement("ResultDefinitions")]
        public List<ResultDefinition> ResultDefinitions = new List<ResultDefinition>();

        [XmlElement("DokuPath")]
        public string DokuPath = string.Empty;

        [XmlElement("DokuPort")]
        public int DokuPort = 8080;

        [XmlElement("TempPath")]
        public string TempPath = $@"[ApplicationPath]\Temp";

        [XmlElement("LogPath")]
        public string LogPath = $@"[ApplicationPath]\Log";

        [XmlElement("ScriptPath")]
        public string ScriptPath = $@"[ApplicationPath]\Scripts";

        [XmlElement("MessageConfigFile")]
        public string MessageConfigFile = string.Empty;

        [XmlElement("LastMeasurementConfigFile")]
        public string LastMeasurementConfigFile = string.Empty;

        private bool loadOK = false;

        public bool Loaded
        {
            get
            {
                return loadOK;
            }
        }
        public ConfigClass()
        {

        }
        private static readonly object _lock_this = new object();
        static private volatile ConfigClass instance = null;
        static public ConfigClass Instance()
        {
            
            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new ConfigClass();
                }
            }
            
            return (instance);
        }
        public List<object> TestParams()
        {
            List<object> testList = new List<object>();
            
            
            if (!this.DokuPath.ToUpper().StartsWith("HTTP:"))
            {
                if (!Directory.Exists(this.DokuPath)) testList.Add("DokuPath " + this.DokuPath + " existiert nicht.");
            }
            return testList;
        }
        public bool Deserialize(string FileName)
        {
            bool ok;
            XmlReader reader;
            try
            {
                if (File.Exists(FileName))
                {
                    this.XMLName = FileName;
                    XmlSerializer serializer = new XmlSerializer(typeof(ConfigClass));
                    Stream fs = new FileStream(FileName, FileMode.Open);
                    reader = new XmlTextReader(fs);
                    ConfigClass PF = (ConfigClass)serializer.Deserialize(reader);
                    reader.Close();

                    this.ResultDefinitions = PF.ResultDefinitions;
                    for (int i = 0; i < PF.ResultDefinitions.Count; i++)
                    {
                        this.ResultDefinitions[i].Path = GetPath(PF.ResultDefinitions[i].Path);
                        this.ResultDefinitions[i].DataFormat = PF.ResultDefinitions[i].DataFormat.Replace("%", "<").Replace("*", ">");
                    }
                    this.DokuPath = GetPath(PF.DokuPath);
                    this.DokuPort = PF.DokuPort;
                    this.MessageConfigFile = GetPath(PF.MessageConfigFile);
                    this.LastMeasurementConfigFile = GetPath(PF.LastMeasurementConfigFile);
                    this.TempPath = GetPath(PF.TempPath);
                    this.LogPath = GetPath(PF.LogPath);
                    this.ScriptPath = GetPath(PF.ScriptPath);
                    ok = true;
                }
                else
                {
                    ok = false;
                    loadOK = ok;
                    MessageBox.Show($@"File {FileName} existiert nicht.","Konfiguration laden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return (ok);
                }
            }
            catch (Exception ex)
            {
                ok = false;
                loadOK = ok;
                MessageBox.Show(ex.Message, $@"Konfiguration {FileName} konnte nicht geladen werden.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            XmlSerializer serializer = new XmlSerializer(typeof(ConfigClass));
            XmlQualifiedName q1 = new XmlQualifiedName("", "");
            XmlQualifiedName[] names = { q1 };
            XmlSerializerNamespaces test = new XmlSerializerNamespaces(names);
            Stream writer = new FileStream(this.XMLName, FileMode.Create);

            for(int i = 0; i < this.ResultDefinitions.Count; i++)
            {
                this.ResultDefinitions[i].Path = GetAppBegriff(this.ResultDefinitions[i].Path);
            }

            this.DokuPath           = GetAppBegriff(this.DokuPath);
            this.MessageConfigFile  = GetAppBegriff(this.MessageConfigFile);
            this.LastMeasurementConfigFile = GetAppBegriff(this.LastMeasurementConfigFile);
            this.TempPath   = GetAppBegriff(this.TempPath);
            this.LogPath    = GetAppBegriff(this.LogPath);
            this.ScriptPath = GetAppBegriff(this.ScriptPath);
            serializer.Serialize(writer, instance, test);
            writer.Close();
        }

        

        public void WriteDefaultConfig(string fn)
        {
            ConfigClass cc = ConfigClass.Instance();
            cc.DokuPath = "[ApplicationPath]\\Dokumentation\\DokuWikiStick\\";
            cc.DokuPort = 8080;
            cc.MainPfad = Application.StartupPath;
            cc.MessageConfigFile = "[ApplicationPath]\\Config\\" + Application.ProductName + "Config.xml";
        
            ResultDefinition itm = new ResultDefinition();
            itm.DataFormat = "<DATASTAMP>,<VALUE>;";
            itm.Path = "[ApplicationPath]\\Config\\MeasConfig\\";
            itm.FilePattern = "Results";
            itm.DataSource = eDatasource.file;
            cc.ResultDefinitions.Clear();
            cc.ResultDefinitions.Add(itm);
        }
    }
}