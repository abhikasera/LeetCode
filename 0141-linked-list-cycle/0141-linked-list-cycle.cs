/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null)
            return false;
        
        HashSet<ListNode> hashSet = new HashSet<ListNode>();
        
        while(head != null)
        {
            if(hashSet.Contains(head))
                return true;
            
            hashSet.Add(head);            
            head = head.next;
        }
        return false;
        
    }
}