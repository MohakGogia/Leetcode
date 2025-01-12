public class MinStack
{
  public Stack<(int val, int minVal)> stack;
  public int min = int.MaxValue;

  public MinStack()
  {
    stack = new Stack<(int, int)>();
  }

  public void Push(int val)
  {
    if (val < min)
    {
      min = val;
    }
    stack.Push((val, min));
  }

  public void Pop()
  {
    stack.Pop();
    if (stack.Count > 0)
    {
      min = stack.Peek().minVal;
    }
    else
    {
      min = int.MaxValue;
    }
  }

  public int Top()
  {
    return stack.Peek().val;
  }

  public int GetMin()
  {
    return stack.Peek().minVal;
  }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */