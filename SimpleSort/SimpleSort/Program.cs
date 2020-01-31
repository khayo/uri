using System;

//1042 - Simple Sort

namespace SimpleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] vs = input.Split(' ');

            int N1 = int.Parse(vs[0]);
            int N2 = int.Parse(vs[1]);
            int N3 = int.Parse(vs[2]);
                                   
            int[] vi = new int[3];
            vi[0] = Smaller(N1, N2, N3);
            vi[1] = Middle(N1, N2, N3);
            vi[2] = Bigger(N1, N2, N3);

            Console.WriteLine(vi[0]);
            Console.WriteLine(vi[1]);
            Console.WriteLine(vi[2]);

            Console.WriteLine();
            Console.WriteLine(vs[0]);
            Console.WriteLine(vs[1]);
            Console.WriteLine(vs[2]);



        }
        public static int Bigger(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
;                return b;
            }
            else
            {
                 return c;
            }

        }

        public static int Middle(int a, int b, int c)
        {
            if ((a > b && a < c) || (a < b && a > c))
            {
                return a;
            }
            else if ((b > a && b < c) || (b < a && b > c))
            {
                ; return b;
            }
            else
            {
                return c;
            }

        }

        public static int Smaller(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                ; return b;
            }
            else
            {
                return c;
            }

        }
    }
}
