public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict = new();
        var buckets = new List<int>[nums.Length + 1];
        var result = new int[k];

        foreach(int cur in nums)
        {
            dict.TryGetValue(cur, out int currentCount);
            dict[cur] = currentCount + 1;
        }

        foreach(var kvp in dict)
        {
            if(buckets[kvp.Value] == null)
            {
                buckets[kvp.Value] = new List<int>();
               
            }
             buckets[kvp.Value].Add(kvp.Key);
        }

        int count = 0;
        for(int i = buckets.Length - 1; i > 0; i--)
        {
            if(buckets[i] != null && count < k)
            {
                foreach(int val in buckets[i])
                {
                    result[count] = val;
                    count++;
                }
            }

        }

        return result;

    }
}
