using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment Part One
            // A one-dimensional array of strings
            string[] fruit = { "Apple", "Strawberry", "Blueberry", "Banana" };

            //User input text
            Console.WriteLine("Please add text: ");
            string added = Console.ReadLine();

            //A loop that iterates through each string and adds the user input
            for (int i = 0; i < fruit.Length; i++)
            {
                Console.WriteLine(fruit[i] +  added);//Prints off the arrays
                Console.ReadLine();

                //Part 2
                int count = 0;
                //Create an infinite loop
                while (true)
                {
                    Console.WriteLine("Count = {0}.", count);
                    count++;
                    Console.ReadLine();

                    if (count > 20)//Added if statement to break loop at certain number.
                    {
                        break;
                    }
                    //Part 3
                }
                    for (int k = 0; k <= 10; k++)//Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator
                {
                        Console.WriteLine(k);
                        Console.ReadLine();
                    }
                    //Part 4
                //List of strings that are unique.
                List<string> cars = new List<string>() { "Subaru", "Toyota", "Dodge" };
                

                //Ask the user to input text to search for in the list.
                Console.WriteLine("What would you like to search for?");
                string input = Console.ReadLine();

                //A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
                foreach (string car in cars)
                {
                    if (true)
                    {
                        Console.WriteLine(cars);
                        Console.ReadLine();
                        
                    }
                    else if (cars.Contains(input))
                     {
                        Console.WriteLine(input);
                    }
                    else //checks if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list. 
                    {
                        Console.WriteLine("Input is not in the list.");
                    }
                    while(true) //Add code that stops the loop from executing once a match has been found
                    {
                        break;
                    }
                    
        }
                Console.ReadLine();
                
            }
        }
        }
        
    }

