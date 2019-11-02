using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class StairCase
    {
        public int minCostClimbingStairs(int[] cost)
        {
            int cheapCosti = 0;
            int cheapCostj = 0;

            for (int i = 0; i <= cost.Length; i++)
            {
                if (i == 0)
                {
                    cheapCosti = cost[i];
                }
                try
                {
                    if (cost[i + 1] >= cost[i + 2])
                    {

                        cheapCosti = cheapCosti + cost[i + 2];
                        i = i + 1;
                    }
                    else
                    {
                        cheapCosti = cheapCosti + cost[i + 1];
                    }
                }
                catch (Exception e)
                {
                    return cheapCosti;
                }




            }
            for (int j = 1; j <= cost.Length; j++)
            {
                if (j == 0)
                {
                    cheapCostj = cost[j];
                }
                try
                {
                    if (cost[j + 1] >= cost[j + 2])
                    {
                        cheapCostj = cheapCostj + cost[j + 2];
                        j = j + 1;
                    }
                    else
                    {
                        cheapCostj = cheapCostj + cost[j + 1];
                    }
                }
                catch (Exception e)
                {
                    return cheapCostj;
                }

            }
            if (cheapCosti < cheapCostj)
            {
                return cheapCosti;
            }
            else
            {
                return cheapCostj;
            }
           
        }
    }
}
