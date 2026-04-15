public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> has1 = new HashSet<int>();
        for(int i = 0; i <nums.Length; i++)
        {
            if(has1.Contains(nums[i]))
            {
                return true;
            }
            has1.Add(nums[i]);
        }
        return false;   
    }
}