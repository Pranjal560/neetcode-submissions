public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
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

        List<int>[] list1 = new List<int>[nums.Length + 1];
        foreach(var kvp in dict1)
        {
            int number = kvp.Key;
            int frequency = kvp.Value;

            if(list1[frequency] == null)
            {
                list1[frequency] = new List<int>();
            }
            list1[frequency].Add(number);
        }

        List<int> result = new List<int>();
        for(int i = list1.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if(list1[i] != null)
            {
                result.AddRange(list1[i]);
            }
        }

        return result.ToArray();

    }

}
