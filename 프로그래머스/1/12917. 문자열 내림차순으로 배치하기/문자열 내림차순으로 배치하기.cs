public class Solution {
    public string solution(string s) {
        char[] chars = s.ToCharArray();
        
        System.Array.Sort(chars);
        System.Array.Reverse(chars);
        
        return new string(chars);
    }
}