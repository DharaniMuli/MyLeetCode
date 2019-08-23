using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{

    class LargestCommonPrefixCode
    {


        public string findlargestCommonPrefix(string[] myarray)
        {
            if (myarray.Length == 0)
            {
                return "";
            }
            int counter = 0;

            while (counter < myarray[0].Length)
            {

                for (int j = 1; j < myarray.Length; j++)
                {
                    try
                    {
                        if (myarray[0][counter] != myarray[j][counter])
                        {
                            return myarray[0].Substring(0, counter);
                        }
                    }
                    catch (Exception)
                    {

                        return myarray[0].Substring(0, counter);
                    }


                }
                counter++;
            }
            return counter == myarray[0].Length ? myarray[0] : "";
        }

    }
}

