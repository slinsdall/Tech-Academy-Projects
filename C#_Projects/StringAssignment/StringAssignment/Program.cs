using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sarah";
            string car = "Subaru";
            string quote = "Hello, Sarah. You drive a Subaru.";

            name = name.ToUpper();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Sarah \n and I drive a subaru \n Thank you.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
