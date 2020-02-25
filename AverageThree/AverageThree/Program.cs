using System;
using System.Globalization;

//1040 - Average 3

namespace AverageThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string score = Console.ReadLine();
            string[] vs = score.Split(' ');

            double N1 = double.Parse(vs[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(vs[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(vs[2], CultureInfo.InvariantCulture);
            double N4 = double.Parse(vs[3], CultureInfo.InvariantCulture);

            double average = ((N1 * 2) + (N2 * 3) + (N3 * 4) + N4) / 10;

            if (average > 5)
            {
                average = Math.Round(average, 1);
            }



            Console.WriteLine("Media: " + average.ToString("F1", CultureInfo.InvariantCulture));

            if (average >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (average >= 5.0)
            {
                Console.WriteLine("Aluno em exame.");
                Console.Write("Nota do exame: ");
                double examScore = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                average = (average + examScore) / 2;
                if (average >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + average.ToString("F1", CultureInfo.InvariantCulture));

            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

        }
    }
}
