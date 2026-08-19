public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] output = new int[nums.Length];
        int left = 1;
        int right = 1;

        for(int i = 0; i < nums.Length; i++)
        {
            output[i] = left;
            left = left*nums[i];
        }

        for(int i = nums.Length - 1; i >= 0; i--)
        {
            output[i] = output[i]*right;
            right = right*nums[i];
        }
        return output;    
    }
}
