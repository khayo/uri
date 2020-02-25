using System;

// 1065 - Even Between Five Numbers

namespace EvenBetweenFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int even = 0;
            
            for (int i = 0; i < 5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                if (num[i] % 2 == 0)
                {
                    even++;                   
                }

            }

            Console.WriteLine(even + " valores pares");            
        }
    }
}
