using System;

// 1071 - Sum of Consecutive Odd Numbers I

namespace SumOfConsecutiveOddNumbersI
{
    class Program
    {              
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = 0;

            if (x >= y)
            {
                for (int i = y + 1; i < x; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }
            }
            else
            {
                for (int i = x + 1; i < y; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }
            }

            Console.WriteLine(sum);

        }
    }
}
