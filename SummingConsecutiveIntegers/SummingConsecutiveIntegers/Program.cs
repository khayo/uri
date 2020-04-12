using System;

// 1149 - Summing Consecutive Integers

namespace SummingConsecutiveIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int n = 0;
            int sum = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (int.Parse(input[i]) > 0)
                {
                    n = int.Parse(input[i]);
                }                
            }
            for (int i = 0; i < n; i++)
            {
                sum += (a+i);
            }            
            Console.WriteLine(sum);
        }
    }
}

