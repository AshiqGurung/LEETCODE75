public class Solution {
    public void MoveZeroes(int[] nums) {
        // int[] result = new int[10];
        int zeroNumber = 0;
        for(int i = 0; i< nums.Length; i++){
            if(nums[i] != 0){
                int temp = nums[i];
                nums[i] = nums[zeroNumber];
                nums[zeroNumber] = temp;
                zeroNumber++;
            }
        }
    }
}
