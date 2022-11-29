using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their age.
            Console.WriteLine("Please enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            //Display the year the user was born.
            DateTime now = DateTime.Now.Year;
            now = now.AddYears(-userAge);
            
            Console.WriteLine(now);
            Console.ReadLine();


            

        }
    }
}
