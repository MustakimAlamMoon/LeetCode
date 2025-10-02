namespace Essential.Recursion
{
    class SubsetsClass
    {
        /// <summary>
        /// Method-1: Recursive Backtracking (Best)
        /// TC: O(n × 2^n)
        /// SC: O(n)
        /// </summary>

        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Backtrack(res, new List<int>(), nums, 0);
            return res;
        }

        private void Backtrack(IList<IList<int>> res, List<int> tempList, int[] nums, int start)
        {
            res.Add(new List<int>(tempList));

            for (int i = start; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                Backtrack(res, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
