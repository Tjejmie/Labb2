using System;
using System.Collections.Generic;
using System.Text;

namespace Godiskalkylator
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int Candies { get; set; }
       
        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age}år): {Candies} st";
        }
    }
}
