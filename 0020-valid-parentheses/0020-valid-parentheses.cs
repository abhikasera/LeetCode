public class Solution {
    public bool IsValid(string s) {

        bool isValid = true;
        List<char> braces = new List<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                braces.Add(s[i]);
                continue;
            }
            else if(s[i] == ')' || s[i] == '}' || s[i] == ']')
            {
                if(!braces.Any())
                    return false;
                
                char last = braces.Last();
                
                if(s[i] == ')' && last != '(')
                    return false;
                else if(s[i] == '}' && last != '{')
                    return false;
                else if(s[i] == ']' && last != '[')
                    return false;
                
                braces.RemoveAt(braces.Count - 1);
            }
        }
        if(braces.Any())
            return false;
        return
            true;
    }
}