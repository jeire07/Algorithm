using System;
using System.Linq;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        string a = new string("abcdefghijklmnopqrstuvwxyz".Where(x => !skip.Contains(x)).ToArray());
        foreach(var t in s) {
            answer += a[(a.IndexOf(t.ToString()) + index)%a.Length];
        }

        return answer;
    }
}