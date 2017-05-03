using System;

namespace Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double sumElectricityBill = 0;
            int water = months * 20;
            int internet = months * 15;
            double other = 0;
            for (int i = 0; i < months; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());
                sumElectricityBill += electricityBill;
                other += 1.2 * (electricityBill + 20 + 15);
            }
            Console.WriteLine($"Electricity: {sumElectricityBill:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {(sumElectricityBill + water + internet + other) / months:f2} lv");
        }
    }
}