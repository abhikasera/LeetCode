public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashmap =  new Dictionary<int, int>();
        hashmap[nums[0]] = 0;
        int[] output = new int[2];

        int x = 0;
        for(int i = 1; i < nums.Length; i++){
            x = target - nums[i];
            if(hashmap.ContainsKey(x)){
                output[0] = hashmap[x];
                output[1] = i;
            }
            hashmap[nums[i]] = i;
        }

        return output;
    }
}