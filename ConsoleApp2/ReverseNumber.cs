using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ReverseNumber
    {
        //Method to reverse the input number
        public static int MakeItReverse(int number)
        {
            int remainder = 0, reverse = 0;
            while (number != 0) //Condition for while loop
            {
                remainder = number % 10;
                reverse = remainder + (reverse * 10);
                number = number / 10;
            }
            //To show the reverse number
          
            Console.WriteLine("After Reverse: {0} ", reverse);
            return reverse;
        }

    }
}
