public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        //Array.Sort(nums);
    
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = nums.Length - 1; j > i; j--)
            {
                if(nums[i] + nums[j] == target)
                {
                    return new int[]{i,j};
                }
            }
        }
        return new int[0];
    }
}
