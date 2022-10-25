using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Weight of package?");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)//If statements will kick in if user input is above 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else //This will continue questions if the if statement is not needed
            {
                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());

               

                Console.WriteLine("What is the package height?");
                int height = Convert.ToInt32(Console.ReadLine());

                

                Console.WriteLine("What is the package length?");
                int length = Convert.ToInt32(Console.ReadLine());

                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {

                    int dimensions = width * height * length;//This will multiply all dimensions

                    int total = dimensions * weight;//Takes the dimension after multiplication and mutiplies by weight

                    decimal outcome = total / 100;//Takes the total and divides by 100

                    Console.WriteLine("Your estimated total for shipping this package is: $" + outcome);//This will add the sentance with the outcome at the end
                    Console.ReadLine();

                    Console.WriteLine("Thank you!");
                    Console.ReadLine();

                }





            
            }
            
        }
    }
}
