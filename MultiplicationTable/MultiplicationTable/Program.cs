using System;

// 1078 - Multiplication Table

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 1 && n < 1000)
            {
                for (int i = 1; i <= 10 ; i++)
                {
                    Console.WriteLine($"{i} x {n} = {i * n}");
                }
            }
        }
    }
}
