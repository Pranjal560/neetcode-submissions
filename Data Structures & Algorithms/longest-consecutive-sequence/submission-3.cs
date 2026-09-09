public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        int longestStreak = 0;
        HashSet<int> h1 = new HashSet<int>(nums);

        foreach(int num in h1)
        {
            if(!h1.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while(h1.Contains(currentNum+1))
                {
                    currentNum++;
                    currentStreak++;
                }

                if(currentStreak > longestStreak)
                {
                    longestStreak = currentStreak;
                }
            }

            
        }
        return longestStreak;
    }
}
