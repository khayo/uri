using System;
using System.Globalization;

// 1116 - Dividing X by Y

namespace DividingXbyY
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, 2];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] vs = input.Split(' ');
                matrix[i, 0] = vs[0];
                matrix[i, 1] = vs[1];
            }

            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(matrix[i, 0]);
                double y = double.Parse(matrix[i, 1]);
                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double total = x / y;
                    Console.WriteLine(total.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
