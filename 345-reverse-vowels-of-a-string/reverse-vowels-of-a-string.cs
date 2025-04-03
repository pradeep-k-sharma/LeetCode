public class Solution {
    public string ReverseVowels(string s) {
            int left =0;
			int right= s.Length-1;
			String vowels = "AEIOUaeiou"; // keep these vowels in a string and we will use string function Contains here.
			char [] arr = s.ToCharArray(); // because we will be replcing the vowels with two pointer hence string will not be good,
			
			while (left<right){ // iterate through the string with two pointers.
				if (vowels.Contains(arr[left])) {
					
					if (vowels.Contains(arr[right])){
                        // Once found, lets swap the position of the vowels.
						char temp = arr[left];
						arr[left] = arr[right];
						arr[right] = temp;
						left++; right--; // and move inwards
					}
                    else right--;
				}
				else 
				left++;
				
			}
			
			return String.Join("",arr);        
    }
}