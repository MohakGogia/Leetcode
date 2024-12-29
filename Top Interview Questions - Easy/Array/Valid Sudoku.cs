public class Solution
{
  public bool IsValidSudoku(char[][] board)
  {
    // For rows and columns
    for (int i = 0; i < board.Length; i++)
    {
      var rows = new HashSet<char>();
      var cols = new HashSet<char>();
      for (int j = 0; j < board[0].Length; j++)
      {
        if (board[i][j] != '.' && !rows.Add(board[i][j]))
        {
          return false;
        }
        if (board[j][i] != '.' && !cols.Add(board[j][i]))
        {
          return false;
        }
      }
    }

    // For individual 3x3 boxes
    // for (int k = 0; k < 9; k++)
    // {
    //     var box = new HashSet<char>();
    //     int boxRow = k / 3 * 3;
    //     int boxCol = k % 3 * 3;
    //     for (int i = boxRow; i < boxRow + 3; i++)
    //     {
    //         for (int j = boxCol; j < boxCol + 3; j++)
    //         {
    //             if (board[i][j] != '.' && !box.Add(board[i][j])) {
    //                 return false;
    //             }
    //         }
    //     }
    // }

    // For individual 3x3 boxes - 2nd way of checking
    var box = new HashSet<char>[board.Length];
    for (int i = 0; i < board.Length; i++)
    {
      box[i] = new HashSet<char>();
    }

    for (int r = 0; r < board.Length; r++)
    {
      for (int c = 0; c < board[r].Length; c++)
      {
        char elem = board[r][c];

        int b = (3 * (r / 3)) + (c / 3);
        if (elem != '.' && !box[b].Add(elem))
        {
          return false;
        }
      }
    }

    return true;
  }
}