using System;

namespace SchoolClassTester
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SchoolClassCreator.load();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            do
            {
                try
                {
                    AccMananger.Login();
                }
                catch
                {
                    ///More nom nom
                }
            } while (AccMananger.verified == false);
            while (AccMananger.verified == true)
            {
                try
                {

                    Console.WriteLine("Welcome " + SchoolClassCreator.tempSchoolList[0].TempStudentDetails[AccMananger.LoadedStudent].Firstname +" " + SchoolClassCreator.tempSchoolList[0].TempStudentDetails[AccMananger.LoadedStudent].lastname + ". The time is " + DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                    Console.ReadLine();
                    AccMananger.verified = false;
                }
                catch
                {
                    ///Nom nom nom
                }
            }
            try
            {
                Filemananger.Save();
            }
            catch
            {
                Console.WriteLine("Failed to save files");
            }
            ///SchoolClassCreator.load();
            ///StudentMananger.PasswordCreate();
            ///Console.WriteLine(SchoolClassCreator.tempSchoolList[0].TempStudentDetails[0].Firstname);
            
        }
    }
}
