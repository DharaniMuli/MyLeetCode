using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start: Palindrome

            //int x = Convert.ToInt32(Console.ReadLine());
            //Palindrome p = new Palindrome();
            //bool reversernumber = p.palindromeFinder(x);

            // End: Palindrome

            //Start: RomanToInteger
            String romannumber = Console.ReadLine();
            RomanToInteger rtoi = new RomanToInteger();
            rtoi.romanToInteger(romannumber);

            //End: RomanToInteger
        }
    }
}
