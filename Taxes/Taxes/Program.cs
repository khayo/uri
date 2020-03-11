using System;
using System.Globalization;

// 1051 - Taxes

namespace Taxes
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double aux = 0.0;
            double sumTax = 0.0;
            if (value > 4500.00)
            {
                aux = value - 4500;
                sumTax = aux * 0.28;
                value = 4500;
            }
            if (value >= 3000.01 && value <= 4500.00) 
            {
                aux = value - 3000.00;
                sumTax = sumTax + (aux * 0.18);
                value = 3000.00;
            }
            if (value >= 2000.01 && value <= 3000.00)
            {
                aux = value - 2000.00;
                sumTax = sumTax + (aux * 0.08);
                value = 2000.00;
            }
            if (value >= 0.00 && value <= 2000.00 && sumTax == 0)
            {
                Console.WriteLine("Isento");
            }
            if (sumTax != 0.0 )
            {
                Console.WriteLine("R$ " + sumTax.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
