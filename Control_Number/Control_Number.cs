using System;

namespace Control_Number
{
    class Control_Number
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            int controlNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                for (int j = M; j >= 1; j--)
                {
                    sum += i * 2 + j * 3;
                    count++;
                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{count} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        return;
                    }
                }
            }
            if (sum < controlNumber)
            {
                Console.WriteLine($"{count} moves");
            }
        }
    }
}