using System;
using System.Globalization;

//1045 - Triangle Types

namespace TrinagleTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vs = input.Split(' ');

            double a = double.Parse(vs[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vs[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vs[2], CultureInfo.InvariantCulture);

            if (a > 0 && b > 0 && c > 0)
            {

                double[] vi = new double[3];
                vi[0] = Bigger(a, b, c);
                vi[1] = Middle(a, b, c);
                vi[2] = Smaller(a, b, c);

                a = vi[0];
                b = vi[1];
                c = vi[2];

                double aPow = Math.Pow(a, 2);
                double bPow = Math.Pow(b, 2);
                double cPow = Math.Pow(c, 2);



                if (a >= b + c)
                {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
                else if (aPow == bPow + cPow)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (aPow > bPow + cPow)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if (aPow < bPow + cPow)
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }


                if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if ((a == b && b != c) || (b == c && a != c))
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }

         static double Bigger(double a, double b, double c)
        {
            if (a >= b && a > c)
            {
                return a;
            }
            else if (b >= a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }

        }

        static double Middle(double a, double b, double c)
        {
            if ((a >= b && a < c) || (a < b && a > c))
            {
                return a;
            }
            else if ((b >= a && b < c) || (b < a && b > c))
            {
                return b;
            }
            else
            {
                return c;
            }

        }

        static double Smaller(double a, double b, double c)
        {
            if (a <= b && a < c)
            {
                return a;
            }
            else if (b <= a && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
