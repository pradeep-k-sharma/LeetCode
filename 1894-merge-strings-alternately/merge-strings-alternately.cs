public class Solution {
    public string MergeAlternately(string str1, string str2) {
            /* this uses char[] and then pushes the alternate element to this.
            there is another approach by using StringBuilder in C#, which is more efficient to this.
            int count = str1.Length>str2.Length?str1.Length:str2.Length;
            char[] newstr = new char[str1.Length+str2.Length];
            int ptnewstr = 0;
            for (int i = 0; i<count; i++)
            {
                if (i<str1.Length)
                {
                    newstr[ptnewstr] = str1[i];
                    ptnewstr++;
                }
                if (i < str2.Length)
                {
                    newstr[ptnewstr] = str2[i];
                    ptnewstr++;
                }
                
            }

            string newstring = new string(newstr);  
            return newstring;
            */
        //Approach using StringBuilder with two pointers. One for one word and another from second word.
        int i = 0, j = 0;
        int len1 = str1.Length, len2 = str2.Length;
        StringBuilder result = new StringBuilder(len1 + len2);

        while (i < len1 || j < len2) {
            if (i < len1) result.Append(str1[i++]);
            if (j < len2) result.Append(str2[j++]);
        }

        return result.ToString();
    }
}