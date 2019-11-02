using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Pascal
    {
        public static void triangle(int n)
        {
            int[,] a = new int[4, 2];
            for (int i = 1; i <= n + 2; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    a[j, n] = 1;
                    a[j, n - 1] = 1;
                    a[j, n + 1] = 1;
                }

            }
        }
    }
}
