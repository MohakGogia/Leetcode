public class Solution
{
  public int MaxProfit(int[] prices)
  {
    int i = 0;
    int maxProfit = 0;
    for (int j = 1; j < prices.Length; j++)
    {
      if (prices[j] > prices[i])
      {
        maxProfit += prices[j] - prices[i];
      }
      i = j;
    }

    return maxProfit;
  }
}