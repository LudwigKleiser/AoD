using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSorter
{
    class Sorter
    {
        internal List<Person> SortBySocialSecurityNumber(List<Person> people)
        {
            return people.OrderBy(o => o.SocialSecurityNumber).ToList();
        }

        internal List<Person> SortByLastName(List<Person> people)
        {
            return people.OrderBy(o => o.LastName).ToList();
        }

        internal List<Person> SortByHasPayed(List<Person> people)
        {
            return people.Where(o => o.HasPayed == false).ToList();
        }
    }
}
