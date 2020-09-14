using System;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Sum(20, 40);
            Console.WriteLine($"The sum of 20 and 40 is {result}");

            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"Calling SUm() with three arguments, result is : {result3}");

            double dblResult = Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum(0 that takes doubles result in: {dblResult}");
        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }

        private static int Sum(int first, int second, int third)
        {
            return first + second + third;
        }

        private static double Sum(double first, double second)
        {
            return first + second;
        }
    }
}