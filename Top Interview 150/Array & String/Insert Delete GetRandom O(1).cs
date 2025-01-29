public class RandomizedSet
{
  public Dictionary<int, int> dict;
  public List<int> values;
  public Random random;

  public RandomizedSet()
  {
    dict = new Dictionary<int, int>();
    values = new List<int>();
    random = new Random();
  }

  public bool Insert(int val)
  {
    if (dict.ContainsKey(val))
    {
      return false;
    }

    values.Add(val);
    dict[val] = values.Count - 1;
    return true;
  }

  public bool Remove(int val)
  {
    if (!dict.ContainsKey(val))
    {
      return false;
    }

    int lastElement = values[values.Count - 1];
    int valIndex = dict[val];

    values[valIndex] = lastElement;
    dict[lastElement] = valIndex;

    values.RemoveAt(values.Count - 1);
    dict.Remove(val);

    return true;
  }

  public int GetRandom()
  {
    var randomIndex = random.Next(values.Count);
    return values[randomIndex];
  }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */