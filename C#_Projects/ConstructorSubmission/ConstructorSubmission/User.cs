using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class User
    {
        //Create a const variable.
        const string FirstName = "Sarah";
        //Create a variable using the keyword “var.”
        var FullName = "Linsdall";

        //Chain two constructors together
        public string firstName;
        public string fullName;

        public User(string firstName, string fullName)
        {
            this.firstName = firstName;
            this.fullName = fullName;
        }

    }
}
