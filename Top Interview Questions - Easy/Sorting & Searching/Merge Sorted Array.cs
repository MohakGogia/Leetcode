public class Solution
{
  public void Merge(int[] nums1, int m, int[] nums2, int n)
  {
    int endPtr = m + n - 1;
    int j = m - 1;
    int k = n - 1;

    while (j >= 0 && k >= 0)
    {
      if (nums1[j] >= nums2[k])
      {
        nums1[endPtr] = nums1[j];
        j--;
      }
      else
      {
        nums1[endPtr] = nums2[k];
        k--;
      }
      endPtr--;
    }

    while (k >= 0)
    {
      nums1[endPtr] = nums2[k];
      k--;
      endPtr--;
    }

    while (j >= 0)
    {
      nums1[endPtr] = nums1[j];
      j--;
      endPtr--;
    }
  }
}