using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[,] students = { { 1, 2, 3, 4, 5 }, { 2, 1, 3, 4, 5 }, { 3, 1, 2, 4, 5 } };

        int[] scores = new int[3];
        int index = 1;

        for (int i = 0; i < answers.Length; i++)
        {
            scores[0] += (students[0, i % 5] == answers[i]) ? 1 : 0;
            scores[2] += (students[2, i % 10 / 2] == answers[i]) ? 1 : 0;

            if (i % 2 == 0)
            {
                scores[1] += students[1, 0] == answers[i] ? 1 : 0;
            }
            else
            {
                scores[1] += students[1, index] == answers[i] ? 1 : 0;
                index = (index == 4) ? 1 : ++index;
            }

            scores = scores;
        }

        int maxScore = scores[0] > scores[1] ? scores[0] : scores[1];
        maxScore = maxScore > scores[2] ? maxScore : scores[2];

        List<int> winner = new List<int>();
        for(int i = 0; i < 3; i++)
        {
            if(maxScore == scores[i])
            {
                winner.Add(i + 1);
            }
        }

        int[] answer = winner.ToArray();
        return answer;
    }
}