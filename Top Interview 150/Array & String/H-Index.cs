public class Solution
{
  public int HIndex(int[] citations)
  {
    // int citation = citations.Length;

    // while (citation > 0) {
    //     var count = 0;
    //     foreach (int c in citations) {
    //         if (c >= citation) {
    //             count++;
    //         }
    //     }
    //     if (count >= citation) {
    //         return citation;
    //     }
    //     citation--;
    // }

    // return citation;

    // Alternative with O(n) TC
    int n = citations.Length;
    int[] count = new int[n + 1];

    foreach (var c in citations)
    {
      if (c >= n)
      {
        count[n] += 1;
      }
      else
      {
        count[c] += 1;
      }
    }

    int sum = 0;
    for (int i = n; i >= 0; i--)
    {
      sum += count[i];
      if (sum >= i)
      {
        return i;
      }
    }

    return 0;
  }
}