using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccerplayerview
{
    class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Country { get; set; }

        public Person(string firstName, string lastName, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Country = country;
        }

    }
}
