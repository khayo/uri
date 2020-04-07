using System;

// 1142 - PUM

namespace PUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;

            for (int i = 0; i < n; i++)
            {   
                for (int j = 0; j < 4; j++)
                {
                    if (counter % 4 == 0)
                    {
                        Console.WriteLine("PUM");
                    }
                    else
                    {
                        Console.Write(counter + " ");
                    }
                    counter++;
                }
            }
        }
    }
}
