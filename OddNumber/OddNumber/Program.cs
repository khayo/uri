using System;

// 1067 - Odd Number

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x >= 1 && x <= 1000)
            {
                for (int i = 0; i <= x; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
