namespace Essential.String
{
    class ValidPalindromeClass
    {
        /// <summary>
        /// Method-1: Two Pointer (Best)
        /// TC: O(n)
        /// SC: O(1)
        /// </summary>
        
        public bool IsPalindrome(string s)
        {
            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                else
                {
                    if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    {
                        return false;
                    }

                    left++;
                    right--;
                }
            }

            return true;
        }
    }
}