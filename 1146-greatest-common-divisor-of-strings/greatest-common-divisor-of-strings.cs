public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        // if these two strings really have a GCD then validate that first 
        // if adding these alternatively makes them equal. If not, then simply return blank.
        if (str1+str2 != str2+str1)
        {
            return ""; 
        }

        int n1 = str1.Length;
        int n2 = str2.Length;
            
            // Consider n2>n1 is not then swap these two and move further.
            if (n1 < n2)
            {
                n1 = n1 + n2;
                n2 = n1 - n2;
                n1 = n1 - n2;
            }

            int rem = 1; // if GCD exists then least GCD is 1.
            while (rem != 0)
            {
                rem = n1 % n2;
                if (rem == 0)
                {
                    break;
                }
                n1 = n2;
                n2 = rem;
            }
        return str1.Substring(0, n2); // Once GCD is found then simply pick that length from any of the strings.
    }
}