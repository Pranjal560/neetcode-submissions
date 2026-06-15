public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> anagramMap = new Dictionary<string, List<string>>();

        foreach(string word in strs) {
            // 1. Generate the Signature
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            // 2. Check the Bucket
            if(!anagramMap.ContainsKey(key)) {
                 anagramMap[key] = new List<string>();
            }
            
            // 3. Drop the word in the Bucket
            anagramMap[key].Add(word);
        }

        // 4. Return all Buckets
        return new List<List<string>>(anagramMap.Values);
    }
}