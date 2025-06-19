public class Solution {
    public bool IsValid(string s) {

        List<char> stack = new List<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '[' || s[i] == '{' || s[i] == '('){
                stack.Add(s[i]);
            }
            else
            {
                if(!stack.Any())
                    return false;
                
                char e = stack.Last();
                stack.RemoveAt(stack.Count - 1);
                if(s[i] == ']' && e != '[')
                    return false;
                else if(s[i] == '}' && e != '{')
                    return false;
                else if(s[i] == ')' && e != '(')
                    return false;

            }
        }
        if(stack.Any())
            return false;

        return true;
    }
}