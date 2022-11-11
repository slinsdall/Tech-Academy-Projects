using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();

            Console.WriteLine("Please type a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(method.multiply(input));
            Console.ReadLine();

            Console.WriteLine("Please type a decimal number: ");
            decimal selection = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(method.multiply(selection));
            Console.ReadLine();

            Console.WriteLine("Please type a number by the word: ");
            int typed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(method.multiply(typed));
            Console.ReadLine();


        }
    }
}
