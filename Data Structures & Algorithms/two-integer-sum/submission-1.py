class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        index = {}

        for i, n in enumerate(nums):
            index[n] = i
        
        for i, n in enumerate(nums):
            difference = target - n
            if difference in index and index[difference] != i:
                return [i, index[difference]]
