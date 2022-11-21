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
        public int ID { get; set; }
        
        

        public static bool operator==(Employee employee, Employee employee2)
        {
            
            return employee.ID == employee2.ID;
        }
        public static  bool operator!=(Employee employee, Employee employee2)
        {

            return employee.ID != employee2.ID;
        }


    }   
}
