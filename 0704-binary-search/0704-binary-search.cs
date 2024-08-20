public class Solution {
    public int Search(int[] nums, int target) {
        int index = BinarySearch(nums, target, 0, nums.Length - 1);
        
        return index;
    }
    
    public int BinarySearch(int[] nums, int target, int min, int max) {
        
        if(min > max)
            return -1;
        
        int mid = (min + max) / 2;
        
        if(nums[mid] == target)
            return mid;
        else if(target < nums[mid])
            return BinarySearch(nums, target, min, mid - 1);
        else
            return BinarySearch(nums, target, mid + 1, max);
    }
}