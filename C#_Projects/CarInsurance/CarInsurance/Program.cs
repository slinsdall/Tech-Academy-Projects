using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Approval Program");//This is just the title of the program
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine()); //This will save the data input


            Console.WriteLine("Have you ever had a DUI? \nPlease answer true or false");
            bool DUI = Convert.ToBoolean(Console.ReadLine());//This will save the input data


            Console.WriteLine("How many speeding tickets do you have?");
            int Tickets = Convert.ToInt32(Console.ReadLine());//This saves the input data

  

            Console.WriteLine("Qualified?");
            Console.ReadLine();
            if (Age >= 15 && DUI == false && Tickets <= 3) // This will specify the qualification points
            {
                Console.WriteLine("True");//If the qualification specifities are met it will show true
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");//If the qualification specifities are not met it will show false
                Console.ReadLine();
            }
          

           
           


        }
    }
}
