using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        //best rank, worst rank
        int[] answer = {7, 7};

        for(int i = 0; i < 6; i++)
        {
            if (lottos[i] == 0)
            {
                answer[0]--;
            }
            else
            {
                bool contains = win_nums.Any(num => num == lottos[i]);

                if (contains)
                {
                    answer[0]--;
                    answer[1]--;
                }
            }
        }
        if(answer[0] == 7) answer[0] = 6;
        if(answer[1] == 7) answer[1] = 6;

        return answer;
    }
}