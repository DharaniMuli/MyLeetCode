using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class NeedleInHashTag
    {
        public int StrStr(string haystack, string needle) {

            int haystacklen = haystack.Length;
            int needlelen = needle.Length;
            int c = 0;
            int i;
            int j = c;

            if (needle == "")
            {
                return 0;
            }
            if (haystacklen < needlelen || haystack == "")
            {
              return -1;
            }
            try
            {
            for (i=0;i< haystacklen; i++)
            {
                for (j = 0; j < needlelen; j++)
                {
                    if (haystack[i+j]!= needle[j])
                    {
                        
                        if( i== haystacklen-1)
                        {
                            return -1;
                        }
                        break;
                    }
                    else
                    {
                        if(j== needlelen - 1)
                        {
                            return i;
                        }
                    }
                }
            }
            }
            catch
            {
                return -1;
            }
            return i;

            //if (needle == "")
            //{
            //    return 0;
            //}
            //if(haystacklen < needlelen || haystack == "")
            //{
            //    return -1;
            //}
           
            
            //for(i=0;i< needlelen; i++)
            //{
              
            //    for (j = c; j < haystacklen; j++)
            //    {
            //        try
            //        {
            //            if (needle[i] == haystack[j])
            //            {
                            
            //                c = j+1;
            //                if (i == needlelen-1)
            //                {
            //                    return j - i;
            //                }
            //                break;
                            
                            

            //            }
            //            else if (needle[i] != haystack[j])
            //            {
            //                if (j == haystacklen - 1)
            //                {
            //                    return -1;
            //                }
            //                if(i== needlelen-1)
            //                {
            //                    c = j - (i - 1);
            //                }
            //                i = 0;
                           
                           
            //            }
                       
            //        }
            //        catch
            //        {
            //            return -1;
            //        }
                    
            //    }
                
            //}
            //return j-i;
        }
    }
}
