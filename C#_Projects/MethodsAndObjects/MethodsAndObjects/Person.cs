using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void  SayName()
        {
            foreach (string person in Person)
            {
                Console.WriteLine(FirstName + LastName);
                
            }
        }
    }
}
