using System;

// 1133 - Rest of a Division

namespace RestOfaDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                int aux = y;
                y = x;
                x = aux;
            }

            for (int i = x+1; i < y; i++)
            {

                int aux = i % 5;

                if (aux == 2 || aux == 3)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
