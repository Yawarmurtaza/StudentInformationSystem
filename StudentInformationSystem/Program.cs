﻿using System;

namespace StudentInformationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            // get the name of student from the command prompt / console.
            Console.Write("Enter your first and last name as a string: ");

            // save the name in MyName vairable of string.
            string MyName = Console.ReadLine();

            // get the student id.
            int MyId = GetStudentId();

            // we know that first name and surname are separated by space ' ' - the ASCII code for space is 32
            int spaceIndex = MyName.IndexOf(' ');

            // we use substring from index 0 till the space index to get the first name... eg: John Smith-Ahmed, spaceIndex = 4, subString 0-4 = "John"
            string FirstName = MyName.Substring(0, spaceIndex);

            // the rest of the string is surname so anything after the space index is surname. eg: "Smith-Ahmed"
            string Surname = MyName.Substring(spaceIndex);

            // once we have surname and student id, we can now allocate the stream.
            string stream = AllocateStreams(Surname, MyId);

            // once we have everything, we can display.
            DisplayInformation(MyId, FirstName, Surname, stream);

            // this is to hold the console output until we press enter.
            Console.ReadLine();
        }

        // display the output by printing the information on the screen.
        static void DisplayInformation(int studentId, string firstName, string surname, string stream)
        {
            Console.WriteLine("\n\n****************************** Stream Information ******************************\n");
            Console.WriteLine("================================================================================\n");
            Console.WriteLine("Student ID\t\t\tFirst Name\t\t\tFamily Name\t\t\tStream\n");
            Console.WriteLine("================================================================================\n");
            Console.WriteLine("{0}\t\t\t{1}\t\t\t{2}\t\t\t{3}", studentId,firstName, surname, stream);
        }

        static int GetStudentId()
        {
            int validStudentId = 0;
            while (true)
            {
                // we are using while loop here
                // we will come out of this loop once we have a valid student id.
                try
                {
                    Console.Write("Enter your student ID as an integer: ");
                    string studentIdString = Console.ReadLine();

                    // int.Parse will throw exception when an invalid number is provided.
                    validStudentId = int.Parse(studentIdString);

                    // once we have successfully parsed the student id, we need to break from while loop.
                    break;
                }
                catch
                {
                    // we catch the exception / error and ask the student to try to re-enter the id 
                    Console.WriteLine("Invalid entry: Please enter 8 digit ID");
                }
            }

            // here we have a valid student id.
            return validStudentId;
        }

        // use the surname's first letter and last 2 digits of student id to allocate the stream.
        static string AllocateStreams(string surname, int studentId)
        {
            // we need last 2 digits of student id, taking mod of 100 will do just that.
            int last2Digits = studentId % 100;
            char firstLetterSurname = surname[0];

            // Condition 1:
            if (firstLetterSurname >= 'A' && firstLetterSurname <= 'N' && last2Digits < 50)
            {
                return "Stream 20";
            }

            // Condition 2:
            if (firstLetterSurname >= 'A' && firstLetterSurname <= 'N' && last2Digits >= 50)
            {
                return "Stream 21";
            }

            // Condition 3:
            if (firstLetterSurname >= 'O' && last2Digits < 50)
            {
                return "Stream 22";
            }

            // Condition 4:
            return "Stream 23";
        }
    }
}
