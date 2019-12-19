using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SchoolClassTester
{
    class StudentMananger
    {
        public static void AddStudent()
        {
            SchoolClassCreator.tempSchoolList[0].TempStudentDetails.Add(new StudentDetails());
            Console.WriteLine("Student first name?");
            SchoolClassCreator.tempSchoolList[0].TempStudentDetails[0].Firstname = Console.ReadLine();
            Console.WriteLine("Students last name?");
            SchoolClassCreator.tempSchoolList[0].TempStudentDetails[0].lastname = Console.ReadLine();
            Console.WriteLine("Student Address?");
            SchoolClassCreator.tempSchoolList[0].TempStudentDetails[0].Address = Console.ReadLine();
        }
        
        public static void RemoveStudent()
        {
            Console.WriteLine("Who do you want to remove?");
            string TempStudentName = Console.ReadLine().ToLower();
            string LoadedStudentName;
            int i = 0;
            do
            {
                LoadedStudentName = SchoolClassCreator.tempSchoolList[0].TempStudentDetails[i].Firstname;
                i++;
            } while (LoadedStudentName != TempStudentName ||i < 24);
            if(LoadedStudentName != TempStudentName)
            {
                Console.WriteLine("Student not found");
            }
            else
            { 
                SchoolClassCreator.tempSchoolList[0].TempStudentDetails.RemoveAt(i);
            }
        }
        public static void PasswordCreate()
        {
            bool TempBool = false;
            string tempassword;
            while (TempBool == false)
            {
                Console.WriteLine("What would you like your password to be?");
                tempassword = Console.ReadLine();
                Console.WriteLine("Please confirm you password");
                if (Console.ReadLine() == tempassword)
                {
                    Console.WriteLine("Password accepted");
                    SchoolClassCreator.tempSchoolList[0].TempStudentDetails[0].password = tempassword;
                    TempBool = true;
                }
                else
                {
                    Console.WriteLine("The passwords did not match");
                }

            }
        }
        
        public static void StudentSelector(string input)
        {
             SchoolClassCreator.tempSchoolList.Where(tempSchool => tempSchool.TempStudentDetails.Where(details => details.Firstname == input).Any()).ToList();
        }
    }
}
