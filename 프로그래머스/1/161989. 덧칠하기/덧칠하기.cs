using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int paintMax = 0;
        int answer = 0;
        for(int i = 0; i < section.Length; i++)
        {
            if (section[i] > paintMax)
            {
                paintMax = section[i] + m - 1;
                answer++;
            }
        }
        return answer;
    }
}