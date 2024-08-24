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
    public bool IsBalanced(TreeNode root) {
        return CheckHeightAndBalance(root, out int height);
    }
    
    public bool CheckHeightAndBalance(TreeNode root, out int height) {
        
        if(root == null){
            height = -1;
            return true;
        }
        
        //Console.WriteLine("TreeNode " + root.val);
        //if(root.left != null)
            //Console.WriteLine("TreeNode-Left " + root.left.val);
        
        //if(root.right != null)
            //Console.WriteLine("TreeNode-Right " + root.right.val);
        
        bool leftBalanced = CheckHeightAndBalance(root.left, out int leftHeight);
        bool rightBalanced = CheckHeightAndBalance(root.right, out int rightHeight);
        
        if(leftHeight >= rightHeight)
            height = leftHeight + 1;
        else
            height = rightHeight + 1;
        
        if(leftBalanced == false || rightBalanced == false)
            return false;
        
        if(leftHeight - rightHeight >= -1 &&  leftHeight - rightHeight <= 1)
            return true;
        else
            return false;
    }
}