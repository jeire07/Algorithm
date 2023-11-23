public class Solution {
    public long solution(int a, int b) {
        if(a == b) return a;
        long answer = a;
        int i = 1;
        if(a > b) i = -1;
        while(a != b)
        {
            a = a + i;
            answer += a;
        }
        return answer;
    }
}