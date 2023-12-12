using System;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        int[] rank = new int[k];

        for(int i = 0; i < score.Length; i++)
        {
            if (score[i] > rank[0])
            {
                rank[0] = score[i];
                Array.Sort(rank);
            }
            answer[i] = rank[0];

            if(i < k - 1)
            {
                answer[i] = rank[k - 1 - i];
            }
        }
        return answer;
    }
}