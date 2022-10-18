using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            double HrRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double HRperWk = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            double HourRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double HRperWeek = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            double salaryTotal = HrRate * HRperWk * 52;

            Console.WriteLine("Annual salary of Person 1: ");
            double SalaryPersonOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(salaryTotal);
            Console.ReadLine();

            double AnnualSalary = HourRate * HRperWeek * 52;

            Console.WriteLine("Annual salary of Person 2: ");
            double SalaryPersonTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(AnnualSalary);
            Console.ReadLine();

            bool TrueOrFalse = SalaryPersonOne < SalaryPersonTwo;

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            Console.WriteLine(TrueOrFalse);
            Console.ReadLine();

        }
    }
}
