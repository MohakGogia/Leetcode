public class Solution
{
  public int HammingDistance(int x, int y)
  {
    //         int numOnes = 0;
    //         for (int i = 0; i < 32; i++) {
    //             if (((x & 1) == 1 && (y & 1) != 1) || 
    //                 ((x & 1) != 1 && (y & 1) == 1)) {
    //                 numOnes++;
    //             }
    //             x = x >> 1;
    //             y = y >> 1;
    //         }

    //         return numOnes;

    // Alter using XOR 
    int res = x ^ y;
    int numOnes = 0;
    for (int i = 0; i < 32; i++)
    {
      if ((res & 1) == 1)
      {
        numOnes++;
      }
      res = res >> 1;
    }

    return numOnes;
  }
}