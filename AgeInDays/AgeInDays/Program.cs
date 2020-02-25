using System;

namespace AgeInDays
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());

            int years = totalDays / 365;
            int aux = totalDays % 365;
            int months = aux / 30;
            int days = aux % 30;

            Console.WriteLine(years + " ano(s)");
            Console.WriteLine(months + " mes(es)");
            Console.WriteLine(days + " dia(s)");
        }
    }
}
