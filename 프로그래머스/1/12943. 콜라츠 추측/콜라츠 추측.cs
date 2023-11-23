public class Solution {
    public int solution(int num) {
        long n = num;
        int answer = 0;
        while (answer < 500)
        {
            if(n == 1)
            {
                return answer;
            }
            else if ((n % 2) == 0)
            {
                n /= 2;
                answer++;
            }
            else
            {
                n = 3 * n + 1;
                answer++;
            }
        }
        answer = -1;
        return answer;
    }
}