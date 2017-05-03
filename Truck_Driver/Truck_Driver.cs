using System;

namespace Truck_Driver
{
    class Truck_Driver
    {
        static void Main(string[] args)
        {
            string seson = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());
            double priceForKilometers = 0;
            if (seson == "Spring" || seson == "Autumn")
            {
                if (kilometers <= 5000)
                {
                    priceForKilometers = 0.75;
                }
                if (kilometers > 5000 && kilometers <= 10000)
                {
                    priceForKilometers = 0.95;
                }
            }
            if (seson == "Summer")
            {
                if (kilometers <= 5000)
                {
                    priceForKilometers = 0.90;
                }
                if (kilometers > 5000 && kilometers <= 10000)
                {
                    priceForKilometers = 1.10;
                }
            }
            if (seson == "Winter")
            {
                if (kilometers <= 5000)
                {
                    priceForKilometers = 1.05;
                }
                if (kilometers > 5000 && kilometers <= 10000)
                {
                    priceForKilometers = 1.25;
                }
            }
            if (kilometers > 10000 && kilometers <= 20000)
            {
                priceForKilometers = 1.45;
            }
            double salary = kilometers * priceForKilometers * 4;
            double salaryAfterVat = salary - 0.10 * salary;
            Console.WriteLine($"{salaryAfterVat:f2}");
        }
    }
}