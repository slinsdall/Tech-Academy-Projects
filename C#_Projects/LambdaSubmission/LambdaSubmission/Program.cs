using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create a list of at least 10 employees. 
            //At least two employees should have the first name “Joe”.
            Employee employee = new Employee();

            List<string> employees = new List<string>();

            List<Employee> newList = new List<Employee>() { new Employee() { ID = 1, FirstName = "Sarah", LastName = "Keating" }, new Employee() { ID = 2, FirstName = "Kirsten", LastName = "Keating" }, new Employee() { ID = 3, FirstName = "Joe", LastName = "Luscombe" }, new Employee() { ID = 4, FirstName = "Nicole", LastName = "Hart" }, new Employee() { ID = 5, FirstName = "Joe", LastName = "Smith" }, new Employee() { ID = 6, FirstName = "Aaron", LastName = "Chandler" }, new Employee() { ID = 7, FirstName = "Emma", LastName = "Arnts" }, new Employee() { ID = 8, FirstName = "Rachel", LastName = "Willis" }, new Employee() { ID = 9, FirstName = "Leah", LastName = "Jordan" }, new Employee() { ID = 10, FirstName = "Carys", LastName = "Mills" } };
            //Using a foreach loop, create a new list of all employees with the first name “Joe”. 
            //In your comparison statement, remember to reference the property of the object you are checking.
            foreach(Employee employees2 in newList)
            {
                Console.WriteLine(employees2.FirstName == "Joe");
                Console.ReadLine();
            }

            //Perform the same action again, but this time with a lambda expression.
            List<Employee> newList2 = new List<Employee>() { new Employee() { ID = 1, FirstName = "Sarah", LastName = "Keating" }, new Employee() { ID = 2, FirstName = "Kirsten", LastName = "Keating" }, new Employee() { ID = 3, FirstName = "Joe", LastName = "Luscombe" }, new Employee() { ID = 4, FirstName = "Nicole", LastName = "Hart" }, new Employee() { ID = 5, FirstName = "Joe", LastName = "Smith" }, new Employee() { ID = 6, FirstName = "Aaron", LastName = "Chandler" }, new Employee() { ID = 7, FirstName = "Emma", LastName = "Arnts" }, new Employee() { ID = 8, FirstName = "Rachel", LastName = "Willis" }, new Employee() { ID = 9, FirstName = "Leah", LastName = "Jordan" }, new Employee() { ID = 10, FirstName = "Carys", LastName = "Mills" } };
            string count = newList2.employees.Count(x => x.FirstName == FirstName.Joe).ToList();

            foreach (Employee employees in newList2)
            {
                Console.WriteLine(count);
                Console.ReadLine();
            }
            //Using a lambda expression, make a list of all employees with an Id number greater than 5
            int numbID = newList2.Where(ID => ID < 5).ToList;
            Console.WriteLine(numbID);
            Console.ReadLine();

        }
    }
}
