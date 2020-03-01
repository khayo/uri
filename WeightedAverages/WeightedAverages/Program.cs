using System;
using System.Globalization;

// 1079 - Weighed Averages

namespace WeightedAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[,] values = new double[n, 3];

            for (int i = 0; i < n; i++)
            {
                string num = Console.ReadLine();
                string[] vs = num.Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    values[i,j] = double.Parse(vs[j], CultureInfo.InvariantCulture);
                }

            }

            for (int i = 0; i < n; i++)
            {
                double avg = ((values[i, 0] * 2) + (values[i, 1] * 3) + (values[i, 2] * 5)) / 10;
                Console.WriteLine(avg.ToString("F1", CultureInfo.InvariantCulture));
            }


        }
    }
}
