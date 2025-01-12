public class Solution
{
  //     public bool IsValid(string s) {
  //         var brackets = new Stack<char>();

  //         foreach(char c in s) {
  //             if (c == '(' || c == '[' || c == '{') {
  //                 brackets.Push(c);
  //             } else {
  //                 if (brackets.Count == 0) return false;
  //                 char top = brackets.Peek();
  //                 if ((c == ')' && top == '(') || (c == '}' && top == '{') || (c == ']' && top == '[')) {
  //                     brackets.Pop();
  //                 } else {
  //                     return false;
  //                 }
  //             }
  //         }

  //         return brackets.Count == 0;
  //     }

  // Alternate way using dictionary
  public bool IsValid(string s)
  {
    var brackets = new Stack<char>();
    var matchingBrackets = new Dictionary<char, char> {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

    foreach (char c in s)
    {
      if (matchingBrackets.ContainsValue(c))
      {
        brackets.Push(c);
      }
      else
      {
        if (brackets.Count <= 0 || brackets.Pop() != matchingBrackets[c])
        {
          return false;
        }
      }
    }

    return brackets.Count == 0;
  }
}