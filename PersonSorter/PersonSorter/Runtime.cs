using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSorter
{
    class Runtime
    {

        public void Start()
        {
            var people = new List<Person>{
                new Person{ FirstName = "Ludwig", LastName="Kleiser", HasPayed = true, SocialSecurityNumber = 199301161411},
                new Person{ FirstName = "Johan", LastName="Spånberg", HasPayed = false, SocialSecurityNumber = 199301161411},
                new Person{ FirstName = "Olof", LastName="Viking", HasPayed = true, SocialSecurityNumber = 199301161411},
                new Person{ FirstName = "Michael", LastName="Wood", HasPayed = true, SocialSecurityNumber = 199301161411},
                new Person{ FirstName = "Ludwig", LastName="Kleiser", HasPayed = false, SocialSecurityNumber = 199301161411},
                new Person{ FirstName = "Stefan", LastName="Hermansson", HasPayed = true, SocialSecurityNumber = 199301161411},
                new Person{ FirstName = "Dennis", LastName="Leksell", HasPayed = false, SocialSecurityNumber = 199301161411},
                new Person{ FirstName = "Hannes", LastName="Kleiser", HasPayed = false, SocialSecurityNumber = "1993-01-16-5797"},
                new Person{ FirstName = "Ludwig", LastName="Kleiser", HasPayed = true, SocialSecurityNumber = "1993-01-16-2354"},
                new Person{ FirstName = "Michael", LastName="Spånberg", HasPayed = true, SocialSecurityNumber = "1993-01-16-5325"},
                new Person{ FirstName = "Erik", LastName="Dai", HasPayed = false, SocialSecurityNumber = "1993-01-16-1231"},
                new Person{ FirstName = "Max", LastName="Magnusson", HasPayed = true, SocialSecurityNumber = "1993-01-16-7621"},
                new Person{ FirstName = "Jens", LastName="Heiskanen", HasPayed = false, SocialSecurityNumber = "1993-01-16-5645"},
                new Person{ FirstName = "Filip", LastName="Algeman", HasPayed = true, SocialSecurityNumber = "1993-01-16-6457"},
                new Person{ FirstName = "William", LastName="Snell", HasPayed = false, SocialSecurityNumber = "1993-01-16-4564"},
                new Person{ FirstName = "Erik", LastName="Olsson", HasPayed = true, SocialSecurityNumber = "1993-01-16-2345"},
                new Person{ FirstName = "Claes", LastName="Snell", HasPayed = false, SocialSecurityNumber = "1993-01-16-2315"},
                new Person{ FirstName = "Johanna", LastName="Bengtsson", HasPayed = true, SocialSecurityNumber = "1993-01-16-9454"},
                new Person{ FirstName = "Linnea", LastName="Strandberg", HasPayed = false, SocialSecurityNumber = "1993-01-16-4796"},
                new Person{ FirstName = "Ludwig", LastName="Kleiser", HasPayed = false, SocialSecurityNumber = "1993-01-16-2555"}
                };

            
        }
    }
}
