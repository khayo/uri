using System;
using System.Globalization;

//1064 - PositiveAndAverage

namespace PositiveAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[6];
            int pos = 0;
            double average = 0;

            for (int i = 0; i < 6; i++)
            {
                num[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < 6; i++)
            {
                if (num[i] >= 0)
                {
                    pos++;
                    average += num[i];
                }

                

            }

            average = average / pos;

            Console.WriteLine(pos + " valores positivos");
            Console.WriteLine(average.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
