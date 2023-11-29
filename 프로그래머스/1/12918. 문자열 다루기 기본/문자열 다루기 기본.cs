using System;
public class Solution {
    public bool solution(string s) {
        int number;
        if(int.TryParse(s, out number))
        {
            if((s.Length == 4) || (s.Length == 6))
            {
                return true;
            }
            return false;
        }
        return false;
    }
}