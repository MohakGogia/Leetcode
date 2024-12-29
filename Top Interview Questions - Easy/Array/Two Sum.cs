public class Solution
{
  public int[] TwoSum(int[] nums, int target)
  {
    var mapping = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
      int secondValue = target - nums[i];
      if (mapping.ContainsKey(secondValue))
      {
        return new int[] { mapping[secondValue], i };
      }
      mapping[nums[i]] = i;
    }
    return new int[0];
  }
}