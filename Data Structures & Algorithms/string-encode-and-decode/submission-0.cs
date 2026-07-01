public class Solution {

    public string Encode(IList<string> strs) 
    {
        if(strs == null || strs.Count == 0 ) return ""; 
        StringBuilder sb = new StringBuilder();
        foreach(string st in strs)
        {
            sb.Append(st.Length).Append('#').Append(st);
        }
        return sb.ToString();  
    }

    public List<string> Decode(string s) 
    {
        List<string> l1 = new List<string>();
        if(string.IsNullOrEmpty(s)) return l1;
        
        int i = 0;

        while(i < s.Length)
        {
            int j = i;
            while(s[j] != '#')
            {
                j++;
            }
            int length = int.Parse(s.Substring(i,j-i));

            string word = s.Substring(j+1,length);
            l1.Add(word);
            i = j+1 +length;
        }
        return l1;
    }
}
