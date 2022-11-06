using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            Maths maths = new Maths();


        foreach (Math math in math.Maths)
        {
            Console.WriteLine("Please pick a number: ");
            int selection = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(math.add(selection));
            Console.ReadLine();

            Console.WriteLine(math.subtract(selection));
            Console.ReadLine();

            Console.WriteLine(math.divide(selection));
            Console.ReadLine();
        }
        }
        
    }

