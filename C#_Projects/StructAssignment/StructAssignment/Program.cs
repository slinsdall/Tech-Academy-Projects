using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();

            number.Amount = 5;//In the Main() method, create an object of data type Number and assign an amount to it.

            Console.WriteLine(number.Amount);//Print this amount to the console.
            Console.ReadLine();
        }
    }
}
