using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    public class Program
    {
        static void Main(string[] args)
        {

            Method method = new Method();

            Console.WriteLine("Please put in 2 numbers one at a time,\n Please type the first number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            try
            {

                Console.WriteLine("You do not need to enter a second number. if you would like to add a second number type here: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

              
                Console.WriteLine(method.Math(num2, input));
                

            }
            catch (FormatException ex)
            {
                Console.WriteLine(method.Math(input));
                return;
            }
            
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
