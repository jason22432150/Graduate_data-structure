using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/two-sum/description/

namespace _1.Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = solution.TwoSum(nums, target);
            for (int i = 0; i <= result.Length - 1; i++)
            {
                Console.WriteLine(result);
            }
            Console.Read();
        }
    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = 0; j <= nums.Length - 1; j++)
                {
                    if (i != j && nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return null;
        }
    }
}
