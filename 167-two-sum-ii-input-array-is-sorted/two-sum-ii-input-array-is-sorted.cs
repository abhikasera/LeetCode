public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0, j = numbers.Length - 1;
        int[] output = new int[2];
        while(i<j)
        {
            int sum = numbers[i] + numbers[j];
            if(sum == target)
            {
                output[0] = i+1;
                output[1] = j+1;
                break;
            }
            else if(sum < target)
                i++;
            else
                j--;
        }
        return output;
    }
}