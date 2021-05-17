using System;
using DotNetWithEndro.HW20210517;


namespace DotNetWithEndro.HW20210517.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var listhelper = new ListHelper();

            var myarray = new int[5]
            {
                3,6,9,12,22
            };

            var sum = listhelper.SumOfAllItems(myarray);
            var max = listhelper.LargestNumber(myarray);
            var min = listhelper.SmallestNumber(myarray);

            Console.WriteLine($"Sum:{sum}, Max:{max}, Min:{min}");



            Console.WriteLine("Hello World!");
        }
    }
}
