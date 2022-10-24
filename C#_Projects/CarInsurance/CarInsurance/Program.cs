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
            Console.WriteLine("Car Insurance Approval Program");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine()); //This will save the data inout


            Console.WriteLine("Have you ever had a DUI? \nPlease answer true or false");
            bool DUI = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("How many speeding tickets do you have?");
            int Tickets = Convert.ToInt32(Console.ReadLine());

            bool Qualified = Age >= 15 && DUI == false && Tickets <= 3;

            Console.WriteLine("Qualified?");
            Console.ReadLine();
            Qualified = Convert.ToBoolean(Console.ReadLine());
            if (Qualified)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }


        }
    }
}
