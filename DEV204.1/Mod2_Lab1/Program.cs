using System;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an if decision block

            // Request user input with ReadLine()
            Console.WriteLine("Please enter an integer value an press enter");

            // Assign the entered value to the var input
            int input = Int32.Parse(Console.ReadLine());

            // Check to see if the number is even
            if(input % 2 == 0)
                Console.WriteLine("The entered number was an even number.");
            else 
                Console.WriteLine("The entered number is not an even number.");

        }
    }
}