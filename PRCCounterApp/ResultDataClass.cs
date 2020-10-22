using GT668Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuideTech
{
    

    public class ResultOutClass
    {
        public string ResultFile;
        public eDatasource DataSource= eDatasource.file;
        public TextWriter fl = null;
        public string format = "<timestamp>;<value>";
        public bool Active = false;
    }

    public class ReportDataClass
    {
        public string key;
        public string info;
        public object data;
        public ReportDataClass(string ky, string inf, object dt)
        {
            key = ky;
            info = inf;
            data = dt;
        }
        public ReportDataClass(string ky, string inf)
        {
            key = ky;
            info = inf;
        }
    }

    public class ResultDatas
    {
        public ResultDataClass Results=null;
        public List<ResultOutClass> ResultOut = new List<ResultOutClass>();
        
        public const string DataSplitter = "<";
        public const string EndSplitter = ">";
        public const string DataStampStr = "datastamp";
        public const string TimeStampStr = "timestamp";
        public const string ValueStr = "value";

        //public DBResultsClass dbResults;

        public ResultDatas()
        {

        }


        public void WriteData()
        {
            foreach (var rout in ResultOut)
            {
                string format = rout.format.ToLower();
                // format = "<datastamp>,<value>,<timestamp>;";
                /*
                 <timestamp>,<datastamp>,<value>;
                 */
                if (rout.DataSource == eDatasource.file)
                {
                    List<string> formatlist = new List<string>();
                    int val = format.IndexOf($@"{DataSplitter}{ValueStr}");
                    int ts = format.IndexOf($@"{DataSplitter}{TimeStampStr}");
                    int ds = format.IndexOf($@"{DataSplitter}{DataStampStr}");

                    string valsep = string.Empty;
                    string dssep = string.Empty;
                    string tssep = string.Empty;
                    string endsep = string.Empty;

                    string ln = string.Empty;
                    string str = $@"{Results.DATASTAMP.ToString("F3").Replace(",", ".")}";

                    if (val < 0)
                    {
                        // keine gültige formatangabe, standardformat wird gewählt
                        // <datastamp>,<value>;
                        ln = $@"{Results.DATASTAMP.ToString("F3").Replace(",", "."),-10:d},{Results.VALUE.ToString().Replace(",", ".")};";
                    }
                    else
                    {
                        int val2 = format.IndexOf(EndSplitter, val);
                        int val3 = format.IndexOf(DataSplitter, val2);
                        string valtmp = format.Substring(val, val2 - val + 1);
                        if (val3 > val2)
                        {
                            valsep = format.Substring(val2 + 1, val3 - val2 - 1);
                        }
                        formatlist.Add(valtmp);
                        string tstmp = string.Empty;
                        string dstmp = string.Empty;
                        bool tsok = false;
                        bool dsok = false;

                        if (ts >= 0)
                        {
                            // <value>
                            tsok = true;
                            int ts2 = format.IndexOf(EndSplitter, ts);
                            int ts3 = format.IndexOf(DataSplitter, ts2);
                            if (ts3 > ts2)
                            {
                                tssep = format.Substring(ts2 + 1, ts3 - ts2 - 1);
                            }

                            tstmp = format.Substring(ts, ts2 - ts + 1);
                            if (ts < val)
                            {
                                // <timestamp><value>
                                int inx = formatlist.FindIndex(x => x == valtmp);
                                formatlist.Insert(inx, tstmp);
                            }
                            else
                            {
                                // <value>,<timestamp>
                                int inx = formatlist.FindIndex(x => x == valtmp);
                                formatlist.Insert(inx + 1, tstmp);
                            }
                        }

                        if ((ds >= 0) && tsok)
                        {
                            int ds2 = format.IndexOf(EndSplitter, ds);
                            int ds3 = format.IndexOf(DataSplitter, ds2);
                            if (ds3 > ds2)
                            {
                                dssep = format.Substring(ds2 + 1, ds3 - ds2 - 1);
                            }
                            dstmp = format.Substring(ds, ds2 - ds + 1);

                            if (ts < val)
                            {
                                // <timestamp><value>
                                if (ds < ts)
                                {
                                    // <datastamp><timestamp><value>
                                    int inx = formatlist.FindIndex(x => x == tstmp);
                                    formatlist.Insert(inx, dstmp);
                                }
                                else if (ds < val)
                                {
                                    // <timestamp><datastamp><value>
                                    int inx = formatlist.FindIndex(x => x == valtmp);
                                    formatlist.Insert(inx, dstmp);
                                }
                                else
                                {
                                    // <timestamp><value><datastamp>
                                    int inx = formatlist.FindIndex(x => x == valtmp);
                                    formatlist.Insert(inx + 1, dstmp);
                                }
                            }
                            else
                            {
                                //<value><timestamp>
                                if (ds < val)
                                {
                                    //<datastamp><value><timestamp>
                                    int inx = formatlist.FindIndex(x => x == valtmp);
                                    formatlist.Insert(inx, dstmp);
                                }
                                else if (ds < ts)
                                {
                                    //<value><datastamp><timestamp>
                                    int inx = formatlist.FindIndex(x => x == valtmp);
                                    formatlist.Insert(inx + 1, dstmp);
                                }
                            }
                        }
                        else if (ds >= 0)
                        {
                            //value + datastamp kein timestamp
                            int ds2 = format.IndexOf(EndSplitter, ds);
                            int ds3 = format.IndexOf(DataSplitter, ds2);
                            if (ds3 > ds2)
                            {
                                dssep = format.Substring(ds2 + 1, ds3 - ds2 - 1);
                            }
                            dstmp = format.Substring(ds, ds2 - ds + 1);
                            if (ds < val)
                            {
                                // <timestamp><value>
                                int inx = formatlist.FindIndex(x => x == valtmp);
                                formatlist.Insert(inx, dstmp);
                            }
                            else
                            {
                                // <value>,<timestamp>
                                int inx = formatlist.FindIndex(x => x == valtmp);
                                formatlist.Insert(inx + 1, dstmp);
                            }
                        }
                    }

                    if (val < 0)
                    {
                        ln = $@"{Results.DATASTAMP.ToString("F3").Replace(",", ".")},{Results.VALUE.ToString().Replace(",", ".")};";
                    }
                    else
                    {
                        foreach (var itm in formatlist)
                        {
                            if (itm.StartsWith($@"{DataSplitter}{ValueStr}"))
                            {
                                ln += $@"{Results.VALUE.ToString().Replace(",", ".")}{valsep}";
                            }
                            else if (itm.StartsWith($@"{DataSplitter}{DataStampStr}"))
                            {
                                if (itm.Length > DataSplitter.Length + DataStampStr.Length + EndSplitter.Length)
                                {
                                    string fi = itm.Substring(DataSplitter.Length + DataStampStr.Length + 1).Trim();
                                    fi = fi.Substring(0, fi.Length - EndSplitter.Length);
                                    string[] fiarr = fi.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                                    string fmt = string.Empty;
                                    foreach (var f in fiarr)
                                    {
                                        if (f.ToLower().StartsWith("format="))
                                        {
                                            fmt = f.Substring(7);
                                        }
                                    }
                                    ln += $@"{Results.DATASTAMP.ToString(fmt).Replace(",", ".")}{dssep}";
                                }
                                else
                                {
                                    ln += $@"{Results.DATASTAMP.ToString().Replace(",", ".")}{dssep}";
                                }
                            }
                            else if (itm.StartsWith($@"{DataSplitter}{TimeStampStr}"))
                            {
                                ln += $@"{Results.STAMP.ToString().Replace(",", ".")}{tssep}";
                            }
                        }
                        int lastinx = format.LastIndexOf(EndSplitter);
                        if (lastinx < format.Length)
                        {
                            endsep = format.Substring(lastinx + 1);
                            ln += $@"{endsep}";
                        }
                    }

                    if (rout.Active)
                    {
                        rout.fl.WriteLine(ln);
                        rout.fl.Flush();
                    }
                }
                else if(rout.DataSource == eDatasource.liteDB)
                {
                    DBResultsClass rd = new DBResultsClass();
                    rd.DatabasePath = rout.ResultFile;
                    rd.DBInsert(Results);
                }
            }
        }

        public void WriteAttributeData(string attribute)
        {
            foreach (var rout in ResultOut)
            {
                if (rout.DataSource == eDatasource.file)
                {                    
                    if (rout.Active)
                    {
                        if (attribute.Contains(Environment.NewLine))
                        {
                            rout.fl.Write(attribute);
                        }
                        else
                        {
                            rout.fl.WriteLine(attribute);
                        }
                        rout.fl.Flush();
                    }
                }
                else if (rout.DataSource == eDatasource.liteDB)
                {   
                    /*
                    DBResultsClass rd = new DBResultsClass();
                    rd.DatabasePath = rout.ResultFile;
                    rd.DBInsert(Results);
                    */
                }
            }
        }

        public void Close()
        {
            foreach (var rout in ResultOut)
            {
                if (rout.DataSource == eDatasource.file)
                {
                    rout.fl.Close();
                }
                else if (rout.DataSource == eDatasource.liteDB)
                {
                    //not nessecary
                }
            }
        }
    }
}