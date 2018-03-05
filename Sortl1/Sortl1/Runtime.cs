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
                -123,
                -1523,
                 4554,
                -10000,
                 10000,
                 949,
                 4306,
                -3423,
                 3554,
                 43
            };
            

            //BubbleSort(numbers);
            //MergeSort(numbers);
            QuickSort(numbers);
            //while (true)
            //{

            //    Console.WriteLine("Skriv in ett tal");
            //    var a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Skriv in ett till tal");
            //    var b = int.Parse(Console.ReadLine());
            //    while(b > 0)
            //    {
            //        int c = a % b;
            //        a = b;
            //        b = c;
            //    }
            //    Console.WriteLine("Den största gemensama nämnaren faktor =" + a);


            //    //var result = EuklidesTest(a, b);
            //Console.WriteLine(result);

        }






    //}

    private void BubbleSort(List<int> numbers)
    {
            var listToBeSorted = numbers;
        for (int i = 0; i < listToBeSorted.Count; i++)
        {
            for (int j = 0; j < listToBeSorted.Count - 1; j++)
            {
                if (listToBeSorted[j + 1] < listToBeSorted[j])
                {
                    int tempNumber = listToBeSorted[j];
                        listToBeSorted[j] = numbers[j + 1];
                        listToBeSorted[j + 1] = tempNumber;

                }

            }

        }

        foreach (var number in listToBeSorted)
        {
            Console.WriteLine($"Bubble: {number}");

        }
        Console.ReadKey();
    }
        private void MergeSort(List<int> numbers)
        {

        }

        private void QuickSort(List<int> numbers)
        {
            var listToBeSorted = numbers;

            int pivot = listToBeSorted.Count()-1;

            for (int i = 0; i < pivot; i++)
            {
                if(listToBeSorted[i] > listToBeSorted[pivot])
                {
                    listToBeSorted.Add(listToBeSorted[i]);
                    listToBeSorted.RemoveAt(i);
                    pivot--;
                    i--;
                }
                
            }
            foreach (var number in listToBeSorted)
            {
                Console.WriteLine($"Quicksort: {number}");
                
            }
            Console.WriteLine("split");
            Console.ReadKey();
            
            QuickSort(listToBeSorted);
        }
    private int EuklidesTest(int a, int b)
    {
        if (a == 0)
            return b;
        if (b == 0)
            return a;

        if (a > b)
            return EuklidesTest(a % b, b);
        else
            return EuklidesTest(a, b % a);
    }
}
}
