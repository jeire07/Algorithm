using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        for (int i = 1; i <= number; i++)
        {
            int divCount = 0;
            for (int j = 1; j <= Math.Sqrt(i); j++)
            {
                if (j * j == i)
                {
                    divCount += 1;
                }
                else if (i % j == 0)
                {
                    divCount += 2;
                }

                if (divCount > limit)
                {
                    divCount = power;
                    break;
                }
            }
            answer += divCount;
        }
        return answer;
    }
}