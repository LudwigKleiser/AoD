using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
   

    class Runtime
    {
        public List<Fruit> Fruitlist { get; set; } = new List<Fruit>();
        public void Start()
        {
            Fruitlist.Add(new Fruit {Name = "Banan", Price = 4, InStock = true });
            Fruitlist.Add(new Fruit {Name = "Äpple", Price = 5, InStock = false });
            Fruitlist.Add(new Fruit {Name = "Vattenmelon", Price = 13, InStock = true });
            Fruitlist.Add(new Fruit {Name = "Jordgubbe", Price = 10, InStock = true });
            Fruitlist.Add(new Fruit {Name = "Korv", Price = 41, InStock = true });
            PrintList();

        }

        public void PrintList()
        {
            foreach (var fruit in Fruitlist)
            {
                fruit.Print();

            }
            Console.ReadLine();
        }
    }
}
