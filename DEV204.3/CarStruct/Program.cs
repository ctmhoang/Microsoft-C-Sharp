using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarStruct
{
    struct Car
    {
        public string Make;
        public string Model;
        public string Color;

        public void Accelerate()
        {
            Console.WriteLine("Vroom");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "foo";
            myCar.Model = "bar";
            myCar.Color = "gold";
            Console.WriteLine($"My car is a {myCar.Make} {myCar.Model} that is {myCar.Color} in color.");
            myCar.Accelerate();
        }
    }
}
