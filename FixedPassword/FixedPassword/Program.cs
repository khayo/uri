using System;


//1114 - Fixed Password

namespace FixedPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            int pass = 2002;
            int input;
            do
            {
                 input = int.Parse(Console.ReadLine());
                if (pass != input)
                {
                    Console.WriteLine("Senha Invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                }

            } while (pass != input );
        }
    }
}
