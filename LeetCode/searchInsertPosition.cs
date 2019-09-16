using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class searchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            //int i;
            //for (i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] >= target)
            //    {
            //        return i;
            //    }
            //    else if (i == nums.Length - 1)
            //    {
            //        return i + 1;
            //    }
            //}
            //return 0;
            int n = nums.Length;
            //int result = binarySearch(nums, 0, n - 1, target);
            return n;
        }
        //public int binarySearch(int[] nums, int l,int r, int x)
        //{
        //    if (r >= l)
        //    {
        //        int mid = l + (r - l) / 2;

        //        // If the element is present at the 
        //        // middle itself 
        //        if (nums[mid] == x)
        //            return mid;

        //        // If element is smaller than mid, then 
        //        // it can only be present in left subarray 
        //        if (nums[mid] > x)
        //            return binarySearch(nums, l, mid - 1, x);
        //        if(r == nums.Length - 1 && nums[mid]!= x)
        //        {
        //            return 
        //        }
        //        // Else the element can only be present 
        //        // in right subarray 
        //        return binarySearch(nums, mid + 1, r, x);
        //    }

        //    // We reach here when element is not present 
        //    // in array 
        //    return -1;
        //}
    }
}
