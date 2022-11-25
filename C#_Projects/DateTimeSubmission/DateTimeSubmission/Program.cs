using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Prints the current date and time to the console.
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
            //Asks the user for a number.
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            //Prints to the console the exact time it will be in X hours, 
            //X being the number the user entered in step 2.
            DateTime currentTime = DateTime.Now;
            DateTime userInput = currentTime.AddHours(input);
            Console.WriteLine(userInput);
            Console.ReadLine();
        }
    }
}
