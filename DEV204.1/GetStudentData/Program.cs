using System;

namespace GetStudentData
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname, bday;
            GetStudentInformation(out fname, out lname, out bday);
            PrintStudentDetails(fname, lname, bday);
            validateBirthday(bday);
        }

        static void GetStudentInformation(out string firstName, out string lastName, out string birthday)
        {
            Console.WriteLine("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birth date");
            birthday = Console.ReadLine();
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static bool validateBirthday(string birthday)
        {
            throw new NotImplementedException();
        }
    }
}