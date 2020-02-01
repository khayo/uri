using System;
using System.Globalization;

//1043 - Triangle

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vs = input.Split(' ');

            double N1 = double.Parse(vs[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(vs[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(vs[2], CultureInfo.InvariantCulture);

            // Condição de existência de um triângulo:
            // |b - c| < a < b + c
            // |a - c| < b < a + c
            // |a - b| < c < a + b

            if (Triangle(N1, N2, N3))
            {
                double perimetro = N1 + N2 + N3;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                double area = (N3 * (N1 + N2)) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }

        }

        static bool Triangle(double a, double b, double c)
        {
            if (a < b + c && b < a + c && c < a + b)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


    }
}
