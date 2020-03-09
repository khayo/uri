using System;
using System.Collections.Generic;
using System.Text;

// 1101 - Sequence od Numbers And Sum

namespace SequenceOfNumbersAndSum
{
    class Sequence
    {
        public int Initial { get; set; }
        public int Final { get; set; }
        public List<int> Numbers { get; set; }

        public Sequence()
        {

        }

        public Sequence(int initial, int final)
        {
            Initial = initial;
            Final = final;
            List<int> numbers = new List<int>();
            for (int i = initial; i <= final; i++)
            {
                numbers.Add(i);
            }
            Numbers = numbers;
        }


        public override string ToString()
        {
            int sum = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var item in Numbers)
            {
                
                sb.Append(item + " ");
                sum += item;
            }

            sb.Append("Sum=");
            sb.Append(sum);
            return sb.ToString();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            
            List<Sequence> list = new List<Sequence>();

            int n = 0;
            int m = 0; 
            
            do
            {
                string values = Console.ReadLine();
                string[] vs = values.Split();
                n = int.Parse(vs[0]);
                m = int.Parse(vs[1]);
                
                //estou colocando aqui para que durante a garbage colection o  objeto seja excluido e possa ser criado novamente
                Sequence seq;

                // garante que o maior valor será passado como valor inicial para o contrutor
                if (m > n)
                {
                    seq = new Sequence(n, m);
                }
                else
                {
                    seq = new Sequence(m, n);
                }

                // adiciona a sequencia a lista caso m ou n nao sejam 0
                if (m > 0 && n > 0)
                {
                    list.Add(seq);
                }
                                             
            } while (m > 0 && n > 0 );

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
