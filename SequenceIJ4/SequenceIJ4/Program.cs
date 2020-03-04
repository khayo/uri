using System;
using System.Globalization;
using System.Text;

// 1098 - Sequence IJ 4

namespace SequenceIJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            for (double i = 0; i <= 2; i += 0.2)
            {
                for (int j = 1; j <= 3 ; j++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("I=");
                    if ((Math.Round(i,8) * 10) % 10 == 0) 
                    {
                        sb.Append((int)Math.Round(i,8));
                    }
                    else
                    {
                        sb.Append(i.ToString("F1", CultureInfo.InvariantCulture));
                    }

                    sb.Append(" J=");

                    if (((j+n) * 10) % 10 == 0) 
                    {
                        sb.Append((int)j+n);
                    }
                    else
                    {
                        sb.Append((j + n).ToString("F1", CultureInfo.InvariantCulture));
                    }
                    
                    Console.WriteLine(sb);
                }
                n += 0.2;
            }
        }
    }
}
