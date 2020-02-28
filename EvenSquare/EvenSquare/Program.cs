using System;

// 1073 - Even Square

namespace EvenSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int aux = i * i;
                    Console.WriteLine($"{i}^2 = {aux}");                    
                }
            }
        }
    }
}
