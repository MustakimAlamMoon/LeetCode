namespace Essential.Interval
{
    class MergeIntervalsClass
    {
        /// <summary>
        /// Method-1: Sorting (Best)
        /// TC: O(nlogn)
        /// SC: O(n)
        /// </summary>

        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1)
                return intervals;

            // Sort intervals by ascending start time
            System.Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            List<int[]> result = new List<int[]>();
            int[] newInterval = intervals[0];
            result.Add(newInterval);

            foreach (int[] interval in intervals)
            {
                // Overlapping intervals: extend the end time
                if (interval[0] <= newInterval[1])
                {
                    newInterval[1] = Math.Max(newInterval[1], interval[1]);
                }
                else
                {
                    // Disjoint interval: start a new merge group
                    newInterval = interval;
                    result.Add(newInterval);
                }
            }

            return result.ToArray();
        }
    }
}
