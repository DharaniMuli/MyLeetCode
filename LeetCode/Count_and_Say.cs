using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Count_and_Say
    {
        public void CountAndSay(int n)
        {

            int resultstring = 1;
            string myString = resultstring.ToString();
            int charCount = 1;

            for (int i = 0; i < n; i++)
            {
                try
                {
                    for (int j = 0; j < myString.Length; j++)
                    {
                        if (myString[j] == myString[j + 1])
                        {
                            charCount++;
                            i = i + charCount;
                            myString = charCount.ToString() + myString[j];
                        }
                        else if (myString[j] != myString[j + 1])
                        {
                            myString = charCount.ToString() + myString[j];

                        }

                    }
                }
                catch
                {
                    Console.WriteLine(myString);
                }

            }
                Console.WriteLine(myString);
          
           

          
        }
    }
}
