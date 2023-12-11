using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        
        for(int i = 1; i < food.Length; i++)
        {
            food[i] = food[i] / 2;
            for(int j = 0; j < food[i]; j++)
            {
                answer += $"{i}";
            }
        }
        
        answer += "0";
        
        for(int i = food.Length - 1; i > 0; i--)
        {
            for(int j = 0; j < food[i]; j++)
            {
                answer += $"{i}";
            }
        }
        
        return answer;
    }
}