using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortl1
{
    class Runtime
    {

        public void Start()
        {

           // Filepath declaration 
            var numbersFilePath = @"C:\Users\ludde\OneDrive\Dokument\AoD\Sortl1\Sortl1\TextFiles\Numbers.txt";
            var charactersFilePath = @"C:\Users\ludde\OneDrive\Dokument\AoD\Sortl1\Sortl1\TextFiles\Characters.txt";
            //Get data from files
            var numbersData = System.IO.File.ReadAllLines(numbersFilePath);
            var characterData = System.IO.File.ReadAllLines(charactersFilePath);

            //Lists to be filled from files
            var numbers = new List<int>();
            var chars = new List<char>();
            
            //Adding data to the lists
            foreach (var number in numbersData)
            {
                string[] splitString = number.Split(',');
                numbers.Add(int.Parse(splitString[0]));

            }
            foreach (var character in characterData)
            {
                string[] splitString = character.Split(',');
                chars.Add(char.Parse(splitString[0]));
            }
            

            // Lists to be used for sorting
            var intList = new List<int>();
            var charList = new List<char>();

            //Printing out the lists before sorting.
            Console.WriteLine("Numbers");
            foreach (var number in numbers)
            {
                Console.WriteLine($"Before sorting: {number}");
            }
            Console.WriteLine("Characters");
            foreach (var character in chars)
            {
                Console.WriteLine($"Before sorting: {character}");
            }

            //Calling the Quicksort function while declaring what datatype is to be used.
            charList = SortingMethodsClass<char>.QuickSort(chars);
            intList = SortingMethodsClass<int>.QuickSort(numbers);
            Console.WriteLine("Quick sorting");
            foreach (var item in intList)
            {
                Console.WriteLine($"Quick: {item}");
            }
            foreach (var item in charList)
            {
                Console.WriteLine($"Quick: {item}");
            }
            //Calling the Bubblesort function while declaring what datatype is to be used.
            intList = SortingMethodsClass<int>.BubbleSort(numbers);
            charList = SortingMethodsClass<char>.BubbleSort(chars);
            Console.WriteLine("Bubble sorting");
            foreach (var item in intList)
            {
                Console.WriteLine($"Bubble: {item}");
            }
            foreach (var item in charList)
            {
                Console.WriteLine($"Bubble: {item}");
            }
            //Calling the Mergesort function while declaring what datatype is to be used.
            intList = SortingMethodsClass<int>.MergeSort(numbers);
            charList = SortingMethodsClass<char>.MergeSort(chars);
            Console.WriteLine("Merge sorting");
            foreach (var item in intList)
            {
                Console.WriteLine($"Merge: {item}");
            }
            foreach (var item in charList)
            {
                Console.WriteLine($"Merge: {item}");
            }
          

        }


    }
    internal class SortingMethodsClass<T>
    {
        static internal List<T> BubbleSort(List<T> list)
        {

            for (int i = list.Count - 2; i >= 0; i--)
            {
                //Declaring the current position and the value to its right.
                int currentPosition = i;
                int compare = currentPosition + 1;
                //Loop that runs until CompareElements function returns false
                while (CompareElements(list[currentPosition], list[compare]))
                {
                    list = SwitchElements(list, currentPosition, compare);

                    if (currentPosition < list.Count - 2)
                    {

                        currentPosition = compare;
                        compare++;
                    }
                }
            }
            return list;

        }

            static internal List<T> QuickSort(List<T> list)
        {
            //Copying list
            List<T> listToSort = list.GetRange(0, list.Count);

            //If the list count is <2 return it as it is.
            if (listToSort.Count < 2) return listToSort;

            //              List      Start  Pivot                  End
            SortAroundPivot(listToSort, 0, listToSort.Count / 2, listToSort.Count - 1);

  
            return list;

            

        }
        private static void SortAroundPivot(List<T> listToSort, int start, int pivot, int end)
        {

            if (start >= end) return;
            int wall = start;
            //Switch start and end
            SwitchElements(listToSort, start, end);

            for (int i = wall; i <= end; i++)
            {
                if (!CompareElements(listToSort[i], listToSort[end]))
                {
                    SwitchElements(listToSort, i, wall);
                    wall++;
                }


            }

            SortAroundPivot(listToSort, start, (start + wall - 2) / 2, wall - 2);
            SortAroundPivot(listToSort, wall, (wall + end) / 2, end);

        }
        internal static List<T> MergeSort(List<T> numbers)
        {
            //Calls the Divide function
            return Divide(numbers.GetRange(0, numbers.Count));
        }

        private static List<T> Divide(List<T> list)
        {
            //Splits the list up in two.
            List<T> newList1 = list.GetRange(0, list.Count / 2 + list.Count % 2);
            List<T> newList2 = list.GetRange(list.Count / 2 + list.Count % 2, list.Count / 2);

            if (newList1.Count >= 2) newList1 = Divide(list.GetRange(0, list.Count / 2 + list.Count % 2));
            if (newList2.Count >= 2) newList2 = Divide(list.GetRange(list.Count / 2 + list.Count % 2, list.Count / 2));

            if (newList2.Count == 0) return newList1;
            return SortAndMerge(newList1, newList2);
        }

        private static List<T> SortAndMerge(List<T> list1, List<T> list2)
        {

            List<T> listCombined = new List<T>();

            int list1ToCompare = 0;
            int list2ToCompare = 0;
            bool continueLoop = true;
            while (continueLoop)
            {
                bool ListTwoFirst = CompareElements(list1[list1ToCompare], list2[list2ToCompare]);

                if (ListTwoFirst)
                {
                    listCombined.Add(list2[list2ToCompare]);
                    list2ToCompare++;
                }
                else
                {
                    listCombined.Add(list1[list1ToCompare]);
                    list1ToCompare++;
                }

                if (list2ToCompare == list2.Count)
                {
                    listCombined.AddRange(list1.GetRange(list1ToCompare, list1.Count - list1ToCompare));
                    continueLoop = false;
                }
                else if (list1ToCompare == list1.Count)
                {
                    listCombined.AddRange(list2.GetRange(list2ToCompare, list2.Count - list2ToCompare));
                    continueLoop = false;
                }
            }

            return listCombined;
        }


        internal static bool CompareElements(T element1, T element2)
        {
            //Checking what datatype is being 
            if (typeof(T) == typeof(int))
            {
                //If the type is int we parse both elements to int.
                int a = int.Parse(element1.ToString());
                int b = int.Parse(element2.ToString());
                //If the value of a is greater than b we return true otherwise we return false.
                if (a > b) return true;
                else return false;
            }
            else if (typeof(T) == typeof(char))
            {
                char a = element1.ToString()[0];
                char b = element2.ToString()[0];
                if (a > b) return true;
                else return false;
            }
            throw new Exception("invalid input! Must be ints or chars!");
        }
        
        internal static List<T> SwitchElements(List<T> listToSort, int current, int compare)
        {
            
            T temp = listToSort[current];
            listToSort[current] = listToSort[compare];
            listToSort[compare] = temp;

            return listToSort;
        }



    }
}

