using System;

public class Solution {
    public long solution(long n) {
        if(Math.Sqrt(n) == (long)Math.Sqrt(n)) n = ((long)Math.Sqrt(n)+1) * ((long)Math.Sqrt(n)+1);
        else n = -1;
        return n;
    }
}