public class Solution {
    public string solution(int n) {
        string answer = "";
        for(int i = 1; i <= n; i++) answer += (i % 2) == 0 ? "박" : "수";
        return answer;
    }
}