public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> dict1 = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int curr_Number = nums[i];
            int target_Num = target - curr_Number;

            if(dict1.ContainsKey(target_Num))
            {
                return new int[]{dict1[target_Num],i};
            }
            if(!dict1.ContainsKey(curr_Number))
            {
                dict1.Add(curr_Number,i);
            }
        }
        return new int[0];
    }
}
