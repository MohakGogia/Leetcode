public class Solution
{
  public int Candy(int[] ratings)
  {
    int[] candies = new int[ratings.Length];

    candies[0] = 1;
    for (int i = 1; i < ratings.Length; i++)
    {
      if (ratings[i] > ratings[i - 1])
      {
        candies[i] = candies[i - 1] + 1;
      }
      else
      {
        candies[i] = 1;
      }
    }

    int candiesCount = candies[ratings.Length - 1];
    for (int i = ratings.Length - 2; i >= 0; i--)
    {
      if (ratings[i] > ratings[i + 1])
      {
        if (candies[i] <= candies[i + 1])
        {
          candies[i] = candies[i + 1] + 1;
        }
      }
      candiesCount += candies[i];
    }

    return candiesCount;
  }
}