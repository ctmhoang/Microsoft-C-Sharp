using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var car1 = new Car {Color = "White", Year = 2010, Mileage = 11000};

            var car2 = new Car("Red", 2008);

            // Access static members
            int carCount = Car.CountCars();

            // Output to the console window
            Console.WriteLine($"There are {carCount} cars on inventory right now.");
        }
    }

    // Declaring the Car() Class
    // This class has 3 properties: Color, Year, and Mileage
    
        
}