// Last updated: 6/18/2025, 10:41:05 PM
public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>(); 
        for(int i = 0; i < nums.Length; i++){
            if(count.ContainsKey(nums[i]))
                count[nums[i]] = count[nums[i]] + 1;
            else
                count[nums[i]] = 1;
        }
        
        int majorityCount = 0, element = 0;
        foreach(var x in count.Keys){
            //Console.WriteLine(x + " - " +count[x]);
            if(count[x] > majorityCount){
                majorityCount = count[x];
                element = x;
            }
            //Console.WriteLine(element + " --- " + majorityCount);
        }        
    
        return element;
    }
}