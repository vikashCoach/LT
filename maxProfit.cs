public class Solution {
    public int MaxProfit(int[] prices) {
        int totalP = prices.Count();
        if(totalP<=1)
            return 0;
        int maxProfit = 0;
        for(int i=0;i<totalP;i++)
        {
            if(i<totalP-1 && prices[i+1]-prices[i]>0){
            int  currentProfit = prices[i+1]-prices[i];
                maxProfit += currentProfit;
            }
        }
        return maxProfit;
    }
}
