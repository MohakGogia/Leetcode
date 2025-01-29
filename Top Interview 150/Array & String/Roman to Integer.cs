public class Solution
{
  public int RomanToInt(string s)
  {
    int result = GetValue(s[s.Length - 1]);

    for (int i = s.Length - 2; i >= 0; i--)
    {
      if (GetValue(s[i]) >= GetValue(s[i + 1]))
      {
        result += GetValue(s[i]);
      }
      else
      {
        result -= GetValue(s[i]);
      }
    }

    return result;
  }

  public int GetValue(char ch)
  {
    switch (ch)
    {
      case 'I': return 1;
      case 'V': return 5;
      case 'X': return 10;
      case 'L': return 50;
      case 'C': return 100;
      case 'D': return 500;
      case 'M': return 1000;
      default: return 0;
    }
  }
}