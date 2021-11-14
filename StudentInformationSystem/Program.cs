using System;

namespace StudentInformationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first and last name as a string: ");
            string MyName = Console.ReadLine();

            int MyId = GetStudentId();

            int spaceIndex = MyName.IndexOf(' ');
            string FirstName = MyName.Substring(0, spaceIndex);
            string Surname = MyName.Substring(spaceIndex);
            string stream = AllocateStreams(Surname, MyId);

            DisplayInformation(MyId, FirstName, Surname, stream);
            Console.ReadLine();
        }

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
            int studentId = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter your student ID as an integer: ");
                    string studentIdString = Console.ReadLine();
                    studentId = int.Parse(studentIdString);
                    break;
                }
                catch
                {
                    Console.WriteLine("Invalid entry: Please enter 8 digit ID");
                }
            }

            return studentId;
        }

        static string AllocateStreams(string surname, int studentId)
        {
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
