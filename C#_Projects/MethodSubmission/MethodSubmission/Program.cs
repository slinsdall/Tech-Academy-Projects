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

            try
            {

                Console.WriteLine("Please put in 2 numbers one at a time,\n Please type the first number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("You do not need to enter a second number.");
                Console.ReadLine();

                Console.WriteLine(method.Math(input));
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not enter 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
