public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dict = new();

        //key made up of the letters from the string

        foreach(string cur in strs){
            string key = "";
            var letterCounts = new int[26];
            foreach(char c in cur)
            {
                letterCounts[c - 'a']++;
            }
            key = string.Join(",", letterCounts);
            if(dict.TryGetValue(key, out List<string> value))
                {
                    value.Add(cur);
                }else
                {
                  dict.Add(key, []);
                  dict[key].Add(cur);  
                }
        }

            return dict.Values.ToList();
       

    }
}
