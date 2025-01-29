public class Solution
{
  public int Jump(int[] nums)
  {
    // int minJumps = 0;
    // int end = 0;
    // int farthestReachableIndex = Int32.MinValue;

    // for (int i = 0; i < nums.Length - 1; i++) {
    //     farthestReachableIndex = Math.Max(farthestReachableIndex, i + nums[i]);

    //     if (i == end) {
    //         end = farthestReachableIndex;
    //         minJumps++;
    //     }
    // }

    // return minJumps;

    // Alternative way
    int l = 0, r = 0, minJumps = 0;
    while (r < nums.Length - 1)
    {
      int farthestIndex = 0;
      for (int i = l; i <= r; i++)
      {
        farthestIndex = Math.Max(farthestIndex, i + nums[i]);
      }
      l = r + 1;
      r = farthestIndex;
      minJumps++;
    }

    return minJumps;
  }
}