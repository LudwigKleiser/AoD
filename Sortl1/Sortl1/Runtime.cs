﻿using System;
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



            BubbleSort(numbers);




        }

        private void BubbleSort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j + 1] < numbers[j])
                    {
                        int tempNumber = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tempNumber;

                    }
                    
                }

            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
                
            }
            Console.ReadKey();
        }
    }
}