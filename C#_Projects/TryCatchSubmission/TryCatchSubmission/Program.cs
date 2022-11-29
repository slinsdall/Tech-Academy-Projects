using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TryCatchSubmission
{
    class Program
    {
        public static DateTime current { get; private set; }

        static void Main(string[] args)
        {
            //Ask the user for their age.
            Console.WriteLine("Please enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            //Display the year the user was born.
            DateTime now = DateTime.Now;

            //Exceptions must be handled using “try/catch.
             
                try
                {
                    Console.WriteLine(now.Year - userAge);
                    Console.ReadLine();
                }
                catch (FormatException)//Display appropriate error messages if the user enters zero or negative numbers.
            {
                    Console.WriteLine("Please do not enter zero or negative numbers.");
                    return;
                }
                catch (Exception ex)//Display a general message if an exception was caused by anything else.
            {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                finally
                {
                    Console.ReadLine();

                }

            

            

        }
    }
}
