using System;
using System.Collections.Generic;

// 1113 - Ascending and Descending

namespace AscendingAndDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int x = 0;
            int y = 0;
            do
            {
                string values = Console.ReadLine();
                string[] numbers = values.Split(' ');
                x = int.Parse(numbers[0]);
                y = int.Parse(numbers[1]);
                if (x < y)
                {
                    list.Add("Crescente");
                }
                else if(x > y)
                {
                    list.Add("Decrescente");
                }

            } while (x != y);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
