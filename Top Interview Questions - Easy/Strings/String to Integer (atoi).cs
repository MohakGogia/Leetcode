public class Solution
{
  public int MyAtoi(string s)
  {
    s = s.Trim();
    if (s.Length == 0)
    {
      return 0;
    }

    int i = 0, num = 0, sign = 1;

    if (s[i] == '+' || s[i] == '-')
    {
      sign = (s[i] == '-') ? -1 : 1;
      i++;
    }

    while (i < s.Length && Char.IsDigit(s[i]))
    {
      int digit = s[i] - '0';

      if (num > (Int32.MaxValue - digit) / 10)
      {
        return (sign == 1) ? Int32.MaxValue : Int32.MinValue;
      }

      num = num * 10 + digit;
      i++;
    }

    return sign * num;
  }
}