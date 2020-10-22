using LiteDB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GT668Library
{

    public class DBResultsClass
    {
        public static string Schema = "resultdatas";
        public MemoryStream ActMemoryStream;
        public string DatabasePath = $@"{Application.StartupPath}\data\MyData.db";
        public List<ResultDataClass> GetByID(Guid key)
        {
            var list = new List<ResultDataClass>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<ResultDataClass>(Schema);
                foreach (ResultDataClass _id in col.Find(x => x.ID == key))
                {
                    list.Add(_id);
                }
            }
            return list;
        }
        public List<ResultDataClass> GetAll()
        {
            var list = new List<ResultDataClass>();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<ResultDataClass>(Schema);
                foreach (ResultDataClass _id in col.FindAll())
                {
                    list.Add(_id);
                }
            }
            return list;
        }

        public ResultDataClass GetFirst(string key)
        {
            var list = new ResultDataClass();
            using (var db = new LiteDatabase(DatabasePath))
            {
                var col = db.GetCollection<ResultDataClass>(Schema);
                if (string.IsNullOrEmpty(key))
                {
                    foreach (ResultDataClass _id in col.FindAll())
                    {
                        list = _id;
                    }
                }
                else
                {
                    foreach (ResultDataClass _id in col.Find(x => x.MEASNAME == key))
                    {
                        list = _id;
                    }
                }
            }
            return list;
        }

        public bool DBInsert(ResultDataClass datas)
        {
            string connectionStr = DatabasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<ResultDataClass>(Schema);

                    notes.EnsureIndex(x => x.DATASTAMP);
                    notes.EnsureIndex(x => x.STAMP);

                    // Insert (Id will be auto-incremented)
                    datas.ID = Guid.Empty;
                    BsonValue bv = notes.Insert(datas);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public bool DBDelete(ResultDataClass datas)
        {
            string connectionStr = DatabasePath;
            try
            {
                using (var db = new LiteDatabase(connectionStr))
                {
                    // Get customer collection
                    var notes = db.GetCollection<ResultDataClass>(Schema);

                    notes.Delete(datas.ID);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public bool DBUpdate(ResultDataClass datas)
        {
            var lf = Application.StartupPath;
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                var notes = db.GetCollection<ResultDataClass>(Schema);
                notes.EnsureIndex(x => x.DATASTAMP);
                notes.EnsureIndex(x => x.STAMP);
                notes.Update(datas);
                /*
                foreach (var imagePath in datas.SongFiles)
                {
                    FileStream stream = new FileStream($@"{imagePath.FilesName}", FileMode.Open, FileAccess.ReadWrite);
                    db.FileStorage.Upload(imagePath.FilesID, $@"{imagePath.FilesName}", stream);
                    stream.Close();
                }
                */
                return true;
            }
        }

        public static object GetDynamicSortProperty(object item, string propName)
        {
            //Use reflection to get order type
            return item.GetType().GetProperty(propName).GetValue(item, null);
        }
        public static List<T> Sort_List<T>(string sortDirection, string sortExpression, List<T> data)
        {
            List<T> data_sorted = new List<T>();
            if (sortDirection == "Ascending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) ascending
                               select n).ToList();
            }
            else if (sortDirection == "Descending")
            {
                data_sorted = (from n in data
                               orderby GetDynamicSortProperty(n, sortExpression) descending
                               select n).ToList();

            }
            return data_sorted;
        }
        public LiteFileInfo<string> GetImage(string guid)
        {
            string connectionStr = DatabasePath;
            using (var db = new LiteDatabase(connectionStr))
            {
                ActMemoryStream = new MemoryStream();
                var files = db.FileStorage.Download(guid, ActMemoryStream);
                return files;
            }
        }
    }
}
