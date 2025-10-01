namespace Essential.Recursion
{
    class GenerateParenthesesClass
    { 
        /// <summary>
        /// Method-1: Backtracking (Best)
        /// TC: O(4^n / √n) — Catalan number growth
        /// SC: O(n) recursion + O(Cₙ × n) result storage
        /// </summary>

        public IList<string> GenerateParenthesis(int n)
        {
            var res = new List<string>();
            Recurse(res, 0, 0, "", n);
            return res;
        }

        public void Recurse(List<string> res, int left, int right, string s, int n)
        {
            if (s.Length == n * 2)
            {
                res.Add(s);
                return;
            }

            if (left < n)
            {
                Recurse(res, left + 1, right, s + "(", n);
            }

            if (right < left)
            {
                Recurse(res, left, right + 1, s + ")", n);
            }
        }
    }
}