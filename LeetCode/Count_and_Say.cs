using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Count_and_Say
    {
        public string CountAndSay(int n)
        {
          
            int result = 1;
            string finalResult="";
            int myResultStringLength = 1;
            int charCount = 1;

            if (n == 1)
            {
                return "1";
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    string myResultString = result.ToString();
                    
                    for (int j = 0; j < myResultStringLength; j++)
                    {
                        try
                        {
                            while(myResultString[j] != myResultString[j + 1])
                            {
                                charCount++;
                            }
                            myResultString= charCount.ToString() + myResultString[j];
                            finalResult = myResultString;
                        }


                        catch
                        {
                            myResultString = charCount.ToString() + myResultString[j];
                            finalResult = myResultString;
                        }
                        charCount = 1;
                    }
                    myResultStringLength = myResultString.Length; 
                }
                return finalResult;
            }
           
            
          
           

          
        }
    }
}
