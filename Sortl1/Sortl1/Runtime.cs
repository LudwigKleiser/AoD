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
            var numbers = new List<int>()
            {
                -123,-1523,4554,-10000,10000,3456,-4306,-3423,3554,43
            };
            List<char> chars = new List<char> {
                'g', 'a', 'b', 'l', 'q', 't', 'w', 'c', 'u', 'n'
            };

            var intList = new List<int>();
            var charList = new List<char>();
            charList = SortingMethodsClass<char>.QuickSort(chars);
            intList = SortingMethodsClass<int>.QuickSort(numbers);
            foreach (var item in intList)
            {
                Console.WriteLine($"Quick: {item}");
            }
            foreach (var item in charList)
            {
                Console.WriteLine($"Quick: {item}");
            }
            intList = SortingMethodsClass<int>.BubbleSort(numbers);
            charList = SortingMethodsClass<char>.BubbleSort(chars);
            foreach (var item in intList)
            {
                Console.WriteLine($"Bubble: {item}");
            }
            foreach (var item in charList)
            {
                Console.WriteLine($"Bubble: {item}");
            }
            intList = SortingMethodsClass<int>.MergeSort(numbers);
            charList = SortingMethodsClass<char>.MergeSort(chars);
            foreach (var item in intList)
            {
                Console.WriteLine($"Merge: {item}");
            }
            foreach (var item in charList)
            {
                Console.WriteLine($"Merge: {item}");
            }
            //BubbleSort(numbers);
            //MergeSort(numbers);
            //QuickSort(numbers);

        }

        //private void BubbleSort(List<int> numbers)
        //{
        //    var listToBeSorted = numbers;
        //    for (int i = 0; i < listToBeSorted.Count; i++)
        //    {
        //        for (int j = 0; j < listToBeSorted.Count - 1; j++)
        //        {
        //            if (listToBeSorted[j + 1] < listToBeSorted[j])
        //            {
        //                int tempNumber = listToBeSorted[j];
        //                listToBeSorted[j] = listToBeSorted[j + 1];
        //                listToBeSorted[j + 1] = tempNumber;

        //            }

        //        }

        //    }

        //    foreach (var number in listToBeSorted)
        //    {
        //        Console.WriteLine($"Bubble: {number}");

        //    }
        //    Console.ReadKey();
        //}
        //private void MergeSort(List<int> numbers)
        //{

        //}

        //private void QuickSort(List<int> numbers)
        //{
        //    var listToBeSorted = numbers;

        //    int pivot = listToBeSorted.Count() - 1;

        //    for (int i = 0; i < pivot; i++)
        //    {
        //        if (listToBeSorted[i] > listToBeSorted[pivot])
        //        {
        //            listToBeSorted.Add(listToBeSorted[i]);
        //            listToBeSorted.RemoveAt(i);
        //            pivot--;
        //            i--;
        //        }

        //    }
        //    foreach (var number in listToBeSorted)
        //    {
        //        Console.WriteLine($"Quicksort: {number}");

        //    }
        //    Console.WriteLine("split");
        //    Console.ReadKey();

        //    //QuickSort(listToBeSorted);
        //}

    }
    internal class SortingMethodsClass<T>
    {
        static internal List<T> BubbleSort(List<T> list)
        {
            List<T> newList = list.GetRange(0, list.Count);
            for (int i = list.Count - 2; i >= 0; i--)
            {
                int currentPosition = i;
                int compare = currentPosition + 1;
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

        internal static List<T> QuickSort(List<T> list)
        {
            List<T> listToSort = list.GetRange(0, list.Count);

            if (listToSort.Count < 2) return listToSort;

            SortAroundPivot(listToSort, 0, listToSort.Count / 2, listToSort.Count - 1);

            return listToSort;
        }
        internal static List<T> MergeSort(List<T> numbers)
        {
            return Divide(numbers.GetRange(0, numbers.Count));
        }

        private static List<T> Divide(List<T> list)
        {
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
            if (typeof(T) == typeof(int))
            {
                int a = int.Parse(element1.ToString());
                int b = int.Parse(element2.ToString());
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
        private static void SortAroundPivot(List<T> listToSort, int start, int pivot, int end)
        {
            if (start >= end) return;
            int wall = start;
            SwitchElements(listToSort, pivot, end);

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
        internal static List<T> SwitchElements(List<T> listToSort, int current, int compare)
        {
            T temp = listToSort[current];
            listToSort[current] = listToSort[compare];
            listToSort[compare] = temp;

            return listToSort;
        }



    }
}

