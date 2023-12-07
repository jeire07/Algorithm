using System;

public class Solution {
    public int solution(string s) {
        string[] num = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        for(int i = 0; i < 10; i++)
        {        
            s = s.Replace(num[i], i.ToString());
        }

        return Int32.Parse(s);
    }
}