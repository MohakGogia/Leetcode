public class Solution
{
  public int FirstUniqChar(string s)
  {
    var charCount = new Dictionary<char, int>();

    foreach (char c in s)
    {
      if (charCount.ContainsKey(c))
      {
        charCount[c]++;
      }
      else
      {
        charCount[c] = 1;
      }
    }

    int i = 0;
    foreach (char c in s)
    {
      if (charCount[c] == 1)
      {
        return i;
      }
      i++;
    }

    return -1;
  }
}