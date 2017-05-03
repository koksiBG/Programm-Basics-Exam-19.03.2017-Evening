using System;

namespace Grape_and_Rakia
{
    class Grape_and_Rakia
    {
        static void Main(string[] args)
        {
            double areaOfVineyard = double.Parse(Console.ReadLine());
            double kilogramsGrape = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());
            double harvest = areaOfVineyard * kilogramsGrape;
            double remainingGrapes = harvest - waste;
            double forRakia = 0.45 * remainingGrapes;
            double rakiaLiters = forRakia / 7.5;
            double forSales = 0.55 * remainingGrapes;
            double earningsRakia = rakiaLiters * 9.8;
            double earningsGrape = forSales * 1.5;
            Console.WriteLine($"{earningsRakia:f2}");
            Console.WriteLine($"{earningsGrape:f2}");
        }
    }
}