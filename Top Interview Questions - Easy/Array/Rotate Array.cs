public class Solution
{
  public void Rotate(int[] nums, int k)
  {
    int size = nums.Length;
    k = k % size;

    Reverse(nums, 0, size - 1);
    Reverse(nums, 0, k - 1);
    Reverse(nums, k, size - 1);
  }

  public void Reverse(int[] nums, int start, int end)
  {
    while (start < end)
    {
      int temp = nums[start];
      nums[start] = nums[end];
      nums[end] = temp;
      start++;
      end--;
    }
  }
}