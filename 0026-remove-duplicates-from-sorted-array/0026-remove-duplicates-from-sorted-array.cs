public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int k = 1;
        List<int> elements = new List<int>() { nums[0] };
        
        for(int i = 1; i < nums.Length; i++){
            if(elements.Last() != nums[i])
            {
                elements.Add(nums[i]);
            }
        }
        
        for(int i = 0; i < elements.Count(); i++)
        {
            nums[i] = elements[i];
        }
        
        return elements.Count();
    }
}