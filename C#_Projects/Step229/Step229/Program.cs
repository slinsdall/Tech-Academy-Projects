using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step229
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you have a driving license? \nPlease answer True or False");
            bool license = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many points do you have on your license?");
            int points = Convert.ToInt32(Console.ReadLine());

            bool qualify = age > 17 && license == true && points <= 5;

            do
            {
               
                
                Console.WriteLine("Do you have your own car? \n Please answer True or False");
                bool vehicle = Convert.ToBoolean(Console.ReadLine());
                break;

                Console.WriteLine("Do you have car insurance?");
                string insurance = Convert.ToString(Console.ReadLine());
                break;

                
            }
            while (qualify);
            Console.Read();
            }
             
                
            
        }
    }

