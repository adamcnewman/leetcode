public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder newString = new StringBuilder("", word1.Length + word2.Length);
        int w1p = 0;
        int w2p = 0;
        while (w1p < word1.Length || w2p < word2.Length) {
            if (w1p < word1.Length) {
                newString.Append(word1[w1p]);
                w1p++;
            }
            if (w2p < word2.Length) {
                newString.Append(word2[w2p]);
                w2p++;
            }
        }
        return newString.ToString();
    }
}
