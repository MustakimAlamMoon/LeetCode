namespace Essential.Recursion
{
    class CombinationsClass
    {
        /// <summary>
        /// Method-1: Recursive Backtracking (Best)
        /// TC: O(C(n, k) × k)
        /// SC: O(k) + O(C(n, k) × k)
        /// </summary>

        private IList<IList<int>> res = new List<IList<int>>();

        public IList<IList<int>> Combine(int n, int k)
        {
            Helper(n, k, 1, new List<int>());

            return res;
        }

        private void Helper(int n, int k, int i, List<int> l)
        {
            if (l.Count == k)
                res.Add(new List<int>(l));
            else
                for (int j = i; j <= n; j++)
                {
                    l.Add(j);

                    Helper(n, k, j + 1, l);

                    l.RemoveAt(l.Count - 1);
                }
        }
    }
}