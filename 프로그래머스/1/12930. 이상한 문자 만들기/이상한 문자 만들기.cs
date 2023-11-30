public class Solution {
    public string solution(string s) {
        int j = 0;
        string answer = "";
        for(int i = 0; i < s.Length; i++)
        {
            answer += (j % 2 == 0) ? s[i].ToString().ToUpper() : s[i].ToString().ToLower();
            
            j = (s[i] == ' ') ? 0 : j + 1;
        }
        return answer;
    }
}