﻿using System;
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
            Console.WriteLine(equation);
        }

        public int division(int H, int J)
        {
            int result = H * J;
            return result;
        }
       
        public static int ADD(int L, out int Add)
        {
            Add = 7;
            int total = L + 9;
         
            return total;
        }
        
    }
}
