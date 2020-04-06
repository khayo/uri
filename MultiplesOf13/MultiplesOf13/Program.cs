using System;
using System.Collections.Generic;

// Multiples of 13

namespace MultiplesOf13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = 0;

            if (x < y)
            {
                int aux = y;
                y = x;
                x = aux;
            }

            for (int i = y; i <= x; i++)
            {
                int aux = i % 13;
                if (aux != 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
