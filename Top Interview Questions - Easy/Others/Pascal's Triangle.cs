public class Solution
{
  public IList<IList<int>> Generate(int numRows)
  {
    IList<IList<int>> result = new List<IList<int>>();

    if (numRows == 0)
    {
      return result;
    }

    result.Add(new List<int> { 1 });

    for (int i = 1; i < numRows; i++)
    {
      var prevList = result[i - 1];
      IList<int> newList = new List<int> { 1 };

      for (int j = 0; j < prevList.Count - 1; j++)
      {
        var sum = prevList[j] + prevList[j + 1];
        newList.Add(sum);
      }

      newList.Add(1);
      result.Add(newList);
    }

    return result;
  }
}