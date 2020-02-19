using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_4
{
    class RetailSalesman : Salesman
    {
        public RetailSalesman(String fName, String lName) : base(fName, lName)
        {
        }
        public String fullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
        override public void sell()
        {
            Console.WriteLine("My name is " + fullName + " and i recommanded you to buy this pen.");
        }
    }
}
