public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        
        Dictionary<string, List<string>> dict1 = new Dictionary<string,List<string>>();
        foreach(string word in strs)
        {
            int[] count = new int[26];
            foreach(char s in word)
            {
                count[s-'a']++;
                
            }
            string key = string.Join("#",count);
            if(!dict1.ContainsKey(key))
            {
                dict1[key] = new List<string>();
            }
            dict1[key].Add(word);
            
        }  
        return new List<List<string>>(dict1.Values);  
    }
}
