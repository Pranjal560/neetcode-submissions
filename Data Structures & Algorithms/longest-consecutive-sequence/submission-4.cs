public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        HashSet<int> h1 = new HashSet<int>(nums);
        int longest_Streak = 0;

        foreach(int num in h1)
        {
            if(!h1.Contains(num - 1))  //I do not have smaller number than num so i can start 
            {
                int current_Streak = 1;
                int current_Number = num;

                while(h1.Contains(current_Number + 1))
                {
                    current_Streak++;
                    current_Number++;
                }

                if(current_Streak > longest_Streak)
                {
                    longest_Streak = current_Streak;
                }
            }
        }
        return longest_Streak;    
    }
}
