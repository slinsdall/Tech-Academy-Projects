using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> whole = new List<int>() { 12, 58, 16, 93, 350, 846 };//List of intergers
            try
            {
                Console.WriteLine("Pick a number to divide by: ");
                int numberInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing all numbers...");
                int total = whole[0] / numberInput;
                int total1 = whole[1] / numberInput;
                int total2 = whole[2] / numberInput;
                int total3 = whole[3] / numberInput;
                int total4 = whole[4] / numberInput;
                Console.WriteLine(whole[0] + " divided by " + numberInput + " = " + total);
                Console.ReadLine();
                Console.WriteLine(whole[1] + " divided by " + numberInput + " = " + total1);
                Console.ReadLine();
                Console.WriteLine(whole[2] + " divided by " + numberInput + " = " + total2);
                Console.ReadLine();
                Console.WriteLine(whole[3] + " divided by " + numberInput + " = " + total3);
                Console.ReadLine();
                Console.WriteLine(whole[4] + " divided by " + numberInput + " = " + total4);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type number. ");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero. ");
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
