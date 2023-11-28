using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int length = right - left + 1;
        
        for(int i = left; i <= right; i++)
        {
            int cnt = 0;
            
            for(int j = 1; j * j <= i; j++)
            {
                if(i % j == 0)
                {
                    if(j * j != i) cnt += 2;
                    else cnt++;
                }
            }
            answer += ((cnt % 2) == 0) ? i : i * (-1);
        }
        return answer;
    }
}