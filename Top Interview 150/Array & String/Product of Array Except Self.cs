public class Solution
{
  public int[] ProductExceptSelf(int[] nums)
  {
    // Time and Space Comp. - O(N) both
    // int size = nums.Length;
    // int[] prefixArr = new int[size];
    // int[] suffixArr = new int[size];
    // int[] resultArr = new int[size];

    // prefixArr[0] = 1;
    // for (int i = 1; i < size; i++) {
    //     prefixArr[i] = prefixArr[i-1]*nums[i-1];
    // }

    // suffixArr[size-1] = 1;
    // for (int i = size-2; i >= 0; i--) {
    //     suffixArr[i] = nums[i+1]*suffixArr[i+1];
    // }

    // for (int i = 0; i < size; i++) {
    //     resultArr[i] = prefixArr[i]*suffixArr[i];
    // }

    // return resultArr;

    // Time and Space Comp. - O(N) and O(1)
    int size = nums.Length;
    int[] resultArr = new int[size];

    resultArr[0] = 1;
    for (int i = 1; i < size; i++)
    {
      resultArr[i] = resultArr[i - 1] * nums[i - 1];
    }

    int product = 1;
    for (int i = size - 2; i >= 0; i--)
    {
      product *= nums[i + 1];
      resultArr[i] = product * resultArr[i];
    }

    return resultArr;
  }
}