using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Palindrome
    {
        public static void FindPalindrome()
        {
            int input, reverse = 0;
            Console.Write("Please enter number for Palindrome ");
            input = Convert.ToInt32(Console.ReadLine());
            //Syntax calling static method -className.methodName()
            reverse = ReverseNumber.MakeItReverse(input);

            if(input == reverse)
            {
                Console.WriteLine("The Given number is palindrome");
            }
            else
            {
                Console.WriteLine("The Given number is not palindrome");
            }
        }
    }
}
