public class Solution
{
  public bool ContainsDuplicate(int[] nums)
  {
    var count = new Dictionary<int, int>();

    for (int n = 0; n < nums.Length; n++)
    {
      if (count.ContainsKey(nums[n]))
      {
        count[nums[n]] += 1;
      }
      else
      {
        count[nums[n]] = 1;
      }
    }

    return count.Values.Any(x => x > 1);
  }
}