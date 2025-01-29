public class Solution
{
  public bool CanJump(int[] nums)
  {
    if (nums.Length == 1)
    {
      return true;
    }
    bool canReachToEnd = false;
    int size = nums.Length;
    int goal = size - 1;

    for (int i = size - 2; i >= 0; i--)
    {
      if (i + nums[i] >= goal)
      {
        canReachToEnd = true;
        goal = i;
      }
      else
      {
        canReachToEnd = false;
      }
    }

    return canReachToEnd;
  }
}