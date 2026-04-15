public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int,int> seenNumber = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int current_Num = nums[i];
            int target_Num = target - current_Num;

            if(seenNumber.ContainsKey(target_Num))
            {
                return new int[] {seenNumber[target_Num],i};
            }

            if(!seenNumber.ContainsKey(current_Num))
            {
                seenNumber.Add(current_Num, i);
            }
        }
        return new int[0];
    }
}
