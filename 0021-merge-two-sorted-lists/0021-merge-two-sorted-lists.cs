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
        
        if(list1 == null && list2 == null)
            return null;
        
        ListNode mergedList = new ListNode();
        ListNode currentNode = mergedList;
        while(list1 != null || list2 != null)
        {
            if(list1 == null)
            {
                currentNode.val = list2.val;           
                list2 = list2.next;
            }            
            else if(list2 == null)
            {
                currentNode.val = list1.val;           
                list1 = list1.next;
            }            
            else if(list1.val <= list2.val)
            {
                currentNode.val = list1.val;                
                list1 = list1.next;
            }
            else
            {
                currentNode.val = list2.val;             
                list2 = list2.next;
            }
            
            if(list1 != null || list2 != null)
            {                
                ListNode newNode = new ListNode();
                currentNode.next = newNode;
                currentNode = newNode;     
            }
        }
        
        return mergedList;
    }
}