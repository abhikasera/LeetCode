public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, bool> kvp = new Dictionary<int, bool>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(kvp.ContainsKey(nums[i]))
                return true;
            else
                kvp[nums[i]] = true;
        }
        
        return false;
    }
}