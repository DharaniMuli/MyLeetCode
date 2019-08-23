using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Palindrome
    {
        public bool palindromeFinder(int x)

        {
            int reverse = 0;
            int givenNumber = x;
            if (x < 0)
            {
                return false;
            }
            if (x == 0)
            {
                return true;
            }

            while (x != 0)
            {
                reverse = reverse * 10 + x % 10;
                x = x / 10;
            }
            Console.WriteLine(reverse);
            return reverse == givenNumber;
        }
    }
}
