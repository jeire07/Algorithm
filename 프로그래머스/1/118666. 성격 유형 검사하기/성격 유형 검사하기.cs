using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        Dictionary<char, int> points = new Dictionary<char, int>
        {
            {'R', 0}, {'T', 0}, {'C', 0}, {'F', 0},
            {'J', 0}, {'M', 0}, {'A', 0}, {'N', 0}
        };

        for(int i = 0; i < survey.Length; i++)
        {
            if (choices[i] > 4)
                points[survey[i][1]] += choices[i] - 4;
            else
                points[survey[i][0]] += 4 - choices[i];
        }

        StringBuilder sb = new StringBuilder();

        sb.Append((points['R'] >= points['T']) ? "R" : "T");
        sb.Append((points['C'] >= points['F']) ? "C" : "F");
        sb.Append((points['J'] >= points['M']) ? "J" : "M");
        sb.Append((points['A'] >= points['N']) ? "A" : "N");

        return sb.ToString();
    }
}