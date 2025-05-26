public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0;
        int j= 0;
        StringBuilder concatenatedString = new StringBuilder();
        while(i < word1.Length || j < word2.Length){
            if(i < word1.Length){
                concatenatedString.Append(word1[i]);
                i++;
            }
            
            if(j < word2.Length){
                concatenatedString.Append(word2[j]);
                j++;
            }
        }

        return concatenatedString.ToString();
    }
}
