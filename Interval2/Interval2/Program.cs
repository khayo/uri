using System;
using System.Collections.Generic;

// 1072 - Inteval 2

namespace Interval2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            int inside = 0;
            int outside = 0;

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in list)
            {
                if (item >= 10 && item <= 20)
                {
                    inside++;
                }
                else
                {
                    outside++;
                }
            }

            Console.WriteLine(inside + " in");
            Console.WriteLine(outside + " out");
        }
    }
}
