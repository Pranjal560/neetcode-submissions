public class Solution {
    public void SortColors(int[] nums) 
    {
        int i = 0;
        int l = 0;
        int r = nums.Length-1;

        while(i <= r)
        {
            if(nums[i] == 0)
            {
                Swap(nums,l,i);
                i++;l++;
            }else if(nums[i] == 2)
            {
                Swap(nums,i,r);
                r--;
            }else{
                i++;
            }
        }
        foreach(int j in nums)
        {
            Console.WriteLine(j);
        }    
    }

    private void Swap(int[] arr, int l,int r)
    {
        int temp = arr[l];
        arr[l] = arr[r];
        arr[r] = temp;
    }
}