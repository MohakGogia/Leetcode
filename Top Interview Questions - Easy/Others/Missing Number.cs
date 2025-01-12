public class Solution
{
  public int MissingNumber(int[] nums)
  {
    int sum = 0;
    foreach (int n in nums)
    {
      sum += n;
    }
    return ((nums.Length * (nums.Length + 1)) / 2) - sum;
  }
}