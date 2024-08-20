public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        for(int i = 0; i< s.Length; i++){
            if(map.ContainsKey(s[i]))
                map[s[i]] = map[s[i]] + 1;
            else
                map[s[i]] = 0;
        }
        
        for(int i = 0; i < t.Length; i++){
            if(map.ContainsKey(t[i]) && map[t[i]] > 0)
                map[t[i]] = map[t[i]] - 1;
            else if(map.ContainsKey(t[i]) && map[t[i]] <= 0)
                map.Remove(t[i]);
            else                    
                return false;
        }
        
        if(map.Any())
            return false;
        
        return true;
    }
}