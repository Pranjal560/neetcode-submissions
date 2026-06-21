public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
     Dictionary<int,int> dict1 = new Dictionary<int,int>();

     for(int i = 0; i < nums.Length; i++)
     {
        if(!dict1.ContainsKey(nums[i]))
        {
            
            dict1.Add(nums[i],1);
        }else{
            dict1[nums[i]]++;
        }

        
     }
     
     return dict1.OrderByDescending(kvp => kvp.Value)
                    .Take(k)
                    .Select(kvp => kvp.Key)
                    .ToArray();
     
   
    }
}
