namespace LeetCode.Essential.String
{
    class ValidAnagramClass
    {
        /// <summary>
        /// Method-1: Dictionary (Best)
        /// TC: O(n)
        /// SC: O(n)
        /// </summary>

        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var d = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!d.ContainsKey(c))
                {
                    d.Add(c, 1);
                }
                else
                {
                    d[c] += 1;
                }
            }

            foreach (char c in t)
            {
                if (!d.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    d[c] -= 1;
                }
            }

            return d.All(d => d.Value == 0);
        }
    }
}
