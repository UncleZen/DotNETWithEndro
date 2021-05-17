using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetWithEndro.HW20210517
{
    public class ListHelper
    {
        public int SumOfAllItems(int[] numbers)
        {
            var sum = 0;
            foreach (var item in numbers)
            {
                sum = sum + item;

            }

            return sum;

        }

        public int LargestNumber(int[] numbers)
        {

            var max = numbers[0];
            foreach (var item in numbers)
            {
                if (max < item)
                {
                    max = item;
                }
            } 
            return max;




        }
        public int SmallestNumber(int[] numbers)
        {

            var min = numbers[0];
            foreach (var item in numbers)
            {
                if (min > item)
                {
                    min = item;
                }           
            }
            return min;

        }

    }
}
