using System;
using System.Collections.Generic;

// 1099 - Sum of Consecutive Odd Numbers II

namespace SumOfConsecutiveOddNumbersII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sum = new int[n];
            List<int> finalValues = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string values = Console.ReadLine();
                string[] val = values.Split(' ');
                int n1 = int.Parse(val[0]);
                int n2 = int.Parse(val[1]);

                List<int> sumList = new List<int>();

                if (n1 > n2) 
                {
                    int aux = 0;
                    aux = n1;
                    n1 = n2;
                    n2 = aux;
                }
                for (int j = (n1 + 1); j <= (n2 - 1); j++) 
                {
                    if (j % 2 != 0) 
                    {
                        sumList.Add(j);
                    }
                }
                int finalSum = 0;
                foreach (var item in sumList)
                {
                    finalSum += item;
                }
                finalValues.Add(finalSum);
            }

            foreach (var item in finalValues)
            {
                Console.WriteLine(item);
            }
        }
    }
}
