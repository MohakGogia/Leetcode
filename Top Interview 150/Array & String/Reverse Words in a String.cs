public class Solution
{
  public string ReverseWords(string s)
  {
    if (s.Length == 1) return s;

    var outputString = new StringBuilder();
    var word = new StringBuilder();
    var res = new List<string>();
    int n = s.Length;

    for (int i = n - 1; i >= 0; i--)
    {
      if (s[i] != ' ')
      {
        word.Append(s[i]);
      }
      if (s[i] == ' ' && word.Length > 0)
      {
        res.Add(Reverse(word.ToString()));
        word.Clear();
      }
    }

    if (word.Length > 0)
    {
      res.Add(Reverse(word.ToString()));
    }

    for (int i = 0; i < res.Count; i++)
    {
      outputString.Append(res[i]);
      if (i < res.Count - 1)
      {
        outputString.Append(" ");
      }
    }

    return outputString.ToString();
  }

  public string Reverse(string str)
  {
    var reverse = new StringBuilder();

    for (int i = str.Length - 1; i >= 0; i--)
    {
      reverse.Append(str[i]);
    }

    return reverse.ToString();
  }
}