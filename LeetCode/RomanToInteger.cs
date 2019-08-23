using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class RomanToInteger
    {
        public int romanToInteger(string romannumber)
        {

            Dictionary<char, int> romansDictionary = new Dictionary<char, int>();
            romansDictionary.Add('I', 1);
            romansDictionary.Add('V', 5);
            romansDictionary.Add('X', 10);
            romansDictionary.Add('L', 50);
            romansDictionary.Add('C', 100);
            romansDictionary.Add('D', 500);
            romansDictionary.Add('M', 1000);

            int result = 0;
            int x;
            int y;
            //This condition improves efficiency
            if (romannumber == null || romannumber.Length == 0) return 0;

            for (int i = 0; i < romannumber.Length - 1; i++)
            {
                x = romansDictionary[romannumber[i]];
                y = romansDictionary[romannumber[i + 1]];
                if (x >= y)
                {
                    result = result + x;
                }
                else
                {
                    result = result - x;
                }


            }

            result = result + romansDictionary[romannumber[romannumber.Length - 1]];
            return result;

        }
    }
}
