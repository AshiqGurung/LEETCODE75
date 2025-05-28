//using Perfix and suffix style problem.
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
         int n = nums.Length;
         int[] newNums = new int[n];
         newNums[0] = 1;

         for(int i = 1; i < n; i++){
            newNums[i] = nums[i - 1] * newNums[i - 1];
         }

         int suffix = 1;
         for(int i = n- 1; i >= 0; i--){
            newNums[i] = newNums[i] * suffix;
            suffix *= nums[i];
         }

        return newNums.ToArray();
    }
}
