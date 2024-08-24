public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        
        if(image[sr][sc] == color)
            return image;
        
        return PerformFloodFill(image, sr, sc, color, image.Length, image[0].Length);
    }
    
    public int[][] PerformFloodFill(int[][] image, int sr, int sc, int color, int m, int n) {        
           
        int starting = image[sr][sc];            
        if(image[sr][sc] != color){
            image[sr][sc] = color;
        }
        
        if(sr > 0 && image[sr - 1][sc] == starting){
            PerformFloodFill(image, sr-1, sc, color, m, n);
        }
        
        if(sr < m - 1 && image[sr + 1][sc] == starting){
            PerformFloodFill(image, sr+1, sc, color, m, n);
        }
        
        if(sc > 0 && image[sr][sc-1] == starting){
            PerformFloodFill(image, sr, sc - 1, color, m, n);
        }
        
        if(sc < n - 1 && image[sr][sc + 1] == starting){
            PerformFloodFill(image, sr, sc + 1, color, m, n);
        }
        
        return image;
    }
}