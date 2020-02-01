using System;

//1046 - Game Time

namespace GameTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vs = input.Split(' ');
            int start = int.Parse(vs[0]);
            int end = int.Parse(vs[1]);
            int total = 0;

            if (start >= end)
            {
                total = (24 - start) + end;
            }
            else
            {
                total = end - start;
            }

            Console.WriteLine($"O JOGO DUROU {total} HORA(S)");


        }
    }
}
