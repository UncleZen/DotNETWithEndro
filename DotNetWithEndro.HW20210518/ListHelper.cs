using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetWithEndro.HW20210518
{
    public class ListHelper
    {
        public bool IsEmpty(int[] list)
        {
            var check = false;
            if (list.Length > 0)
            {
                check = false;  
            }
            else
            {
                check = true;
            }
            return check;
        }

       public int SumOfOddNum(int[] numbers)
        {
            var sum = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 1)
                {
                    sum = sum + item;
                }

            }



            return sum;
        }

        public int SumOfEvenNum(int[] numbers)
        {
            var sum = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    sum = sum + item;
                }

            }



            return sum;
        }

        public bool ContainsItem(string[] list,string searchString)
        {
            var contains = false;
            foreach (var item in list)
            {
                if (item == searchString)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }



    }
}
