// Last updated: 6/18/2025, 10:41:12 PM
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        return MaxHeight(root);
    }
    
    public int MaxHeight(TreeNode root){
        if(root == null)
            return 0;
        
        int left = MaxHeight(root.left);
        int right = MaxHeight(root.right);       
        
        return Math.Max(left, right) + 1;
    }
}