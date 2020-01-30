using System;
using System.Globalization;

//1038 - Snack

namespace Snack
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            string[] vs = order.Split(' ');
            int product = int.Parse(vs[0]);
            int qtd = int.Parse(vs[1]);
            double price = 0;

            switch (product)
            {
                case 1:
                    price = 4.00;
                    break;
                case 2:
                    price = 4.50;
                    break;
                case 3:
                    price = 5.00;
                    break;
                case 4:
                    price = 2.00;
                    break;
                case 5:
                    price = 1.50;
                    break;
            }

            double total = qtd * price;

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
