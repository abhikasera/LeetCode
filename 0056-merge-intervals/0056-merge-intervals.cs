public class Solution {
    public int[][] Merge(int[][] s) {
        int length = s.Length;
        
        if(length <= 1)
            return s;
        
        Array.Sort(s, (x, y) => {
            return x[0] - y[0];});
        int i = 1;
        
        List<int[]> news = new List<int[]>() {s[0]};
        
        while(i < length){
            if((news[news.Count - 1][0] <= s[i][0] && news[news.Count - 1][1] >= s[i][0]))
            {
                news[news.Count - 1][1] = Math.Max(s[i][1], news[news.Count - 1][1]);
                news[news.Count - 1][0] = Math.Min(s[i][0], news[news.Count - 1][0]);
            }
            else
                news.Add(s[i]);
            
            i++;
        }
        
        return news.ToArray();
    }
}