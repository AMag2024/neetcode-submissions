
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

        //[r,-1][a,0][c,-1][e,0][b,1]

        foreach(char c in t)
        {
            if(!dict.ContainsKey(c)){
                return false;
            }else{
                dict[c]--;
            }
        }

        foreach (var kvp in dict)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

        foreach(var kvp in dict){
            if(kvp.Value != 0){
                return false;
            }
        }
        return true;
    }
}
