public class Solution
{
  public IList<string> FullJustify(string[] words, int maxWidth)
  {
    var output = new List<string>();
    var line = new List<string>();
    int lineLength = 0;

    foreach (var word in words)
    {
      // Characters in the current line + spaces + current word length
      if (lineLength + line.Count + word.Length > maxWidth)
      {
        int numWords = line.Count;
        int availableSpaces = maxWidth - lineLength;
        var sb = new StringBuilder();

        // Add the word and rest all the spaces
        if (numWords == 1)
        {
          sb.Append(line[0] + new string(' ', availableSpaces));
        }
        else
        {
          int spaceBetweenWords = availableSpaces / (numWords - 1);
          int extraSpaces = availableSpaces % (numWords - 1);

          // To add spaces between the words, then separately add the last word
          for (int i = 0; i < numWords - 1; i++)
          {
            sb.Append(line[i]);
            var space = new string(' ', spaceBetweenWords);
            sb.Append(space);

            if (extraSpaces > 0)
            {
              sb.Append(" ");
              extraSpaces--;
            }
          }

          sb.Append(line[numWords - 1]);
        }

        output.Add(sb.ToString());
        // Reset it for the next line
        line.Clear();
        lineLength = 0;
      }

      line.Add(word);
      lineLength += word.Length;
    }

    var lastLine = new StringBuilder(line[0]);
    for (int i = 1; i < line.Count; i++)
    {
      lastLine.Append(" " + line[i]);
    }

    var trailingSpaces = new string(' ', maxWidth - lastLine.Length);
    lastLine.Append(trailingSpaces);
    output.Add(lastLine.ToString());

    return output;
  }
}