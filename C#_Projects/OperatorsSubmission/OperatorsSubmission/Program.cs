using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee employee2 = new Employee();

            employee.ID = 1;
            employee2.ID = 2;

            Console.WriteLine(employee == employee2);
            Console.ReadLine();

        }
    }
}
