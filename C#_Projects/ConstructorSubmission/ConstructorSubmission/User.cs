using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class User
    {
        
        //Chain two constructors together
        public string firstName;
        public string fullName;

        public User(string firstName, string fullName)
        {
            this.firstName = firstName;
            this.fullName = fullName;
        }
        public User(string firstName) :this(firstName, "Unknown")
        {

        }

    }
}
