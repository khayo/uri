using System;

// 1070 - Six Odd Numbers

namespace SixOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                for (int i = x; i < x + 12; i++)
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
