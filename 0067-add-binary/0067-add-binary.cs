public class Solution {
    public string AddBinary(string a, string b) {
        
        int i = a.Length - 1, j = b.Length - 1;
        int carry = 0;
        string output = "";
        while(i >= 0 || j >= 0)
        {
            if(i >= 0 && j >= 0)
            {
                int numa = a[i] - '0';
                int numb = b[j] - '0';
                
                int sum = numa + numb + carry;
                carry = sum/2;
                output = (sum%2).ToString() + output;
                
                i--; j--;
            }
            else if(i >= 0)
            {
                int numa = a[i] - '0';
                
                int sum = numa + carry;
                carry = sum / 2;
                output = (sum%2).ToString() + output;
                
                i--;
            }
            else
            {
                int numb= b[j] - '0';
                
                int sum = numb + carry;
                carry = sum / 2;
                output = (sum%2).ToString() + output;
                
                j--;
            }            
        }
        
        if(carry > 0)
            output = carry.ToString() + output;
        
        return output;
    }
}