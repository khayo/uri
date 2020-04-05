using System;
using System.Collections.Generic;
using System.Globalization;


// 1117 - Score Validation

namespace ScoreValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();

            int n = 0;
            while (n != 2)
            {
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(value);
                if (value >= 0.0 && value <= 10)
                {
                    n++;
                }
            }

            double[] vs = new double[2];
            int y = 0;
            foreach (var value in list)
            {
                if (value >= 0.0 && value <= 10)
                {
                    vs[y] = value;
                    y++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            double media = (vs[0] + vs[1]) / 2;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
