namespace Essential.Array
{
    class MaximumSubarrayClass
    {
        /// <summary>
        /// Method-1: Optimized (Best)
        /// TC: O(n)
        /// SC: O(1)
        /// </summary>

        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int cur = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                cur = Math.Max(cur + nums[i], nums[i]);
                max = Math.Max(cur, max);
            }

            return max;
        }
    }
}
