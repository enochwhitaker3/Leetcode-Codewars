namespace codewars
{
    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            foreach (int i in nums)
            {
                int index = Array.IndexOf(nums, i);
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i + nums[j] == target && index != j)
                    {
                        int[] answer = new int[] { Array.IndexOf(nums, i), j};
                        Console.WriteLine(answer[0]);
                        Console.WriteLine(answer[1]);
                        return answer;
                    }
                }
            }
            return nums;
        }
    }
}
