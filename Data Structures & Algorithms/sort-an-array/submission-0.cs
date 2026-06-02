public class Solution {
    public int[] SortArray(int[] nums) 
    {
       MergeSort(nums ,0 ,nums.Length - 1);
       return nums;
    }


private void MergeSort(int[] arr, int l, int r)
{
    if(l == r) return;

    int m = (l+r)/2;
    MergeSort(arr,l,m);
    MergeSort(arr,m+1,r);
    Merge(arr,l,m,r);
}

private void Merge(int[] arr,int l, int m, int r)
{
    int i = l;
    int j=0;
    int k = 0;
    
    int[] left = arr[l..(m+1)];
    int[] right = arr[(m+1)..(r+1)];

    while(j < left.Length && k< right.Length)
    {
        if(left[j] <= right[k])
        {
            arr[i] = left[j];
            i++;j++;
        }else{
            arr[i] = right[k];
            i++;k++;
        }
    }

    while(j < left.Length)
    {
        arr[i] = left[j];
        i++;j++;
    }

    while(k < right.Length)
    {
        arr[i] = right[k];
        i++;k++;
    }
}
}