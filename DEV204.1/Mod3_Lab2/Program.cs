using System;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 9;
            int second = 0;
            Console.WriteLine("Enter your first name: ");
            first = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");

            int result = Devide(first, second);
            Console.WriteLine($"The result of dividing {first} by {second} is {result}");
        }

        private static int Devide(int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("cannot divided by zero, please provide a non-zero value for your second value");
            }
            return result;
        }
    }
}
