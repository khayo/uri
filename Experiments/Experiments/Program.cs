using System;
using System.Collections.Generic;
using System.Globalization;

// 1094 - Experiments

namespace Experiments
{

    class Animals
    {
        public int Amount { get; set; }
        public char Type { get; set; }

        public Animals(int amount, char type)
        {
            Amount = amount;
            Type = type;
        }

        public override string ToString()
        {
            return "QTD "
                + Amount;
        }
    }

    class Program
    {

        static double Percentual(double amount, double total)
        {
            double percent = (amount * 100) / total;

            return percent;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Animals> list = new List<Animals>();

            for (int i = 0; i < n; i++)
            {
                string aux = Console.ReadLine();
                string[] vs = aux.Split(' ');

                int amount = int.Parse(vs[0]);
                char type = char.Parse(vs[1].ToUpper());

                Animals animal = new Animals(amount, type);
                list.Add(animal);

            }

            int c = 0;
            int r = 0;
            int s = 0;

            foreach (var item in list)
            {
                if (item.Type == 'C')
                {
                    c += item.Amount;
                }
                else if (item.Type == 'R')
                {
                    r += item.Amount;
                }
                else
                {
                    s += item.Amount;
                }               
            }
            double total = c + r + s;
                        
            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {c}");
            Console.WriteLine($"Total de ratos: {r}");
            Console.WriteLine($"Total de sapos: {s}");
            Console.WriteLine($"Percentual de coelhos: {Percentual(c, total).ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {Percentual(r, total).ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {Percentual(s, total).ToString("F2", CultureInfo.InvariantCulture)} %");
        }
    }
}

