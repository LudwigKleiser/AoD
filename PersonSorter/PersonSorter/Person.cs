using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSorter
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long SocialSecurityNumber { get; set; }
        public bool HasPayed { get; set; }

        public void Print()
        {
            if (HasPayed) Console.WriteLine($"Förnamn: {FirstName}, Efternamn: {LastName}, Personnummer: {SocialSecurityNumber}, Har betalt: Ja");
            else if (!HasPayed) Console.WriteLine($"Förnamn: {FirstName}, Efternamn: {LastName}, Personnummer: {SocialSecurityNumber}, Har betalt: Nej");
        }

    }
}
