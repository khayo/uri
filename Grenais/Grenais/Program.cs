using System;
using System.Collections.Generic;

namespace Grenais
{
    //1131 - Grenais

    class Program
    {
        static void Main(string[] args)
        {
            int repeat = 1;

            List<string> result = new List<string>();


            while (repeat == 1)
            {
                string input = Console.ReadLine();
                string[] match = input.Split(' ');
                int i = int.Parse(match[0]);
                int g = int.Parse(match[1]);

                if (i > g)
                {
                    result.Add("I");
                }
                else if (g > i)
                {
                    result.Add("G");
                }
                else
                {
                    result.Add("D");
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                repeat = int.Parse(Console.ReadLine());
            }

            int matches = 0;
            int inter = 0;
            int gremi = 0;
            int draw = 0;

            foreach (var item in result)
            {
                matches++;
                if (item == "I")
                {
                    inter++;
                }
                else if (item == "G")
                {
                    gremi++;
                }
                else
                {
                    draw++;
                }                
            }
            Console.WriteLine($"{matches} grenais");
            Console.WriteLine($"Inter:{inter}");
            Console.WriteLine($"Gremio:{gremi}");
            Console.WriteLine($"Empates:{draw}");

            if (inter > gremi)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (gremi > inter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Não houve vencedor");
            }
        }
    }
}
