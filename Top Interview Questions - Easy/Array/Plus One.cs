public class Solution
{
  public int[] PlusOne(int[] digits)
  {
    int i = 0;
    for (i = digits.Length - 1; i >= 0; i--)
    {
      if (digits[i] == 9)
      {
        digits[i] = 0;
      }
      else
      {
        digits[i] += 1;
        return digits;
      }
    }

    var newDigits = new int[digits.Length + 1];
    newDigits[0] = 1;

    return newDigits;
  }
}