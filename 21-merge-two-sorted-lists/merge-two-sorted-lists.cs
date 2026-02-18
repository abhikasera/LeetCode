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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode output = new ListNode();
        ListNode head = output;
        
        while(!(list1 == null && list2 == null))
        {
            if(list1 == null)
            {
                output.next = list2;
                list2 = list2.next;
            }
            else if(list2 == null)
            {
                output.next = list1;
                list1 = list1.next;
            }
            else
            {
                if(list1.val <= list2.val)
                {
                    output.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    output.next = list2;
                    list2 = list2.next;
                }
            }
            output = output.next;
        }
        return head.next;
    }
}