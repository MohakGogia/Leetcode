public class Solution
{
  public int Reverse(int x)
  {
    int rev = 0;

    while (x != 0)
    {
      int dig = x % 10;
      int temp = rev * 10 + dig;

      if ((temp - dig) / 10 != rev)
      {
        return 0;
      }

      rev = temp;
      x /= 10;
    }

    return rev;
  }
}