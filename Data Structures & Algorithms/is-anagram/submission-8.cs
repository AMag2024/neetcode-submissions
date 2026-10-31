
public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> dict = new();

        if(s.Length != t.Length)
        return false;

        foreach(char c in s)
        {
            if(!dict.ContainsKey(c)){
                dict.Add(c, 1);
            }else{
                dict[c]++;
            }
        }

        foreach(char c in t)
        {
            if(!dict.ContainsKey(c)){
                return false;
            }else{
                dict[c]--;
                if(dict[c] < 0){
                    return false;
                }
            }
        }

        foreach(var kvp in dict){
            if(kvp.Value != 0){
                return false;
            }
        }
        return true;
    }
}
