public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> countMap = new Dictionary<char, int>();
        
        for(int i = 0; i < magazine.Length; i++)
        {
            if(countMap.ContainsKey(magazine[i]))
                countMap[magazine[i]] += 1;
            else
                countMap[magazine[i]] = 1;                
        }
        
        for(int i = 0; i < ransomNote.Length; i++)
        {
            if(countMap.ContainsKey(ransomNote[i]) && countMap[ransomNote[i]] > 0)
                countMap[ransomNote[i]] -= 1;
            else
                return false;                
        }
        
        return true;
    }
}