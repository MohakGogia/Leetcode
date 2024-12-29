public class Solution
{
  public int SingleNumber(int[] nums)
  {
    var countDict = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
      if (countDict.ContainsKey(nums[i]))
      {
        countDict[nums[i]] += 1;
      }
      else
      {
        countDict[nums[i]] = 1;
      }
    }

    var num = countDict.SingleOrDefault(x => x.Value == 1);
    return num.Key;
  }
}