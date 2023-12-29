using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;

        int[] clothes = new int[n];

        for (int i = 0; i < n; i++)
            clothes[i] = 1;
        for (int i = 0; i < lost.Length; i++)
            clothes[lost[i] - 1]--;
        for (int i = 0; i < reserve.Length; i++)
            clothes[reserve[i] - 1]++;

        for (int i = 0; i < clothes.Length; i++)
        {
            if (clothes[i] == 0)
            {
                if(i > 0 && clothes[i - 1] == 2)
                {
                    clothes[i - 1] = 1;
                    clothes[i] = 1;
                }
                else if(i < clothes.Length - 1 && clothes[i + 1] == 2)
                {
                    clothes[i + 1] = 1;
                    clothes[i] = 1;
                }
            }
        }

        for (int i = 0; i < clothes.Length; i++)
            if (clothes[i] > 0)
                answer++;

        return answer;
    }
}