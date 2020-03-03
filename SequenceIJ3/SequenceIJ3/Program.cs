using System;

// 1097 - Sequence IJ 3

namespace SequenceIJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            for (int i = 1; i <= 9; i+=2)
            {                
                for (int j = n; j >= n - 2; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
                n += 2;
            }
        }
    }
}
