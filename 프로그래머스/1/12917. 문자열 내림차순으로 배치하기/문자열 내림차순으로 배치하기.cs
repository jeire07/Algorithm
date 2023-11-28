using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
        List<char> chars = s.ToCharArray().ToList();
        chars.Sort();
        chars.Reverse();
        string answer = new string(chars.ToArray());

        return answer;
    }
}