using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class DuplicateArray
    {
        public int DuplicateNumber(int[] myarray)
        {

            int pos = 1;
            if(myarray== null)
            {
                return 0;
            }
            for (int i = 0; i <= myarray.Length; i++)
            {
                try
                {

                    if (myarray[i] != myarray[i + 1])
                    {

                        myarray[pos] = myarray[i + 1];
                        pos = pos + 1;
                    }

                }
                catch
                {
                    return pos;
                }


            }
            //for (int j = 0; j < myarray.Length; j++)
            //{
            //    Console.WriteLine("{0}  ", myarray[j]);
            //}
            return pos;
        }


        //Remove Particular Dup Element:

//         if(myarray.Length== 0)
//            {
//                return 0;
//            }
//         int pos = 0;
//            for (int i = 0; i<myarray.Length; i++)
//            {
//                try
//                {

//                    if (myarray[i] != val)
//                    {

//                        myarray[pos] = myarray[i];
//                        pos = pos + 1;
//                    }

//}
//                catch
//                {
//                    return pos;
//                }


//            }
           
//            return pos;
        

        //End of Remove particualr dup ele

    }
}
