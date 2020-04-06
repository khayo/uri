using System;

// 1134 - Type of Diesel

namespace TypeOfFuel
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod = 0, alc = 0, gas = 0, die = 0; //ainda está feio!

            while (cod != 4)
            {
                cod = int.Parse(Console.ReadLine());

                switch (cod)
                {
                    case 1:
                        alc++;
                        break;
                    case 2:
                        gas++;
                        break;
                    case 3:
                        die++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alc);
            Console.WriteLine("Gasolina: " + gas);
            Console.WriteLine("Diesel: " + die);
        }
    }
}
