using System;

// 1150 - Exceeding Z

namespace ExceedingZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z;
            int aux;
            int count = 1;

            do
            {
                z = int.Parse(Console.ReadLine());
            } while (z <= x);

            aux = x;

            for (int i = 1; z > aux; i++)
            {
                aux += x + i;
                count++;
            }
            
            Console.WriteLine(count);
        
        }
    }
}
