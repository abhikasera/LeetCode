public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map =  new Dictionary<int, int>();

        map[nums[0]] = 0;

        int[] output = new int[2];

        int x = 0;
        for(int i = 1; i < nums.Length; i++)
        {
            x = target - nums[i];
            if(map.ContainsKey(x)){
                output[0] = map[x];
                output[1] = i;
                break;
            }

            map[nums[i]] = i;
        }

        return output;
    }
}