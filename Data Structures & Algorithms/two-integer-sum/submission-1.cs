public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // 1. Create the "Notebook" (Key = Number, Value = Index)
        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int currentNum = nums[i];
            int partnerNeeded = target - currentNum;

            // 2. Look Backward: Is the partner already in the book?
            if (seenNumbers.ContainsKey(partnerNeeded)) {
                // Yes! Return the partner's index and my index
                return new int[] { seenNumbers[partnerNeeded], i };
            }

            // 3. If not, add myself to the book
            // Use 'TryAdd' to avoid crashing on duplicates if the problem allows
            if (!seenNumbers.ContainsKey(currentNum)) {
                seenNumbers.Add(currentNum, i);
            }
        }
        
        return new int[0];
    }
}