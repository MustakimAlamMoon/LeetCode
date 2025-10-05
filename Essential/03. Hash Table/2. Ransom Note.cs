namespace Essential.HashTable
{
    class RansomNoteClass
    {
        /// <summary>
        /// Method-1: Dictionary (Best)
        /// TC: O(m + n)
        /// SC: O(n)
        /// </summary>

        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length) return false;

            var d = new Dictionary<char, int>();

            foreach (char c in magazine)
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

            foreach (char c in ransomNote)
            {
                if (!d.ContainsKey(c) || d[c] == 0)
                {
                    return false;
                }
                else
                {
                    d[c] -= 1;
                }
            }

            return true;
        }
    }
}