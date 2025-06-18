// Last updated: 6/18/2025, 10:41:14 PM
public class Solution {
    public int ClimbStairs(int n) {
        Dictionary<int, int> data = new Dictionary<int, int>();
        return Calculate(n, data);
    }

    public int Calculate(int n, Dictionary<int, int> data) {
        if(n == 2)
            return 2;
        else if(n == 1)
            return 1;
        else if(n == 0)
            return 0;

        if(!data.ContainsKey(n - 1)){
            data[n-1] = Calculate(n - 1, data);
        }

        if(!data.ContainsKey(n - 2)){
            data[n - 2] = Calculate(n - 2, data);
        }

        return data[n - 2] + data[n - 1];
    }
}