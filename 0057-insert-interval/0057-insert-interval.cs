public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        
        int i = 0, n = intervals.Length;
        
        List<int[]> newIntervals = new List<int[]>();
        
        
        while(i < n && newInterval[0] > intervals[i][1])
        {
            newIntervals.Add(intervals[i]);
            i++;
        }
        
        while(i < n && newInterval[1] >= intervals[i][0])
        {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        
        newIntervals.Add(newInterval);
        
        while(i < n)
        {
            newIntervals.Add(intervals[i]);
            i++;
        }
            
        return newIntervals.ToArray();
    }
}