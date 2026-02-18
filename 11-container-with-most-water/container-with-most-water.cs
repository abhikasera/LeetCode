public class Solution {
    public int MaxArea(int[] height) {

        int currentMax = 0, maxHeightIndex = 0;
        int i = 0, j = height.Length - 1, x = 0;
        while(i < j)
        {
            int width = j - i;
            int length = Math.Min(height[i], height[j]);
            int area = length * width;
            if(area > currentMax)
                currentMax = area;

            if(height[i] >= height[j]){
                //maxHeightIndex = i;
                j--;
            }
            else{
                //maxHeightIndex = j;
                i++;
            }

        }
        return currentMax;   
    }
}