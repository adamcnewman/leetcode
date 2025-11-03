public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        IList<bool> result = new List<bool>();
        int mostCandies = 0;

        // See what kid(s) have the most number of candies first
        for (int i = 0; i < candies.Length; i++) {
            mostCandies = candies[i] > mostCandies ? candies[i] : mostCandies;
        }

        // Check what kids would have the most candies
        for (int i = 0; i < candies.Length; i++) {
            result.Add(candies[i] + extraCandies >= mostCandies);
        }
        return result;
    }
}
