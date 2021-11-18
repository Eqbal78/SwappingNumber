using System;
using System.Collections.Generic;
using System.Text;

namespace SwappinNumber
{
    class UsingThirdVariable
    {
        public static void ThirdVariable()
        {
            int number1 = 10, number2 = 20, temp = 0;
            Console.WriteLine("Before SWapping number1= " + number1 + ", number2 = " + number2);
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After swapping number1= " + number1 + ", number2 = " + number2);
        }

    }
}
