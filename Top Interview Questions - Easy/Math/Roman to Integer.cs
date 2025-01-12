public class Solution
{
  public int RomanToInt(string s)
  {
    var num = 0;

    for (int i = 0; i < s.Length; i++)
    {
      int currentVal = GetRomanValue(s[i]);
      int nextVal = i < s.Length - 1 ? GetRomanValue(s[i + 1]) : 0;

      if (currentVal < nextVal) num -= currentVal;
      else num += currentVal;
    }
    return num;
  }

  public int GetRomanValue(char c)
  {
    switch (c)
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