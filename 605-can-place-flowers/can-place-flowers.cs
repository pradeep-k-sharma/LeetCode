public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        // if we dont have to plant anything then simply return true
        if (n==0) return true;

        // Loop through the complet bed
        for(int i = 0; i<flowerbed.Length; i++){
            //Check for the empty place first
            if(flowerbed[i]==0) { 
               bool left = (i == 0 || flowerbed[i-1] == 0); // check if the pointer is at starting or left place is empty
               bool right = (i==(flowerbed.Length - 1) || flowerbed[i+1] == 0); // check if the pointer is at the end and next place is empty
               if (left && right){
                n--; // reduce one flower from the stock.
                flowerbed[i]=1; // plant the flower so that we can check this as planted.
               }
               if (n==0) break;
            }
        }
        return (n==0?true:false);
    }
}