public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> result = [];
        foreach(int x in nums){
            if(!result.Add(x))
                return true;
        }
        return false;
    }
}