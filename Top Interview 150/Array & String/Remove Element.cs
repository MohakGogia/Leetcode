public class Solution
{
  public int RemoveElement(int[] nums, int val)
  {
    int valNotEqlPtr = 0;

    for (int i = 0; i < nums.Length; i++)
    {
      if (nums[i] != val)
      {
        nums[valNotEqlPtr] = nums[i];
        valNotEqlPtr++;
      }
    }

    return valNotEqlPtr;
  }
}