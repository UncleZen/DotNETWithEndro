using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetWithEndro.HW20210504
{
    public class MathHelper
    {
        public int Calculate(int number1, int number2, char operation)
        {
            var result = 0;
            if(operation == 'A' || operation == 'a')
            {
                result = number1 + number2;
            }
            else if(operation == 'D' || operation == 'd')
            {
                result = number1 / number2; 
            }
            else if (operation == 'S' || operation == 's')
            {
                result = number1 - number2;
            }
            else if (operation == 'M' || operation == 'm')
            {
                result = number1 * number2;
            }


            return result;

        }


    }
}
