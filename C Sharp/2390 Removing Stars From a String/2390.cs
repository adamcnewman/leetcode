public class Solution {
    public string RemoveStars(string s) {
        StringBuilder starless = new StringBuilder("", s.Length);
        foreach (char c in s) {
            if (c == '*') {
                starless.Length--;
            } else {
                starless.Append(c);
            }
        }
        return starless.ToString();
    }
}
