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

 

            Console.WriteLine("Annual salary of Person 1: ");
            double salaryTotal = HrRate * HRperWk * 52;
            Console.WriteLine(salaryTotal);
            Console.ReadLine();

   
            Console.WriteLine("Annual salary of Person 2: ");
            double AnnualSalary = HourRate * HRperWeek * 52;
            Console.WriteLine(AnnualSalary);
            Console.ReadLine();

            

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            bool TrueOrFalse = salaryTotal > AnnualSalary;
            Console.WriteLine(TrueOrFalse);
            Console.ReadLine();

        }
    }
}
