public class Solution 
{
    public List<List<int>> ThreeSum(int[] nums) 
    {
        List<List<int>> l1 = new List<List<int>>();
        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++)
        {
            int left = i+1;
            int right = nums.Length - 1;

            if(i > 0 && nums[i] == nums[i-1])
            {
                continue;
            }

            while(left < right)
            {
                int current_Number = nums[i] + nums[left] + nums[right];

                if(current_Number == 0)
                {
                    l1.Add(new List<int>{nums[i],nums[left],nums[right]});
                    left++;
                    right--;

                    while(left < right && nums[left] == nums[left-1])
                    {
                        left++;
                    }
                }else if(current_Number < 0)
                {
                    left++;
                }else{
                    right--;
                }
            }
        }

        return l1;
    }
}
