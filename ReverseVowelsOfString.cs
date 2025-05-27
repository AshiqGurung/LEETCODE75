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

        TimeComplexity of : O(n)
        space complexity O(n)

    //Now using 2 pointers to fix this in o(n) and O(1)

            var chars = s.ToCharArray();
        int startIndex = 0;
        int lastIndex = chars.Length - 1;

        Console.WriteLine(lastIndex);

        while(startIndex < lastIndex){
            while(startIndex < lastIndex && !vowels.Contains(chars[startIndex])){
                 startIndex++;
            }

            while(startIndex < lastIndex && !vowels.Contains(chars[lastIndex])){
                lastIndex--;
            }

            if( startIndex < lastIndex){
                var temp = chars[startIndex];
                chars[startIndex] = chars[lastIndex];
                chars[lastIndex] = temp;

                startIndex++;
                lastIndex--; 
            }
        }
        return new String(chars);

    }
}
