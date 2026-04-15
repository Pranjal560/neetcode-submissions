public class Solution {
    public int MajorityElement(int[] nums) 
    {
        Dictionary<int,int> dict1 = new Dictionary<int,int>();
        int maxCount = 0, res = 0; 

        foreach(int num in nums)   
        {
            if(!dict1.ContainsKey(num))
            {
                dict1[num] = 0;
            }
            dict1[num]++;

            if(dict1[num] > maxCount)
            {
                res = num;
                maxCount = dict1[num];
            }
        }
        return res;  
    }
}