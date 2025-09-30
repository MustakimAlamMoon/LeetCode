namespace Essential.Array
{
    class TwoSumClass
    {
        /// <summary>
        /// Method-1: Dictionary (Best)
        /// TC: O(n)
        /// SC: O(n)
        /// </summary>

        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                else if (!map.ContainsKey(nums[i]))
                {
                    map.Add(nums[i], i);
                }
            }

            return new int[] {};
        }
    }
}
