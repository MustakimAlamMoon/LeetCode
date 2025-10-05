namespace Essential.Matrix
{
    class SpiralMatrixClass
    {
        /// <summary>
        /// Method-1: In-place (Best)
        /// TC: O(m x n)
        /// SC: O(1)
        /// </summary>

        public IList<int> SpiralOrder(int[][] matrix)
        {
            var res = new List<int>();
            if (matrix.Length == 0) return res;

            int rowBegin = 0;
            int rowEnd = matrix.Length - 1;
            int colBegin = 0;
            int colEnd = matrix[0].Length - 1;

            while (rowBegin <= rowEnd && colBegin <= colEnd)
            {
                // Traverse Right
                for (int j = colBegin; j <= colEnd; j++)
                    res.Add(matrix[rowBegin][j]);
                rowBegin++;

                // Traverse Down
                for (int i = rowBegin; i <= rowEnd; i++)
                    res.Add(matrix[i][colEnd]);
                colEnd--;

                // Traverse Left
                if (rowBegin <= rowEnd)
                {
                    for (int j = colEnd; j >= colBegin; j--)
                        res.Add(matrix[rowEnd][j]);
                    rowEnd--;
                }

                // Traverse Up
                if (colBegin <= colEnd)
                {
                    for (int i = rowEnd; i >= rowBegin; i--)
                        res.Add(matrix[i][colBegin]);
                    colBegin++;
                }
            }

            return res;
        }
    }
}
