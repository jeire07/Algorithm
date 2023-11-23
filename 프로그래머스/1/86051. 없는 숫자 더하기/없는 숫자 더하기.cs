using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        for (int i = 0; i <= 9; i++)
        {
            if(Array.FindIndex(numbers, num => num == i) < 0)
            {
                answer += i;
            }
        }
        return answer;
    }
}