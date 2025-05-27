public class Solution {
    public string ReverseWords(string s) {
        var newString = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var newWords = newString.Reverse();
        return string.Join(" ", newWords);
    }
}
