public class Solution {
    public bool IsAnagram(string s, string t) 
    {

        if(s.Length != t.Length) return false;
        char[] s_arr = s.ToCharArray();
        char[] t_arr = t.ToCharArray();

        Array.Sort(s_arr);
        Array.Sort(t_arr);

        return new string(s_arr) == new string(t_arr);
    
    }
}
