public class Solution {
    public int ClimbStairs(int n) {
        Dictionary<int, int> cm = new Dictionary<int, int>();
        return FindCombination(n, cm);
    }
    
    public int FindCombination(int n, Dictionary<int, int> cm)
    {
        if(n <= 0){
            return 0;
        }
        
        if(n == 1){
            return 1;
        }
        
        if(n == 2){
            return  2;
        }
        
        //Console.WriteLine(n);
        
        if(n - 1 > 0 && !cm.ContainsKey(n - 1))
            cm[n-1] = FindCombination(n-1, cm);
        
        //Console.WriteLine("n - 1 = " + (n-1) + " Value " + cm[n-1]);
        
        if(n - 2 > 0 && !cm.ContainsKey(n - 2))
            cm[n-2] = FindCombination(n-2, cm);
        
        //Console.WriteLine("n - 2 = " + (n-2) + " Value " + cm[n-2]);
        
        return cm[n-1] + cm[n-2];
    }
}