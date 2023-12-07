using System;

public class Solution {
    public int solution(string s) {
        string key = "";
        string number = "";
        string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        for (int i = 0; i < s.Length; i++)
        {
            key += s[i];
            if(int.TryParse(key, out int result))
            {
                number += result.ToString();
                key = "";
            }
            else if (Array.IndexOf(words, key) >= 0)
            {
                number += Array.IndexOf(words, key).ToString();
                key = "";
            }
        }
        return int.Parse(number);
    }
}