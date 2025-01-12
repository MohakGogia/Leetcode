public class Solution
{
  public int CountPrimes(int n)
  {
    if (n <= 2)
    {
      return 0;
    }

    bool[] prime = new bool[n + 1];

    for (int i = 0; i <= n; i++)
    {
      prime[i] = true;
    }

    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
      if (prime[i] == true)
      {
        for (int j = i * i; j <= n; j += i)
        {
          prime[j] = false;
        }
      }
    }

    int count = 0;
    for (int i = 2; i < n; i++)
    {
      if (prime[i])
      {
        count++;
      }
    }

    return count;
  }
}