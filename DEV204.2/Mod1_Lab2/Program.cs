using System;


namespace Mod1_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Object initializer
            var car1 = new Car {Color = "White", Year = 2010, Mileage = 11000};

            var car2 = new Car("Red", 2008);
            int carCount = Car.CountCars();

            Console.WriteLine($"There are {carCount} cars on inventory right now.");

        }
    }

    // Declaring the Car() Class
    // This class has 3 properties: Color, Year, and Mileage
    public class Car
    {
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Car(string color, int year) : this()
        {
            this.Color = color;
            this.Year = year;
        }

        public Car(int year, int mileage) : this()
        {
            Year = year;
            Mileage = mileage;
        }

        private static int _instances = 0;

        public Car()
        {
            _instances++;
        }

        public static int CountCars()
        {
            return _instances;
        }

    }
}