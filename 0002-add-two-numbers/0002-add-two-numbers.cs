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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode output = new ListNode();
        ListNode currentNode = output;
        int carry = 0;
        while(l1 != null || l2 != null)
        {
            int newValue = 0;
            
            if(l1 != null && l2 != null)
            {
                newValue = (l1.val  + l2.val + carry)%10;
                carry = (l1.val  + l2.val + carry)/10;
            }
            else if(l1 == null)
            {
                newValue = (l2.val + carry)%10;
                carry = (l2.val + carry)/10;
            }
            else if(l2 == null)
            {
                newValue = (l1.val + carry)%10;
                carry = (l1.val + carry)/10;
            }
            else if(carry > 0)
            {
                newValue = carry;
                carry = 0;
            }

            currentNode.val = newValue;
            l1 = l1 != null && l1.next != null ? l1.next : null;
            l2 = l2 != null && l2.next != null ? l2.next : null;

            if(l1 != null || l2 != null){
                ListNode newNode = new ListNode();
                currentNode.next = newNode;
                currentNode = newNode;
            }
            else if(carry > 0){
                ListNode newNode = new ListNode(carry, null);
                currentNode.next = newNode;
            }
        }

        return output;
    }
}