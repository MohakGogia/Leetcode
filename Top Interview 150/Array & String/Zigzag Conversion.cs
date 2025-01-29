public class Solution
{
  public string Convert(string s, int numRows)
  {
    if (numRows == 1) return s;

    var zigZag = new StringBuilder();
    int jump = (numRows - 1) * 2;

    for (int row = 0; row < numRows; row++)
    {
      for (int j = row; j < s.Length; j += jump)
      {
        zigZag.Append(s[j]);

        if (row > 0 && row < numRows - 1 && (j + jump - (2 * row) < s.Length))
        {
          zigZag.Append(s[j + jump - (2 * row)]);
        }
      }
    }

    return zigZag.ToString();
  }
}