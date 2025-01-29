public class Solution
{
  public void Rotate(int[] nums, int k)
  {
    //     k = k % nums.Length;

    //     ReverseArr(nums, 0, nums.Length-1);
    //     ReverseArr(nums, 0, k-1);
    //     ReverseArr(nums, k, nums.Length-1);
    // }

    // public void ReverseArr(int[] nums, int low, int high) {
    //     while (low < high) {
    //         (nums[low], nums[high]) = (nums[high], nums[low]);
    //         low++;
    //         high--;
    //     }
    // }

    // Alter
    k = k % nums.Length;
    int[] rotatedArr = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
      rotatedArr[(i + k) % nums.Length] = nums[i];
    }

    for (int i = 0; i < nums.Length; i++)
    {
      nums[i] = rotatedArr[i];
    }
  }
}