public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        for (int i = 1; (i*i) <= n; i++)
        {
            if (n == 0) break;
            else if (n == (i*i)) answer += i;
            else if ((n % i) == 0) answer += i + (n/i);
        }
        return answer;
    }
}