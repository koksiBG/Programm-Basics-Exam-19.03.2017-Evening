using System;

namespace Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double areaHouse = double.Parse(Console.ReadLine());
            int numbersOfWindows = int.Parse(Console.ReadLine());
            double areaStyrofoamInPacket = double.Parse(Console.ReadLine());
            double priceOnePacketStyrofoam = double.Parse(Console.ReadLine());
            double area = 1.1 * (areaHouse - numbersOfWindows * 2.4);
            double packet = Math.Ceiling(area / areaStyrofoamInPacket);
            double sumPricePacketStyrofoam = packet * priceOnePacketStyrofoam;
            if (sumPricePacketStyrofoam <= budget)
            {
                Console.WriteLine($"Spent: {sumPricePacketStyrofoam:f2}");
                Console.WriteLine($"Left: {budget - sumPricePacketStyrofoam:f2}");
            }
            else Console.WriteLine($"Need more: {sumPricePacketStyrofoam - budget:f2}"); 
        }
    }
}