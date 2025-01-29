public class Solution
{
  public int MaxProfit(int[] prices)
  {
    int minPrice = prices[0];
    int maxPrice = prices[0];
    int maxProfit = 0;

    for (int i = 1; i < prices.Length; i++)
    {
      if (prices[i] > maxPrice)
      {
        maxPrice = prices[i];
        if (maxPrice - minPrice > maxProfit)
        {
          maxProfit = maxPrice - minPrice;
        }
      }
      if (prices[i] < minPrice)
      {
        minPrice = maxPrice = prices[i];
      }

    }

    return maxProfit;
  }
}