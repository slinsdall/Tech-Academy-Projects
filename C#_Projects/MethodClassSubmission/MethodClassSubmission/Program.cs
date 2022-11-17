using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            
            math.numbs(7, 12);

            math.numbs(L: 7, G: 6);

            Console.ReadLine();
        }
        
    }
}
