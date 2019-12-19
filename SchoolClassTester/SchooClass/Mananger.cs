using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace SchoolClassTester
{
    class SchoolClassCreator
    {
        public static List<SchoolClass> tempSchoolList = new List<SchoolClass>();
        public static void SchoolClassCreate()
        {
            tempSchoolList.Add(new SchoolClass());
            Console.WriteLine("Class suffix?");
            tempSchoolList[0].ClassSuffix = Console.ReadLine();
            Console.WriteLine("How many students?");
            tempSchoolList[0].StudentAmount = int.Parse(Console.ReadLine());
        }
        public static void SchoolClassRemove()
        {
            Console.WriteLine("Which Class would you like to remove?");
            string tempClassName = Console.ReadLine();

        }
        public static void load()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LessonEndSchedules", "Information.json");
            tempSchoolList = LoadFile<List<SchoolClass>>(path);
        }
        public static T LoadFile<T>(string path)
        {
            var text = File.ReadAllText(path);
            StringReader reader = new StringReader(text);
            string line = string.Empty;
            Console.WriteLine("Files loaded succesfully");
            return JsonConvert.DeserializeObject<T>(text);
        }
    }
}
