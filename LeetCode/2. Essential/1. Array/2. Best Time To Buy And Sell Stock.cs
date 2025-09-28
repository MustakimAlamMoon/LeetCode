namespace LeetCode.Essential.Array
{
    class BestTimeToBuyAndSellStockClass
    {
        /// <summary>
        /// Method-1: Optimized (Best)
        /// TC: O(n)
        /// SC: O(1)
        /// </summary>

        public int MaxProfit(int[] prices)
        {
            var buy = 0;
            var max = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                var profit = prices[i] - prices[buy];

                if (profit < 0)
                {
                    buy = i;
                }

                max = Math.Max(profit, max);
            }

            return max;
        }
    }
}
