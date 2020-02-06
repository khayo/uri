using System;
using System.Globalization;

namespace PositiveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputs = new double[6];
            int qtd = 0;
            for (int i = 0; i < 6; i++)
            {
                inputs[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < 6; i++)
            {
                if (inputs[i] > 0)
                {
                    qtd++;
                }
            }

            Console.WriteLine(qtd + " valores positivos");
        }
    }
}
