public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        //check if target - num is in a hash map if it is return true if it isnt return false\
        Dictionary<int,int> dict = new();

        for(int i = 0; i < nums.Length; i++){
            int comp = target-nums[i];
            if(dict.ContainsKey(comp))
            {
                return [dict[comp],i];
            }else{
                dict.Add(nums[i],i);
            }
        }
        return [0,0];


    }
}
