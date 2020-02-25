using System;

// Even, Odd, Positive and Negative

namespace EvenOddPositiveAndNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int even = 0;
            int odd = 0;
            int pos = 0;
            int neg = 0;

            for (int i = 0; i < 5; i++)
            {
                num[i] = int.Parse(Console.ReadLine());              
            }

            for (int i = 0; i < 5; i++)
            {
                if (num[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

                if (num[i] > 0)
                {
                    pos++;
                }
                else if(num[i] < 0)
                {
                    neg++;
                }

            }

            Console.WriteLine(even + " valor(es) par(es)");
            Console.WriteLine(odd + " valor(es) impar(es)");
            Console.WriteLine(pos + " valor(es) positivo(s)");
            Console.WriteLine(neg + " valor(es) negativo(s)");
        }
    }
}
