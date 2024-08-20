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
    public TreeNode InvertTree(TreeNode root) {
        Revert(root);        
        return root;
    }
    
    public void Revert(TreeNode node){
        if(node == null)
            return;
        
        Revert(node.left);
        Revert(node.right);
        TreeNode temp = node.left;
        node.left = node.right;
        node.right = temp;
    }
}