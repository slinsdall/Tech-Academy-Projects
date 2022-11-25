using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user for a number.
            Console.WriteLine("Please enter a number: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            //Logs that number to a text file.
            using (StreamWriter file = new StreamWriter(@"C:\Users\slins\Logs\log.txt", true))
            {
                file.WriteLine(inputNum);
            }
            //Prints the text file back to the user.
            Console.WriteLine(inputNum);
            Console.ReadLine();

        }
    }
}
