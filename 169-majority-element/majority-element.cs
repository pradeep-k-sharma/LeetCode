public class Solution {
    public int MajorityElement(int[] arr) {
        int major =0; // Considering this as the major element in the array
		int freq=0; // initialize the frequency with zero
		
		// Voting algo where is is sure that at least one major element would always be there in the array.
		for (int i=0; i< arr.Length; i++){
			
			if (freq == 0)
				major = arr[i];
			if (major == arr[i]) freq++;
			else freq--;
		}
		
		return major;
    }
}