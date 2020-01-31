using System;
using System.Globalization;

namespace CordinatesOfAPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string coord = Console.ReadLine();
            string[] vs = coord.Split(' ');

            double x = double.Parse(vs[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vs[1], CultureInfo.InvariantCulture);

            if (x == 0.0 || y == 0.0)
            {
                if (x != 0)
                {
                    Console.WriteLine("Eixo X");
                }
                else if (y != 0)
                {
                    Console.WriteLine("Eixo Y");
                }
                else
                {
                    Console.WriteLine("Origem");
                }
            }
            else if (x > 0.0 &&  y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0 )
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
