using System;
public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        Console.WriteLine($"{n}, {m}");
        
        answer[0] = 1;      // GCD
        answer[1] = n * m;  // LCM
        
        //GCD calc
        while (m != 0)
        {
            answer[0] = m;
            m = n % m;
            n = answer[0];
        }
        
        //LCM calc
        answer[1] /= answer[0];
        
        return answer;
    }
}