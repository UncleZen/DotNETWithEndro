
using System;
using DotNetWithEndro.HW20210504;

namespace DotNetWithEndro.HW20210504.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathhelper = new MathHelper();
            var num1 = 50;
            var num2 = 20;
            var operation = 'A';
            var result = mathhelper.Calculate(num1, num2, operation);
            
            Console.WriteLine($"The result of {operation}: {result}");

            operation = 'D';
            result = mathhelper.Calculate(num1, num2, operation);
            Console.WriteLine($"The result of {operation}: {result}");

            operation = 'S';
            result = mathhelper.Calculate(num1, num2, operation);
            Console.WriteLine($"The result of {operation}: {result}");

            operation = 'M';
            result = mathhelper.Calculate(num1, num2, operation);
            Console.WriteLine($"The result of {operation}: {result}");

            Console.WriteLine("Hello World!");
        }
    }
}
