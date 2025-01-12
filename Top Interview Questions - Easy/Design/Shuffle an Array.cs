public class Solution
{
  public int[] array;
  public int[] shuffled;
  public Random r;

  public Solution(int[] nums)
  {
    array = nums;
    r = new Random();
    shuffled = new int[nums.Length];
    Array.Copy(nums, shuffled, nums.Length);
  }

  public int[] Reset()
  {
    return array;
  }

  public int[] Shuffle()
  {
    for (int i = 0; i < shuffled.Length; i++)
    {
      int index = r.Next(shuffled.Length);
      int t = shuffled[i];
      shuffled[i] = shuffled[index];
      shuffled[index] = t;
    }

    return shuffled;
  }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */