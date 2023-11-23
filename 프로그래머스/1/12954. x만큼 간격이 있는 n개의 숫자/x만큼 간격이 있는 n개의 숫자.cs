public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];
        for(int i = 0; i <= (n-1); i++)
        {
            answer[i] = (long)x * ((long)i + 1);
        }
        return answer;
    }
}