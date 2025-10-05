namespace Essential.SortSearch
{
    class SearchInRotatedSortedArrayClass
    {
        /// <summary>
        /// Method-1: Binary Search (Best)
        /// TC: O(log n)
        /// SC: O(1)
        /// </summary>

        public int Search(int[] nums, int target)
        {
            var s = 0;
            var e = nums.Length - 1;

            while (s <= e)
            {
                var mid = s + (e - s) / 2;

                if (nums[mid] == target) return mid;

                if (nums[s] <= nums[mid])
                {
                    if (target >= nums[s] && target < nums[mid])
                    {
                        e = mid - 1;
                    }
                    else
                    {
                        s = mid + 1;
                    }
                }
                else
                {
                    if (target <= nums[e] && target > nums[mid])
                    {
                        s = mid + 1;
                    }
                    else
                    {
                        e = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}
