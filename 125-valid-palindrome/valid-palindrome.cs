public class Solution {
    public bool IsPalindrome(string s) {
        string newString = "";
        foreach(char c in s)
        {
            if(Char.IsLetterOrDigit(c))
                newString+=Char.ToLower(c);
        }
        //Console.WriteLine(newString);

        int i = 0, j = newString.Length -1;
        for(i = 0; i <= j; i++, j--)
        {
            if(newString[i] != newString[j])
                return false;
        }

        return true;
    }
}