namespace LeetCode.Essential.String
{
    class LongestSubstringWithoutRepeatingCharactersClass
    {
        /// <summary>
        /// Method-1: HashSet & Two Pointer (Best)
        /// TC: O(n)
        /// SC: O(n)
        /// </summary>

        public int LengthOfLongestSubstring(string s)
        {
            var set = new HashSet<char>();

            int max = 0;
            int start = 0;
            int seen = 0;

            while (seen < s.Length)
            {
                char c = s[seen];

                if (!set.Contains(c))
                {
                    set.Add(c);
                    max = Math.Max(max, seen - start + 1);
                    seen++;
                }
                else
                {
                    set.Remove(s[start]);
                    start++;
                }
            }

            return max;
        }
    }
}
