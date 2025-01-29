public class Solution
{
  public int Trap(int[] height)
  {
    // TC - O(N) and SC - O(N)
    // int n = height.Length;
    // int waterSections = 0;
    // int[] leftMaxValues = new int[n];
    // int[] rightMaxValues = new int[n];

    // // Calculate all max values present to the left
    // int max = height[0];
    // for (int i = 1; i < n; i++) {
    //     leftMaxValues[i] = max;
    //     if (height[i] > max) {
    //         max = height[i];
    //     }
    // }

    // // Calculate all max values present to the right
    // max = height[n-1];
    // for (int i = n-2; i > 0; i--) {
    //     rightMaxValues[i] = max;
    //     if (height[i] > max) {
    //         max = height[i];
    //     }
    // }

    // // From the minimum of the two, reduce the elevation to get the water sections
    // for (int i = 0; i < n; i++) {
    //     int min = Math.Min(leftMaxValues[i], rightMaxValues[i]);
    //     if (min - height[i] > 0) {
    //         waterSections += min - height[i];
    //     }
    // }

    // return waterSections;

    // TC - O(N) and SC - O(1) - 2 pointer approach
    int n = height.Length;
    int l = 0, r = n - 1, sum = 0;
    int lMax = 0, rMax = height[r];

    while (l < r)
    {
      if (height[l] <= height[r])
      {
        sum += Math.Max(0, lMax - height[l]);
        lMax = Math.Max(lMax, height[l]);
        l++;
      }
      else
      {
        sum += Math.Max(0, rMax - height[r]);
        rMax = Math.Max(rMax, height[r]);
        r--;
      }
    }

    return sum;
  }
}