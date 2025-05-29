public class Solution {
    public bool IncreasingTriplet(int[] nums) {
         int size = nums.Length;
         int firstNumber = int.MaxValue;
         int secondNumber = int.MaxValue;

        for(int i = 0; i < size; i++){
            if(nums[i] <= firstNumber){
                firstNumber = nums[i];
            }else if(nums[i] <= secondNumber){
                secondNumber = nums[i];
            }
            else{
                return true;
            }
        }
        return false;
    }
}
