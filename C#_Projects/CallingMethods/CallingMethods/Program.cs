using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Program
    {
        static void Main(string[] args)
        {
                Math maths = new Math();
        
            
                Console.WriteLine("Please pick a number: ");
                int selection = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(maths.add(selection));
                Console.ReadLine();

                Console.WriteLine(maths.subtract(selection));
                Console.ReadLine();

                Console.WriteLine(maths.divide(selection));
                Console.ReadLine();
            
        }
        
    }

