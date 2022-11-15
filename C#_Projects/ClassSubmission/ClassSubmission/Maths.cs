using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public  class Maths
    {
        public int problem { get; set; }
        public int equation { get; set; }

        public void division(int E)
        {
            int equation = E / 2;
            
        }

        public int division(int H)
        {
            int result = H * 5;
            return result;
        }
       
        public static int ADD(int L, out int add)
        {
            
            int total = L + 9;
            total = add(out add, out L, 5);
            
            return total;
        }
        
    }
}
