public class Solution
{
  public int HammingWeight(int n)
  {
    //          string binaryForm = Convert.ToString(n, 2);

    //         return binaryForm.Count(bit => bit == '1');

    // Alternative way   
    int setBitsCount = 0;
    for (int i = 0; i < 32; i++)
    {
      if ((n & 1) == 1)
      {
        setBitsCount++;
      }
      n = n >> 1;
    }

    return setBitsCount;
  }
}