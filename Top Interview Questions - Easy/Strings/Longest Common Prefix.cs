public class Solution
{
  public string LongestCommonPrefix(string[] strs)
  {
    var string1 = strs[0];
    string lcp = "";

    for (int i = 0; i < string1.Length; i++)
    { // for position index
      foreach (string s in strs)
      { // for strings in arr
        if (s.Length - 1 < i || s[i] != string1[i])
        {
          return lcp;
        }
      }

      lcp += string1[i];
    }

    return lcp;
  }
}