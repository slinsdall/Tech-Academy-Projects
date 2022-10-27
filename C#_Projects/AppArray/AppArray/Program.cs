using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[5] { "Hello", "My", "Name", "Is", "Sarah" }; //This creates a string array
            Console.WriteLine("Please select index for string:"); //Asks user for input
            int index = Convert.ToInt32(Console.ReadLine()); //Saves the input
            if (index > 5) //If statement makes sure selection has to be within 5
            {
                Console.WriteLine("Index does not exist."); // if they input more than 5 they get error
            }
            else
            {
                Console.WriteLine(strArray[index]);// if within range it will display
            }
            Console.ReadLine();

            int[] numArray = new int[5] { 7, 16, 28, 149, 6950 }; //This creates an integer array
            Console.WriteLine("Enter selection: "); //User input
            int selection = Convert.ToInt32(Console.ReadLine()); //Saves input
            if (selection > 5)//If statement makes sure selection has to be within 5
            {
                Console.WriteLine("Selection out of range");//if out of index range will show error
            }
            else
            {
                Console.WriteLine(numArray[selection]);//if within range will display
            }
            Console.ReadLine();

            List<string> fruitList = new List<string>(); //This creates a list
            fruitList.Add("Apple"); // This adds items to list
            fruitList.Add("Strawberry");
            fruitList.Add("Grapes");
            fruitList.Add("Banana");
            fruitList.Add("Blueberry");

            Console.WriteLine("Please select index:"); //User input
            int fruit = Convert.ToInt32(Console.ReadLine()); //Saves input
            if (fruit > 5)//If statement makes sure selection has to be within 5
            {
                Console.WriteLine("Index does not exist.");//If out of range will show error
            }
            else
            {
                Console.WriteLine(fruitList[fruit]);//If within range will display
            }
            Console.ReadLine();









        }
    }
}
