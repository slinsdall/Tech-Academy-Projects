using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Person person = new Person();
            Employee employee = new Employee();
            employee.Persons = new List<string>() { "Sample", "Student" };
            employee.SayName();
            employee.ID();
            Console.ReadLine();
            
            
        }
    }
}
