public class Solution
{
  public bool IsPowerOfThree(int n)
  {
    if (n < 1) return false;

    while (n % 3 == 0)
    {
      n = n / 3;
    }

    if (n == 1) return true;
    else return false;
  }

  //   One more tricky solution
  //     public bool IsPowerOfThree(int n) 
  //     {
  //         var maxPow = (int) Math.Pow(3, 19);

  //         return n > 0 && maxPow % n == 0;
  //     }
}