using System;

// 1143 - Squared and Cubic

namespace SquareAndCubic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double value = 0;
            for (int i = 1; i <= n; i++)
            {
                value = i;
                for (double j = 1; j <= 3; j++)
                {
                    value = Math.Pow(i, j);
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
