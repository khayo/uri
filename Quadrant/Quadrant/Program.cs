using System;

//1115 - Quadrant

namespace Quadrant
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] vs;
            bool again = true;
            do
            {
                
                input = Console.ReadLine();
                vs = input.Split(' ');

                int x = int.Parse(vs[0]);
                int y = int.Parse(vs[1]);

                //         Quadrantes

                //        2    |    1
                //             |
                //      x - y  |  x   y
                //             |
                //-------------|-------------
                //             |
                //     -x - y  | -x   y
                //             |
                //        3    |    4

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }
                else
                {
                    again = false;
                }

            } while (again);
        }
    }
}
