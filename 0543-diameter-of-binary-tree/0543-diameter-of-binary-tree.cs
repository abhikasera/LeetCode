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
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root == null)
            return 0;
        
        int currentMax = 0;
        
        MaxHeight(root, ref currentMax);
        
        return currentMax;
    }
    
    public int MaxHeight(TreeNode root, ref int currentMax){
        if(root == null)
            return 0;
        
        int left = MaxHeight(root.left, ref currentMax);
        int right = MaxHeight(root.right, ref currentMax);
        
        if(currentMax < left + right)
            currentMax = left + right;
        
        //Console.WriteLine(root.val + " - " + left + " - " + right + " - " + currentMax);
        
        return Math.Max(left,  right) + 1;
    }
}