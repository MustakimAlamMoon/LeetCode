namespace Essential.Graph
{
    class _01MatrixClass
    {
        /// <summary>
        /// Method-1: Dynamic Programming (Best)
        /// TC: O(m * n)
        /// SC: O(1)
        /// </summary>

        public int[][] UpdateMatrix(int[][] mat)
        {
            int m = mat.Length, n = mat[0].Length, INF = m + n; // The distance of cells is up to (M+N)

            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (mat[r][c] == 0) continue;
                    int top = INF, left = INF;
                    if (r - 1 >= 0) top = mat[r - 1][c];
                    if (c - 1 >= 0) left = mat[r][c - 1];

                    mat[r][c] = Math.Min(top, left) + 1;
                }
            }

            for (int r = m - 1; r >= 0; r--)
            {
                for (int c = n - 1; c >= 0; c--)
                {
                    if (mat[r][c] == 0) continue;
                    int bottom = INF, right = INF;
                    if (r + 1 < m) bottom = mat[r + 1][c];
                    if (c + 1 < n) right = mat[r][c + 1];

                    mat[r][c] = Math.Min(mat[r][c], Math.Min(bottom, right) + 1);
                }
            }

            return mat;
        }
    }
}
