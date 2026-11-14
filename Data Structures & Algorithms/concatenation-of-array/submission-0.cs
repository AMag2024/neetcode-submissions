public class Solution {
    public int[] GetConcatenation(int[] nums) {
        List<int> ans = nums.ToList();

        ans.AddRange(nums);

        return ans.ToArray();

    }
}