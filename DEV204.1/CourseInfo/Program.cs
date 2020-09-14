using System;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Information
            Console.WriteLine("Enter first name: ");
            string fstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            var lstName = Console.ReadLine();

            Console.WriteLine("Enter date of birth in form MM/DD/YYYY: ");
            var dateData = Console.ReadLine().Split("/"); //if use regex must use class regex to split
            var birthDate = new DateTime(int.Parse(dateData[2]), int.Parse(dateData[0]), int.Parse(dateData[1]));

            Console.WriteLine("Enter address 1: ");
            var addr1 = Console.ReadLine();

            Console.WriteLine("Enter address 2: ");
            var addr2 = Console.ReadLine();

            Console.WriteLine("Enter city name: ");
            var city = Console.ReadLine();

            Console.WriteLine("Enter State/Province: ");
            var stpr = Console.ReadLine();

            Console.WriteLine("Enter Zip/Postal code: ");
            var zipcode = Console.ReadLine();

            Console.WriteLine("Enter Country Name: ");
            var country = Console.ReadLine();

            Console.WriteLine("Are you a student? ");
            bool isStudent = Boolean.Parse(Console.ReadLine() ?? "false");

            Console.WriteLine($"Is student: {isStudent} \n" +
                              $"Full name: {fstName} {lstName} \n" +
                              $"Birthdate: {birthDate} \n" +
                              $"Address 1: {addr1} \n" +
                              $"Address 2: {addr2} \n" +
                              $"City: {city} \n" +
                              $"State/Province: {stpr} \n" +
                              $"Zip/Postal: {zipcode}\n" +
                              $"Country: {country}");
        }
    }
}