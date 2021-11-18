using System;
using System.Collections.Generic;
using System.Text;

namespace SwappinNumber
{
    class WithoutUsingThird
    {
        public static void WithoutUsingThirdVariable()
        {

            int num1 = 10, num2 = 20;
            Console.WriteLine("\n\nBefore SWapping number1= " + num1 + ", number2 = " + num2);

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After swapping number1= " + num1 + ", number2 = " + num2);


            int n1 = 10, n2 = 20;
            Console.WriteLine("\n\nBefore SWapping number1= " + n1 + ", number2 = " + n2);

            n1 = n1 * n2;
            n2 = n1 / n2;
            n1 = n1 / n2;
            Console.WriteLine("After swapping number1= " + n1 + ", number2 = " + n2);
        }
    }
}
