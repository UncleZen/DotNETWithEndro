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

            if (numbers.Length > 0)
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
            else
			{
                throw new Exception("Empty List");
			}

        }



        public int SmallestNumber(int[] numbers)
        {
            if (numbers.Length > 0)
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
            else
			{
                throw new Exception("Empty list");
			}
        }

    }
}
