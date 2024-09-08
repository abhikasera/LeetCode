public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        
        int m = mat.Length;
        if(m < 0)
            return mat;
        int n = mat[0].Length;
        
        int[][] store = new int[m][];
        
        for(int i = 0; i < m; i++)
        {
            store[i] = new int[n];
            Array.Fill(store[i], m+n);
        }
        
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                //Console.WriteLine(i + " - " + j + " - " + store[i][j]);
                GetDistance(mat, ref store, i, j, m, n);
            }            
        }
        
        for(int i = m -1; i >= 0 ; i--)
        {
            for(int j = n - 1 ; j >= 0; j--)
            {
                GetDistance(mat, ref store, i, j, m, n);                
            }            
        }
        
        return store;
    }
    
    public void GetDistance(int[][] mat, ref int[][] store, int i, int j, int m, int n)
    {
        if(mat[i][j] == 0)
        {
            store[i][j] = 0;
        }
        else
        {
            if(i > 0 && store[i - 1][j] + 1 < store[i][j])
               store[i][j] = store[i - 1][j] + 1;
            
            if(j > 0 && store[i][j - 1] + 1 < store[i][j])
                store[i][j] = store[i][j - 1] + 1;
            
            if(i < m - 1 && store[i + 1][j] + 1 < store[i][j])
               store[i][j] = store[i + 1][j] + 1;
            
            if(j < n - 1 && store[i][j + 1] + 1 < store[i][j])
                store[i][j] = store[i][j + 1] + 1;
        }
    }
}