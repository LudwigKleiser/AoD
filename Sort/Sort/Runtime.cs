using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Runtime
    {
        public void Start()
        {
            var sorter = new Sorter();
            var numbersFilePath = @"C:\Users\ludde\OneDrive\Dokument\AoD\Sort\Sort\TextFiles\Numbers.txt";
            var numbersData = System.IO.File.ReadAllLines(numbersFilePath);
            var numbers = new List<int>();
            foreach (var number in numbersData)
            {
                string[] splitString = number.Split(',');
                numbers.Add(int.Parse(splitString[0]));

            }

            var intList = new List<int>();

            Console.WriteLine("Before sorting");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Bubble");
            intList = sorter.BubbleSort(numbers);
            foreach (var item in intList)
            {
                Console.WriteLine($"Bubble: {item}");
            }
            Console.WriteLine("Quick");
            intList = sorter.QuickSort(numbers);
            foreach (var item in intList)
            {
                Console.WriteLine($"Quick: {item}");
            }
            Console.WriteLine("Merge");
            intList = sorter.MergeSort(numbers);
            foreach (var item in intList)
            {
                Console.WriteLine($"Merge: {item}");
            }
            Console.ReadKey();
        }
    }
}
