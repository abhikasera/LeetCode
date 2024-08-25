/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        if(n < 2 && IsBadVersion(1))
            return 1;        
        return FindBadVersion(1, n);
            
    }
    
    public int FindBadVersion(int min, int max)
    {   
        //Console.Write($"{min} - {max} - ");
        
        if(min >= max)
            return min;
        
        int mid = ((max - min)/2 + min);
        bool isBad = IsBadVersion(mid);
        //Console.WriteLine($"{mid} - {isBad.ToString()}");
        
        if(isBad)
           return FindBadVersion(min, mid);
        else
           return FindBadVersion(mid+1, max);
    }
}