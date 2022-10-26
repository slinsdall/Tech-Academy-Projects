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
            bool qualify = false;
           


            do
            {
                Console.WriteLine("What is your name?");
                Console.ReadLine();

                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Do you have a driving license? \nPlease answer True or False");
                bool license = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("How many points do you have on your license?");
                int points = Convert.ToInt32(Console.ReadLine());

                if (age > 17 && license == true && points <= 5)
                {

                    Console.WriteLine("Congratualtions you qualify!");
                    qualify = true;

                }
                else
                {
                    Console.WriteLine("Sorry, you do not qualify.");
                }



            }
            while (qualify == false);
            Console.Read();

            int i = 0;

            while(i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

        }
    }
}
                
            
        
    

