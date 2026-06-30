public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    Dictionary<int,int> numToIndex = new Dictionary<int,int>();
    int[] result = [0,0];
      for(int i = 0;i < nums.Length; i++){
        int complement = target - nums[i];
         if(numToIndex.ContainsKey(complement)){
            return [numToIndex[complement],i];
        }
        numToIndex[nums[i]] = i;     
      }  
      return [-1,-1];
    }
}
