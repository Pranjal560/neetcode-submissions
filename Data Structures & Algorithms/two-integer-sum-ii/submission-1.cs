public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        int left = 0;
        int right = numbers.Length - 1;

        while(left < right)
        {
            int current_Sum = numbers[left] + numbers[right];

            if(current_Sum == target)
            {
                return new int[] {left+1,right+1};
            }else if(current_Sum < target)
            {
                left++;
            }
            else{
                right--;
            }
        }

        return new int[]{0,0};    
    }
}
