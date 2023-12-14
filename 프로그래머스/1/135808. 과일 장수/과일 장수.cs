using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;

        int[] apples = new int[k + 1];

        for (int i = 0; i < score.Length; i++)
        {
            int index = score[i];
            apples[index]++;
        }

        apples = apples;

        for(int i = k; i > -1;)
        {
            if (i == 0)
            {
                return answer;
            }
            else if (apples[i] >= m)
            {
                apples[i] -= m;
                answer += i * m;
            }
            else
            {
                apples[i - 1] += apples[i];
                apples[i] = 0;
                i--;
            }
        }
        return answer;
    }
}