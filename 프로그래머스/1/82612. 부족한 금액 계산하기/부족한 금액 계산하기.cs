using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long remain = money - (long)price * ((long)count * (1 + (long)count)) / 2;

        return (remain < 0) ? (remain * (-1)) : 0;
    }
}