using System;
using System.Text;
using System.Collections.Generic;

// 1146 - Growing Sequences

namespace GrowingSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int n = 1;
            while (n != 0)
            {
                n = int.Parse(Console.ReadLine());
                list.Add(n);
            }

            list.Remove(0);

            foreach (var item in list)
            {
                StringBuilder sb = new StringBuilder("");
                for (int i = 1; i < item; i++)
                {
                    sb.Append(i + " ");
                }
                sb.Append(item);
                Console.WriteLine(sb);
            }
        }

    }
}
