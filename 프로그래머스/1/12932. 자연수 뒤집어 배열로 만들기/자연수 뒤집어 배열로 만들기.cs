public class Solution {
    public int[] solution(long n) {
        string num = n.ToString();
        int[] answer = new int[num.Length];
        for(int i = 0; n > 0; i++)
        {
            answer[i] = (int)(n % 10);
            n /= 10;
        }
        return answer;
    }
}