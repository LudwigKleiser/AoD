using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    class Fruit
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public bool InStock { get; set; }
        public int Hello { get; set; }

        public void Print()
        {
            string stockText = "";
            if (InStock) stockText = "ja";
            else stockText = "nej";
            Console.WriteLine($"Namn: {Name} Pris: {Price} Finns i lager: {stockText}");
        }
    }
}
