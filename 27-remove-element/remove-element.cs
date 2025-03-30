public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0, j = 0;
    
    while (i < nums.Length) {
        if (nums[i] != val) {
            if (i != j) { // Avoid unnecessary self-assignment
                nums[j] = nums[i];
            }
            j++; // Move the valid index forward
        }
        i++; // Move to the next element
        }   
        return j;
    }
}