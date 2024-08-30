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
    public ListNode MiddleNode(ListNode head) {
        ListNode temp = head;
        
        int count = 0;
        while(temp != null)
        {
            count++;
            temp = temp.next;
        }
        
        int mid = count/2;
        temp = head;
        while(mid > 0){
            temp = temp.next;
            mid--;
        }
        
        //Console.WriteLine(temp.val);
        
        return temp;
    }
}