using System;
using System.Globalization;

//1048 - Salary

namespace Salary_Increase
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double new_salary = 0;
            int inc_percentual = 0;

            if (salary >= 0 && salary <= 400)
            {
                new_salary = salary * 1.15;
                inc_percentual = 15;
            }
            else if (salary >= 400.01 && salary <= 800)
            {
                new_salary = salary * 1.12;
                inc_percentual = 12;
            }
            else if (salary >= 800.01 && salary <= 1200)
            {
                new_salary = salary * 1.1;
                inc_percentual = 10;
            }
            else if (salary >= 1200.01 && salary <= 2000)
            {
                new_salary = salary * 1.07;
                inc_percentual = 7;
            }
            else 
            {
                new_salary = salary * 1.04;
                inc_percentual = 4;
            }

            double increase = new_salary - salary;

            Console.WriteLine("Novo salario: " + new_salary.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + increase.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + inc_percentual + " %");
        }
    }
}
