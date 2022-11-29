using Google.Apis.Admin.Directory.directory_v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            //Create a const variable.
            const string FirstName = "Sarah";
            //Create a variable using the keyword “var.”
            var FullName = "Linsdall";

            User user = new User(FirstName, FullName);
            User user2 = new User("Kirsten");

        }



    }
}
