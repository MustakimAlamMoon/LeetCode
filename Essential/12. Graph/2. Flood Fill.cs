namespace Essential.Graph
{
    class FloodFillClass
    {
        /// <summary>
        /// Method-1: Recursive DFS (Best)
        /// TC: O(n)
        /// SC: O(n)
        /// </summary>

        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int color = image[sr][sc];
            if (color != newColor) Fill(image, sr, sc, color, newColor);
            return image;
        }

        private void Fill(int[][] image, int sr, int sc, int color, int newColor)
        {
            if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length || image[sr][sc] != color)
                return;

            image[sr][sc] = newColor;

            Fill(image, sr + 1, sc, color, newColor);
            Fill(image, sr - 1, sc, color, newColor);
            Fill(image, sr, sc + 1, color, newColor);
            Fill(image, sr, sc - 1, color, newColor);
        }
    }
}
