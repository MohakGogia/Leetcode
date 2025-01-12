public class Solution
{
  public IList<string> FizzBuzz(int n)
  {
    List<string> result = new();

    for (int i = 1; i <= n; i++)
    {
      string word = "";

      if (i % 3 == 0)
        word += "Fizz";
      if (i % 5 == 0)
        word += "Buzz";

      result.Add(word.Length > 0 ? word : i.ToString());
    }

    return result;
  }
}