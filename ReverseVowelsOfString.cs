public class Solution {
    public string ReverseVowels(string s) {
        
       HashSet<char> vowels = new HashSet<char> {
            'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U'
        };

        char[] chars = s.ToCharArray();

        List<char> vowelList = new List<char>();

        // Collect vowels from the string
        foreach (char c in chars) {
            if (vowels.Contains(c)) {
                vowelList.Add(c);
            }
        }

        // Reverse the list of vowels
        vowelList.Reverse();

        int vowelIndex = 0;

        // Replace vowels in chars with reversed vowels
        for (int i = 0; i < chars.Length; i++) {
            if (vowels.Contains(chars[i])) {
                chars[i] = vowelList[vowelIndex];
                vowelIndex++;
            }
        }

        return new string(chars);

    }
}
