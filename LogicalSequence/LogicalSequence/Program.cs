using System;

// 1144 - Logical Sequence

namespace LogicalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double value = 0;
            for (int i = 1; i <= n; i++)
            {
                value = i;
                for (int k = 0; k < 2; k++)
                {
                    for (double j = 1; j <= 3; j++)
                    {
                        if (k != 0 && j != 1)
                        {
                            value = 1 + (Math.Pow(i, j));
                        }
                        else
                        {
                            value = Math.Pow(i, j);
                        }
                        Console.Write(value);
                        if (j != 3)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
