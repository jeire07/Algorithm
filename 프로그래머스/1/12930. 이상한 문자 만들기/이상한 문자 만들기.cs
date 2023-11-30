public class Solution {
    public string solution(string s) {
        char[] characters = s.ToCharArray();
        int j = 0;
        string answer = "";
        for(int i = 0; i < characters.Length; i++)
        {
            if(characters[i] == ' ')
            {
                j = 0;
                answer += characters[i];
            }
            else if(j % 2 == 0)
            {
                answer += (characters[i].ToString()).ToUpper();
                j++;
            }
            else
            {
                answer += (characters[i].ToString()).ToLower();
                j++;
            }
        }
        return answer;
    }
}