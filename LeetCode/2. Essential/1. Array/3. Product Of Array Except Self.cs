using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Essential.Array
{
    class ProductOfArrayExceptSelfClass
    {
        /// <summary>
        /// Method-1: Single Array (Best)
        /// TC: O(n)
        /// SC: O(1) - AS: O(n)
        /// </summary>

        public int[] ProductExceptSelf(int[] nums)
        {
            int[] prod = new int[nums.Length];
            prod[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                prod[i] = prod[i - 1] * nums[i - 1];
            }

            int right = 1;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                right = right * nums[i + 1];
                prod[i] = prod[i] * right;
            }

            return prod;
        }
    }
}