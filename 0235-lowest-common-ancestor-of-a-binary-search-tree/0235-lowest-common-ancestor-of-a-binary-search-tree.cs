/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        return Check(root, p, q);
    }
    
    public TreeNode Check(TreeNode root, TreeNode p, TreeNode q) {
        if(p.val == root.val || q.val == root.val)
            return root;
        else if((p.val < root.val && q.val > root.val)||(p.val > root.val && q.val < root.val))
            return root;
        else if(p.val < root.val && q.val < root.val)
            return Check(root.left, p, q);
        else
            return Check(root.right, p, q);
    }
}