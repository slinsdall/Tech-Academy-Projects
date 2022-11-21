using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Days day = new Days();

            //Prompt user to enter the current day of the week
            Console.WriteLine("Please enter current day of the week: ");
            string input = Convert.ToString(Console.ReadLine());
            try//Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
            {
                Days.DayOfTheWeek dayOfWeek = (Days.DayOfTheWeek)Enum.Parse(typeof(Days.DayOfTheWeek), input);

            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
                
            }
            finally
            {
                Console.WriteLine("The current day is: " + input);
                
            }
            Console.ReadLine();
        }
    }
}
