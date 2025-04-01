public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
IList<bool> ret = new List<bool>();
            // find the largest number of candies a kid has. in C# array.Max() gives me the maximum one.
            //int max  = candies.Max();

            // But if we dont use this then we can trace the array and pick the largest with complexity of O(n)
            int max = candies[0];
            for (int i = 1; i < candies.Length; i++)
            {
                if (candies[i]>max)
                {
                    max = candies[i];
                }

            }
            // Loop through each element and add values to the list based on the validation.
            foreach (int cand in candies)
            {
                if (max > cand + extraCandies)
                {
                    ret.Add(false);
                }
                else
                {
                    ret.Add(true);
                }
            }
            return ret;
    }
}