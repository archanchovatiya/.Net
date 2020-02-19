using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4
{
    abstract class Salesman
    {
        public String firstName;
        public String lastName;
        public Salesman(String fName, String lName)
        {
            firstName = fName;
            lastName = lName;
        }
        abstract public void sell();
    }
}
