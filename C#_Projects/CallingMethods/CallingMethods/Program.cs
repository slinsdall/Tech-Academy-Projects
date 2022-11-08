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

                Console.WriteLine(Math.add(selection));
                Console.ReadLine();

                Console.WriteLine(Math.subtract(selection));
                Console.ReadLine();

                Console.WriteLine(Math.divide(selection));
                Console.ReadLine();
            
        }
        
    }

