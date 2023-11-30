using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        List<int> ternary = new List<int>();
        
        for(int i = 0; n > 0; i++)
        {
            ternary.Add(n % 3);
            n = n / 3;
        }
        
        ternary.Reverse();
        
        int answer = 0;
        
        for(int i = 0; i < ternary.Count; i++)
        {
            answer += ternary[i] * (int)Math.Pow(3, i);
        }
        
        return answer;
    }
}