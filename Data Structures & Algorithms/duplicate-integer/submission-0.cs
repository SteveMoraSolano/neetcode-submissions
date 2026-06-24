public class Solution {
    public bool hasDuplicate(int[] nums) {
        var i = new HashSet<int>();
        foreach(int num in nums){
            if(!i.Add(num)){
                return true;
            }
        }
        return false;
    }
}