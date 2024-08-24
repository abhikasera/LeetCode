/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) 
    {
        if(head == null)
            return head;
        
        ListNode tempHead = head;
        
        ListNode prev = null;
        while(head.next != null)
        {
            ListNode temp = head;
            head = head.next;
            temp.next = prev;
            prev = temp;
        }
        
        head.next = prev;
        return head;
    }
}