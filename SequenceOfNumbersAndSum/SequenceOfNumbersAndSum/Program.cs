using System;
using System.Collections.Generic;

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
            this.ListNumbers();
        }

        public void ListNumbers()
        {
            for (int i = Initial; i <= Final; i++)
            {
                List<int> numbers = new List<int>();
                numbers.Add(i);
                Numbers = numbers;
            }            
        }

        public override string ToString()
        {
            int sum = 0;
            foreach (var item in Numbers)
            {
                sum += item;
            }
            return sum.ToString();
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
                if (m != 0 && n != 0)
                {
                    list.Add(seq);
                }
                                             
            } while (m != 0 && n != 0);

            foreach (var item in list)
            {                
                item.ToString();
            }
            
        }
    }
}
