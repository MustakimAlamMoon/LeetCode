namespace Essential.Tree
{
    class LowestCommonAncestorOfABinarySearchTreeClass
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

            public TreeNode(int x) { val = x; }
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;

            if (root.val > p.val && root.val > q.val)
                return LowestCommonAncestor(root.left, p, q);
            else if (root.val < p.val && root.val < q.val)
                return LowestCommonAncestor(root.right, p, q);

            return root;
        }
    }
}