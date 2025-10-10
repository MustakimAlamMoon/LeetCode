namespace Essential.Tree
{
    class MaximumDepthOfBinaryTreeClass
    {
        /// <summary>
        /// Method-1: Recursive DFS (Best)
        /// TC: O(n)
        /// SC: O(n)
        /// </summary>


        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            int maxLeft = MaxDepth(root.left);
            int maxRight = MaxDepth(root.right);

            return Math.Max(maxLeft, maxRight) + 1;
        }
    }
}