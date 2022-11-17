using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Employee 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }

        public static Employee operator==(Employee employee)
        {
            employee.Add();
            return employee;
        }
        public static Employee operator!=(Employee employee)
        {
            employee.Add();
            return employee;
        }


    }   
}
