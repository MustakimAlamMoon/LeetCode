namespace Essential.Heap
{
    class KClosestPointsToOriginClass
    {
        /// <summary>
        /// Method-1: Quickselect (Best)
        /// TC: O(n) average, O(n²) worst
        /// SC: O(1)
        /// </summary>

        public int[][] KClosest(int[][] points, int k)
        {
            int m = points.Length, n = points[0].Length;

            int left = 0, right = m - 1;

            while (left < right)
            {
                int pivotIdx = Partition(points, left, right);

                // the first k points are sorted in non-decreasing order
                if (pivotIdx == k - 1)
                    break;
                else if (pivotIdx < k - 1)
                    left = pivotIdx + 1;
                else
                    right = pivotIdx - 1;
            }

            int[][] res = new int[k][];

            // copy the first k points from points to res
            System.Array.Copy(points, res, k);
            return res;
        }

        private int Partition(int[][] points, int left, int right)
        {
            int pivot = Distance(points[right]);

            // ensure all points before j are <= pivot
            // j always points at the next-to-be-swapped point
            int j = left;

            for (int i = left; i < right; i++)
            {
                if (Distance(points[i]) <= pivot)
                {
                    Swap(points, i, j);
                    j++;
                }
            }

            Swap(points, j, right);
            return j;
        }

        private void Swap(int[][] points, int i, int j)
        {
            var tmp = points[i];
            points[i] = points[j];
            points[j] = tmp;
        }

        private int Distance(int[] point)
        {
            return point[0] * point[0] + point[1] * point[1];
        }
    }
}
