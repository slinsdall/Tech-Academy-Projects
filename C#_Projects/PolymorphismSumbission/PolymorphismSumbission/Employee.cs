using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSumbission
{
     public class Employee : IQuittable 
    {
        public List<string> Person { get; set; }

        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
