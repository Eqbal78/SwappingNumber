using System;
using System.Collections.Generic;
using System.Text;

namespace SwappinNumber
{
    class UsingEquation
    {
        public static void EquationSwap()
        {
            int x = 5, y = 10;
            Console.WriteLine("Before SWapping number1= " + x + ", number2 = " + y);
            x = x ^ y ^ (y = x);
            Console.WriteLine("After swapping number1= " + x + ", number2 = " + y);
        }
    }
}
