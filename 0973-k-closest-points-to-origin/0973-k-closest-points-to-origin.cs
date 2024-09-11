public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        Array.Sort(points, (x, y) => {
            double xDistance = Math.Sqrt(Math.Pow(x[0] - 0, 2) + Math.Pow(x[1] - 0, 2));
            double yDistance = Math.Sqrt(Math.Pow(y[0] - 0, 2) + Math.Pow(y[1] - 0, 2));
            
            //Console.WriteLine(xDistance + " - " + yDistance);
            
            if(xDistance > yDistance)
                return 1;
            else if(xDistance < yDistance)
                return -1;
            else
                return 0;
        });
        
        int[][] subArray = new int[k][];
        Array.Copy(points, 0, subArray, 0, k);
        
        return subArray;
    }
}