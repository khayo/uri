using System;
using System.Globalization;

//1040 - Average 3

namespace AverageTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string score = Console.ReadLine();
            string[] vs = score.Split(' ');

            float N1 = float.Parse(vs[0], CultureInfo.InvariantCulture);
            float N2 = float.Parse(vs[1], CultureInfo.InvariantCulture);
            float N3 = float.Parse(vs[2], CultureInfo.InvariantCulture);
            float N4 = float.Parse(vs[3], CultureInfo.InvariantCulture);

            float average = ((N1 * 2) + (N2 * 3) + (N3 * 4) + N4) / 10;

            Console.WriteLine("Media: " + average.ToString("F1", CultureInfo.InvariantCulture));

            if (average >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (average >= 5.0)
            {
                Console.WriteLine("Aluno em exame.");
                Console.Write("Nota do exame: ");
                float examScore = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
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
