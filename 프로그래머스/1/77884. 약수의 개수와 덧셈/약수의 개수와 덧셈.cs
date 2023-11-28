using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        int index = 0;
        int length = right - left + 1;
        int[] cnt = new int[length];
        Array.Fill(cnt, 0);
        
        for(int i = left; i <= right; i++)
        {
            for(int j = 1; j * j <= i; j++)
            {
                if(i % j == 0)
                {
                    if(j * j != i) cnt[index] += 2;
                    else cnt[index]++;
                }
            }
            index++;
        }
        
        for(int i = 0; i < length; i++)
        {
            if(cnt[i] % 2 == 0)
            {
                answer += left + i;
            }
            else
            {
                answer -= left + i;
            }
        }
        return answer;
    }
}