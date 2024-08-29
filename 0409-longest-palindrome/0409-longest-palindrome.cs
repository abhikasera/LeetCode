public class Solution {
    public int LongestPalindrome(string s) {
        Dictionary<char, int> count = new Dictionary<char, int>(); 
        for(int i = 0; i < s.Length; i++){
            if(count.ContainsKey(s[i]))
                count[s[i]] = count[s[i]] + 1;
            else
                count[s[i]] = 1;
        }
        
        int maxLength = 0;
        bool doesNonEvenExist = false;
        foreach(var x in count.Keys){
            
            if(count[x]/2 >= 0){
                maxLength = maxLength + (count[x]/2) * 2;
            }
                
            if(count[x]%2 != 0)
                doesNonEvenExist = true;
        }
        
        if(doesNonEvenExist)
            maxLength +=1;
    
        return maxLength;
    }
}