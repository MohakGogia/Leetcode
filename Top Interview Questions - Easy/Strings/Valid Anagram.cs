public class Solution
{
  public bool IsAnagram(string s, string t)
  {
    if (s.Length != t.Length)
    {
      return false;
    }

    var charCount1 = new Dictionary<char, int>();
    var charCount2 = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {
      if (charCount1.ContainsKey(s[i]))
      {
        charCount1[s[i]]++;
      }
      else
      {
        charCount1[s[i]] = 1;
      }

      if (charCount2.ContainsKey(t[i]))
      {
        charCount2[t[i]]++;
      }
      else
      {
        charCount2[t[i]] = 1;
      }
    }

    foreach (char ch in charCount1.Keys)
    {
      if (!charCount2.ContainsKey(ch) || charCount1[ch] != charCount2[ch])
      {
        return false;
      }
    }

    return true;
  }
}