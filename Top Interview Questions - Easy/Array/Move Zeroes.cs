public class Solution
{
  public void MoveZeroes(int[] nums)
  {
    int i = 0;
    int j = 1;
    while (j < nums.Length && i < j)
    {
      if (nums[i] != 0)
      {
        i += 1;
        j += 1;
      }
      else if (nums[i] == 0 && nums[j] == 0)
      {
        j += 1;
      }
      else if (nums[i] == 0 && nums[j] != 0)
      {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
        i += 1;
        j += 1;
      }
    }
  }
}