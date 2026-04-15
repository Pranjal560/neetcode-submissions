public class Solution {
    public bool hasDuplicate(int[] nums)
    {
       HashSet<int> seenNumbers = new HashSet<int>();  
       foreach(int i in nums)
       {
         if(seenNumbers.Contains(i))
         {
            return true;
         }
         seenNumbers.Add(i);
       }

       return false; 
    }
}