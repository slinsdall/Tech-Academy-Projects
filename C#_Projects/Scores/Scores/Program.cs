using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nwelcome back {uName}, Today is {date}";
            Console.WriteLine(msg);

            string path = @"C:\Users\slins\OneDrive\Documents\GitHub\Tech-Academy-Projects\C#_Projects\Scores\Scores\StudentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);


            double tScore = 0.0;

            Console.WriteLine("\nStudent Score:  \n");
            foreach(string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avrgScore = tScore / lines.Length;
            Console.WriteLine("\ntotal of " + lines.Length + " student scores. \tAverage score " + avrgScore);

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
            
        }
    }
}
