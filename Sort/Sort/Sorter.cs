using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Sorter
    {
        public List<int> BubbleSort(List<int> list)
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

         internal List<int> QuickSort(List<int> list)
        {

            //Copying list
            List<int> listToSort = list.GetRange(0, list.Count);
            //If the list count is <2 return it as it is
            if (listToSort.Count < 2) return listToSort;
            ////              List      Start  Pivot                  End
            SortAroundPivot(listToSort, 0, listToSort.Count / 2, listToSort.Count - 1);

            return listToSort;



        }
        public void SortAroundPivot(List<int> listToSort, int start, int pivot, int end)
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
        internal  List<int> MergeSort(List<int> numbers)
        {
            //Calls the Divide function
            return Divide(numbers.GetRange(0, numbers.Count));
        }

        private  List<int> Divide(List<int> list)
        {
            //Splits the list up in two.
            List<int> newList1 = list.GetRange(0, list.Count / 2 + list.Count % 2);
            List<int> newList2 = list.GetRange(list.Count / 2 + list.Count % 2, list.Count / 2);

            if (newList1.Count >= 2) newList1 = Divide(list.GetRange(0, list.Count / 2 + list.Count % 2));
            if (newList2.Count >= 2) newList2 = Divide(list.GetRange(list.Count / 2 + list.Count % 2, list.Count / 2));

            if (newList2.Count == 0) return newList1;
            return SortAndMerge(newList1, newList2);
        }

        private  List<int> SortAndMerge(List<int> list1, List<int> list2)
        {

            List<int> listCombined = new List<int>();

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


        internal  bool CompareElements(int element1, int element2)
        {
           
                //If the type is int we parse both elements to int.
                int a = int.Parse(element1.ToString());
                int b = int.Parse(element2.ToString());
                //If the value of a is greater than b we return true otherwise we return false.
                if (a > b) return true;
                else return false;
            
           
            
            
            
        }

        public  List<int> SwitchElements(List<int> listToSort, int current, int compare)
        {

            int temp = listToSort[current];
            listToSort[current] = listToSort[compare];
            listToSort[compare] = temp;

            return listToSort;
        }
    }
}
