public class Solution
{
  public int[] Intersect(int[] nums1, int[] nums2)
  {
    var countMap = new Dictionary<int, int>();

    foreach (var elem in nums1)
    {
      if (countMap.ContainsKey(elem))
      {
        countMap[elem] += 1;
      }
      else
      {
        countMap[elem] = 1;
      }
    }

    var result = new List<int>();
    foreach (var elem in nums2)
    {
      if (countMap.ContainsKey(elem))
      {
        result.Add(elem);

        countMap[elem] -= 1;
        if (countMap[elem] == 0)
        {
          countMap.Remove(elem);
        }
      }
    }

    return result.ToArray();
  }
}