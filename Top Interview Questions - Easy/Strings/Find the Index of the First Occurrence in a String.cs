public class Solution
{
  public int StrStr(string haystack, string needle)
  {
    for (int i = 0; i <= haystack.Length - needle.Length; i++)
    {
      if (haystack[i] == needle[0])
      {
        bool check = true;
        for (int j = 1; j < needle.Length; j++)
        {
          if (haystack[i + j] != needle[j])
          {
            check = false;
            break;
          }
        }

        if (check) return i;
      }
    }

    return -1;
  }
}