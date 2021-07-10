using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccerplayerview
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }

        public Person(string firstname, string lastname, string country)
        {
            FirstName = firstname;
            LastName = lastname;
            Country = country;
        }

    }
}
