public class Solution {
    public string ReverseWords(string s) {
        StringBuilder reversedString = new StringBuilder("", s.Trim().Length);
        string[] words = s.Trim().Split(" ");
        for (int i = words.Length-1; i >= 0; i--) {
            if (words[i] != " " && words[i] != "") {
                reversedString.Append(words[i].Trim());
                if (i > 0) {
                    reversedString.Append(" ");
                }
            }
        }
        return reversedString.ToString().Trim();
    }
}
