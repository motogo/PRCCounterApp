using Initialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PRCCounterApp.Globales
{
    [Serializable]
    public class Startup : ApplicationPathClass
    {

        [XmlElement("LastMeasurmentConfigFile")]
        public string LastMeasurmentConfigFile = string.Empty;

        private bool loadOK = false;

        public bool Loaded
        {
            get
            {
                return loadOK;
            }
        }
        public Startup()
        {

        }
        private static readonly object _lock_this = new object();
        static private volatile Startup instance = null;
        static public Startup Instance()
        {

            if (instance == null)
            {
                lock (_lock_this)
                {
                    instance = new Startup();
                }
            }

            return (instance);
        }
        public List<object> TestParams()
        {
            List<object> testList = new List<object>();


            
            return testList;
        }
        public bool Deserialize(string FileName)
        {
            bool ok;
            XmlReader reader;
            try
            {
                this.XMLName = FileName;
                XmlSerializer serializer = new XmlSerializer(typeof(Startup));
                Stream fs = new FileStream(FileName, FileMode.Open);
                reader = new XmlTextReader(fs);
                Startup PF = (Startup)serializer.Deserialize(reader);
                reader.Close();

                
                this.LastMeasurmentConfigFile = GetPath(PF.LastMeasurmentConfigFile);
                
                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
                loadOK = ok;
                MessageBox.Show(ex.Message, "Statup Konfiguration der Anwendung konnte nicht geladen werden.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            XmlSerializer serializer = new XmlSerializer(typeof(Startup));
            XmlQualifiedName q1 = new XmlQualifiedName("", "");
            XmlQualifiedName[] names = { q1 };
            XmlSerializerNamespaces test = new XmlSerializerNamespaces(names);
            Stream writer = new FileStream(this.XMLName, FileMode.Create);


            this.LastMeasurmentConfigFile = GetAppBegriff(this.LastMeasurmentConfigFile);
           
            serializer.Serialize(writer, instance, test);
            writer.Close();
        }



        public void WriteDefaultConfig(string fn)
        {
            Startup cc = Startup.Instance();

            cc.LastMeasurmentConfigFile = "[ApplicationPath]\\Config\\" + Application.ProductName + "Startup.xml";

        }
    }
}
