public class Solution
{
  public int CanCompleteCircuit(int[] gas, int[] cost)
  {
    // int remainingFuel = 0;

    // for (int i = 0; i < gas.Length; i++) {
    //     if (gas[i] - cost[i] >= 0) {
    //         remainingFuel = gas[i] - cost[i];
    //         int j = (i+1) % gas.Length;
    //         while (j != i && remainingFuel > 0) {
    //             remainingFuel += gas[j] - cost[j];
    //             j = (j+1) % gas.Length;            
    //         }
    //         if (i == j && remainingFuel >= 0) {
    //             return i;
    //         }
    //     }
    // }

    // return -1;

    // Better approach
    int totalDiff = 0, index = 0, fuel = 0;

    for (int i = 0; i < gas.Length; i++)
    {
      int diff = gas[i] - cost[i];
      totalDiff += diff;
      fuel += diff;

      if (fuel < 0)
      {
        index = i + 1;
        fuel = 0;
      }
    }

    return totalDiff < 0 ? -1 : index;
  }
}