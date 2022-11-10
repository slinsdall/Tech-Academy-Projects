using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Method
    {
        public int multiply(int E)
        {
            int result = E * 13;
            return result;
        }
        public int multiply(Double D)
        {
            int result = Convert.ToInt32(D + 4);
            return result;
        }
        public int multiply(string S)
        {
            int total = Convert.ToInt32(S) / 7;
            return total;
        }

    }
}
