public class Solution
{
	public int RemoveDuplicates(int[] nums)
	{
		int i = 0;
		for (int j = 1; j < nums.Length; j++)
		{
			if (nums[i] != nums[j])
			{
				i += 1;
				nums[i] = nums[j];
			}
		}

		return i + 1;
	}
}