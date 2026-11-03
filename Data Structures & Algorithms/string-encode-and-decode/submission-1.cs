public class Solution {

    public string Encode(IList<string> strs) {
        string result = "";
        foreach(string s in strs)
        {
            result += s.Length + "#" + s;
        }
        return result;
    }

    public List<string> Decode(string s) {
        List<string> result = new();
        int i = 0;
        while (i < s.Length)
        {
            int j = i;
            while(s[j] != '#')
            {
                j++;
            }
            int length = int.Parse(s[i..j]);
            result.Add(s.Substring(j+1, length));
            i = j + 1 + length;
        }
        return result;
   }
}
