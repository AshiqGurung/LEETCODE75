public class Solution {
    public int Compress(char[] chars) {
        int size = chars.Length;
        int write = 0;
        int read = 0;

        while (read < size){
            char currentChar = chars[read];
            int count = 0;

            while(read < size && chars[read] == currentChar){
                read++;
                count++;
            }

            chars[write++] = currentChar;

            if(count > 1){
                foreach(char c in count.ToString()){
                    chars[write++] = c;
                }
            }
        }
        
        return write;
        
    }
}
