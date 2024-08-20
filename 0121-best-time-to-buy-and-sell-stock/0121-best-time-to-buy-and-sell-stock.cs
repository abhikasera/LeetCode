public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minimumPurPrize = 10000;
        int bestPurchaseDay = 0;
        for(int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < minimumPurPrize){
                minimumPurPrize = prices[i];
                bestPurchaseDay = i;
            }
            else
                continue;
            
            for(int j = i+1; j < prices.Length; j++)
            {
                if(prices[j] > prices[i] && prices[j] - prices[i] > maxProfit)
                    maxProfit = prices[j] - prices[i];
            }
        }
        return maxProfit;
    }
}