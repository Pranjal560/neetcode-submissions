public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }

        char[] s_Arr = s.ToCharArray();
        char[] t_Arr = t.ToCharArray();

        Array.Sort(s_Arr);
        Array.Sort(t_Arr);

        return new string(s_Arr) == new string(t_Arr);
    }
}
