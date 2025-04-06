public class Solution {
    public string ReverseWords(string s) {
            s = reverse(s);
			Console.WriteLine(s);
			StringBuilder revrsestring = new StringBuilder();
			for (int i=0; i<s.Length; i++){
				string word = string.Empty;
				while (i< s.Length && s[i] !=' '){
					word = word+s[i];
					i++;
				}
				if (word.Length >0 ){
					revrsestring.Append(" " + reverse(word));
				}
			}
			s = revrsestring.ToString();
			return s.Substring(1,revrsestring.Length-1);
    }
    	static string reverse(string s){
        char[] chars = s.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
	}
}