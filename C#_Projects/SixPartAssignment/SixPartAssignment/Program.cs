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
            string[] fruit = { "Apple ", "Strawberry ", "Blueberry ", "Banana " };

            //User input text
            Console.WriteLine("Please add text: ");
            string added = Console.ReadLine();

            //A loop that iterates through each string and adds the user input
            for (int i = 0; i < fruit.Length; i++)
            {
                fruit[i] = fruit[i] + added;
                Console.WriteLine(fruit[i]);//Prints off the arrays

            }


                //Part 2
                int count = 0;
                //Create an infinite loop
                while (true)
                {
                    Console.WriteLine("Count = {0}.", count);
                    count++;
                    

                    if (count > 20)//Added if statement to break loop at certain number.
                    {
                        break;
                    }
                    //Part 3
                }
                for (int k = 0; k <= 10; k++)//Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator
                {
                    Console.WriteLine(k);
                    

                    if (k < 50)
                    {
                        Console.WriteLine("Count Completed.");
                    }
                }

                //Part 4
                //List of strings that are unique.
                List<string> cars = new List<string>() { "Subaru", "Toyota", "Dodge" };


                //Ask the user to input text to search for in the list.
                Console.WriteLine("What would you like to search for?");
                string input = Console.ReadLine();

                //A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.
                bool found = false;
                for (int l = 0; l < cars.Count; l++)
                {
                    if (input == cars[l]) //Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.
                    {
                        found = true;
                        Console.WriteLine(l);
                        break;//Add code that stops the loop from executing once a match has been found.
                    }
                }
                if (!found)
                    Console.WriteLine("the user selection was not found");

                //Part 5
                // A list of strings that has at least two identical strings in the list. 
                List<string> states = new List<string>() { "Oregon", "Washington", "Vermont", "California", "Vermont" };

                //Ask the user to select text to search for in the list.
                Console.WriteLine("Please select text to search within list: ");
                string selection = Console.ReadLine();

                //Create a loop that iterates through the list and then displays the indices of the items matching the user-selected text. Ensure to remove any break statements that may prevent your code from returning multiple matches.
                bool search = false;
                for (int m = 0; m < states.Count; m++)
                {
                    

                    //Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                    if (selection == states[m]) 
                    {
                        search = true;
                        Console.WriteLine(m);
                        
                    }
                }
                if (!search)
                    Console.WriteLine("the user selection was not found");

                //Part 6
                //Create a list of strings that has at least two identical strings in the list.
                List<string> teams = new List<string>() { "Seahawkes", "Patriots", "49ers", "Seahawkes", "Giants", "49ers" };
                List<string> seconds = new List<string>();


                //foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list
                foreach (string name in teams)
                {
                    if (seconds.Contains (name))
                    {
                        Console.WriteLine(name + " this item is a duplicate");
                    }
                    else
                    {
                        Console.WriteLine(name + " this item is unique");
                        seconds.Add(name);
                    }
                }

                Console.ReadLine();
        }

            
    }  
}
        
        
        
    

