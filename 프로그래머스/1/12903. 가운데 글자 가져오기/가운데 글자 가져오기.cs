public class Solution {
    public string solution(string s) {
        if(s.Length % 2 == 0)
        {
            return $"{s[s.Length / 2 - 1]}{s[s.Length / 2]}";
        }
        else
        {
            return $"{s[s.Length / 2]}";
        }
    }
}