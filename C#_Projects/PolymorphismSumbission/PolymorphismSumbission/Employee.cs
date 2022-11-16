using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSumbission
{
     public class Employee : Person, IQuittable 
    {
        public List<string> Persons { get; set; }

        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
