using System;
using System.Collections.Generic;

// 1080 - Highest and Position

namespace HighestAndPosition
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] values = new int[101];

            int highest = 0;

            int position = 0;

            for (int i = 1; i < 101; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < 101; i++)
            {
                if (values[i] > values[position])
                {
                    highest = values[i];
                    position = i;
                }
            }

            Console.WriteLine(highest);
            Console.WriteLine(position);
        }
    }
}
