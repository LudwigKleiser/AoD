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
                new Person{ FirstName = "Johan", LastName="Spånberg", HasPayed = false, SocialSecurityNumber = 192202162322},
                new Person{ FirstName = "Olof", LastName="Viking", HasPayed = true, SocialSecurityNumber = 198605125383},
                new Person{ FirstName = "Michael", LastName="Wood", HasPayed = true, SocialSecurityNumber = 198808171376},
                new Person{ FirstName = "Karl-Johan", LastName="Kleiser", HasPayed = false, SocialSecurityNumber = 192204090190},
                new Person{ FirstName = "Stefan", LastName="Hermansson", HasPayed = true, SocialSecurityNumber = 196401011282},
                new Person{ FirstName = "Dennis", LastName="Leksell", HasPayed = false, SocialSecurityNumber = 193202162322},
                new Person{ FirstName = "Hannes", LastName="Kleiser", HasPayed = false, SocialSecurityNumber = 194605125383},
                new Person{ FirstName = "Marcus", LastName="Lund", HasPayed = true, SocialSecurityNumber = 199808171376},
                new Person{ FirstName = "Michael", LastName="Spånberg", HasPayed = true, SocialSecurityNumber = 196204090190},
                new Person{ FirstName = "Erik", LastName="Dai", HasPayed = false, SocialSecurityNumber = 196501011282},
                new Person{ FirstName = "Max", LastName="Magnusson", HasPayed = true, SocialSecurityNumber = 191902262322},
                new Person{ FirstName = "Jens", LastName="Heiskanen", HasPayed = false, SocialSecurityNumber = 197705121383},
                new Person{ FirstName = "Filip", LastName="Algeman", HasPayed = true, SocialSecurityNumber = 198208171366},
                new Person{ FirstName = "William", LastName="Snell", HasPayed = false, SocialSecurityNumber = 197104090990},
                new Person{ FirstName = "Erik", LastName="Olsson", HasPayed = true, SocialSecurityNumber = 199901011232},
                new Person{ FirstName = "Claes", LastName="Snell", HasPayed = false, SocialSecurityNumber = 200104033843},
                new Person{ FirstName = "Johanna", LastName="Bengtsson", HasPayed = true, SocialSecurityNumber = 197712249543},
                new Person{ FirstName = "Linnea", LastName="Strandberg", HasPayed = false, SocialSecurityNumber = 194502104354},
                new Person{ FirstName = "Ann-Louise", LastName="Strand", HasPayed = false, SocialSecurityNumber = 196401174359}
                };
            var sorter = new Sorter();
            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("1. Sortera på ålder");
                Console.WriteLine("2. Sortera på efternamn");
                Console.WriteLine("3. Visa medlemmar som inte har betalt");
                Console.WriteLine("4. Sök Personnummer eller efternamn");
                Console.WriteLine("5. Stäng program");
                bool isNumber = false;
                int switchInt = 0;
                while (!isNumber)
                {
                    string input = Console.ReadLine();
                    isNumber = int.TryParse(input, out switchInt);
                    if (!isNumber) Console.WriteLine("Please enter a number");
                }
                switch (switchInt)
                {
                    case 1:
                        List<Person> sortedListSSN = sorter.SortBySocialSecurityNumber(people);
                        foreach (var person in sortedListSSN)
                        {
                            person.Print();
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        List<Person> sortedListLN = sorter.SortByLastName(people);
                        foreach (var person in sortedListLN)
                        {
                            person.Print();
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        List<Person> sortedListHP = sorter.SortByHasPayed(people);
                        foreach (var person in sortedListHP)
                        {
                            person.Print();
                        }
                        Console.ReadKey();
                        break;

                    case 4:

                        break;

                    case 5:

                        run = false;
                        break;

                    default:

                        break;
                }
            }
            
            
        }
    }
}
