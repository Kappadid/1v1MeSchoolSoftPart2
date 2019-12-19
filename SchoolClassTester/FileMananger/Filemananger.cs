using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace SchoolClassTester
{
    class Filemananger
    {
        public static void Save()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LessonEndSchedules", "Information.json");
            string json = JsonConvert.SerializeObject(SchoolClassCreator.tempSchoolList);
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(json);
            writer.Close();
        }
        public static string Loadstring(string path)
        {
            StreamReader reader = new StreamReader(path);
            string tempstring = reader.ReadToEnd();
            reader.Close();
            return tempstring;
        }
    }
}
