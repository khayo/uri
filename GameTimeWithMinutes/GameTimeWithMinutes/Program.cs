using System;

//1047 - Game Time With Minutes

namespace GameTimeWithMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vs = input.Split(' ');
            int start_h = int.Parse(vs[0]);
            int start_m = int.Parse(vs[1]);
            int end_h = int.Parse(vs[2]);
            int end_m = int.Parse(vs[3]);

            DateTime start = new DateTime(2018, 5, 5, start_h, start_m, 0);
            DateTime end = new DateTime(2018, 5, 5, end_h, end_m, 0);

            if (start_h >= end_h && start_m >= end_m)
            {
                start = new DateTime(2018, 5, 5, start_h, start_m, 0);
                end = new DateTime(2018, 5, 6, end_h, end_m, 0);
            }



            TimeSpan span = end - start;

            if (span.Days == 1)
            {
                Console.WriteLine($"O JOGO DUROU 24 HORA(S) E {span.Minutes} MINUTO(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {span.Hours} HORA(S) E {span.Minutes} MINUTO(S)");
            }

        }
    }
}
