public class Solution {
    public int FindDuplicate(int[] arr) {
        
        // as this is given that the elements are in range of [1, n] so we can solve this by slow-fast approach
        // to optimize from space complexity. But time complexity remains same. 

        int slow = arr[0];
		int fast=arr[0];
		
        // This loop with identify the cycle in the list 
		do {
			slow = arr[slow]; // move to the value which is at index of slow
			
			fast = arr[arr[fast]]; // double hop to fast. Fast has to move double steps and slow just one step untill they both are equal
			
			
		} while (slow!=fast);
	
			slow = arr[0];
        // this will find the entry point of the cycle, known as joint. By moving both one step at a time.
		while (slow!=fast){
			slow = arr[slow];
			fast = arr[fast];
		}
		return slow;

        // here the time complexity will be O(n) but space complexity will be O(1) as we are using the fixed variables 
    }
}