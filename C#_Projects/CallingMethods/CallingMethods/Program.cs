using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            math add(Math);

            foreach(Math math in math.Maths)
            {
                Console.WriteLine("Please pick a number: ");
                int selection = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(math.Maths.Count);
            Console.ReadLine();
        }
        
    }
}
