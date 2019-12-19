using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace SchoolClassTester
{
    class AccMananger
    {
        public static bool verified = false;
        public static int LoadedStudent;
        public static bool Login()
        {
            bool tempbool = false;
            string Password1 = "";
            do
            {
                Console.WriteLine("Username");
                tempbool = AccMananger.jeff(Console.ReadLine());
                Password1 = SchoolClassCreator.tempSchoolList[0].TempStudentDetails[LoadedStudent].password;
            } while (tempbool == false);
            bool password = false;

            while (password == false)
            {
                Console.WriteLine("Please enter your Password");
                if (Console.ReadLine() != Password1)
                {
                    Console.WriteLine("you entered the wrong password");
                }
                else
                {
                    password = true;
                }
            }
            return verified = true;
        }
        public static bool jeff(string input)
        {
            int i = 0;
            LoadedStudent = 0;
            foreach (StudentDetails x in SchoolClassCreator.tempSchoolList[0].TempStudentDetails)
            {
                if (input == SchoolClassCreator.tempSchoolList[0].TempStudentDetails[i].Firstname + SchoolClassCreator.tempSchoolList[0].TempStudentDetails[i].lastname)
                {
                    LoadedStudent = i;
                }
                else
                {
                    i++;
                }

            }
            if (input != SchoolClassCreator.tempSchoolList[0].TempStudentDetails[i].Firstname)
            {
                Console.WriteLine("Account not found");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
