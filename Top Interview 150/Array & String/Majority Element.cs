public class Solution
{
  public int MajorityElement(int[] nums)
  {
    // var numCount = new Dictionary<int, int>();

    // foreach(var num in nums) {
    //     if (!numCount.Keys.Contains(num)) {
    //         numCount[num] = 0;
    //     }
    //     numCount[num] += 1; 
    // }

    // return numCount.FirstOrDefault(x => x.Value == numCount.Values.Max()).Key;

    // Alter solution using Boyer Moore algo - O(1) space
    int element = nums[0];
    int count = 1;

    for (int i = 1; i < nums.Length; i++)
    {
      if (count == 0)
      {
        element = nums[i];
      }
      if (element == nums[i])
      {
        count++;
      }
      else
      {
        count--;
      }
    }

    return element;
  }
}