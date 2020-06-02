﻿namespace JuneChallenge.June1
{
    public class InvertBinaryTreeSolution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            InvertTree(root.left);
            InvertTree(root.right);

            TreeNode t = root.left;
            root.left = root.right;
            root.right = t;

            return root;
        }
    }

    //Definition for a binary tree node.
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
}