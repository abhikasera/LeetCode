public class Solution {
    public bool IsPalindrome(string s) {
        
        bool isPalindrome = true;
        
        for(int i = 0, j = s.Length - 1;i <= j; i++, j--)
        {
            while(i < s.Length && !IsAlphaNumeric(s[i])){
                i++;
            }
            
            while(j > 0 && !IsAlphaNumeric(s[j])){
                j--;
            }
            
            if(i <= j && Char.ToLower(s[i]) == Char.ToLower(s[j]))
            {
                continue;
            }
            else if(i > j)
            {
                break;
            }
            else
            {
                isPalindrome = false;
            }
        }
        
        return isPalindrome;
        
    }
    
    public bool IsAlphaNumeric(char x)
    {
        x = Char.ToLower(x);
        if((x >=48 && x <= 57) || (x >= 97 && x <= 122))
            return true;
        
        return false;
    }
}