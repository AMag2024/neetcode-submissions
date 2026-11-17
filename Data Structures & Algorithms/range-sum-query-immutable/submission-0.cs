public class NumArray {

    private int[] mNumArray;
    private int[] prefix;

    public NumArray(int[] nums) {
        mNumArray = nums;
        prefix = new int[nums.Length + 1];

        prefix[0] = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            prefix[i + 1] = nums[i] + prefix[i];
        }

    }
    
    public int SumRange(int left, int right) {
        return prefix[right + 1] - prefix[left];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */