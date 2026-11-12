public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        var set = nums.ToHashSet();
        int longestChain = 0;
        
        
        foreach(int cur in set)
        {
            int curChain = 0;

            if(!set.Contains(cur - 1))
            {
                int curNum = cur - 1;
                while(set.Contains(curNum + 1))
                {
                    curChain++;
                    curNum++;
                }

                if(curChain > longestChain) longestChain = curChain;
            } 
        }

        return longestChain;

    }
}
