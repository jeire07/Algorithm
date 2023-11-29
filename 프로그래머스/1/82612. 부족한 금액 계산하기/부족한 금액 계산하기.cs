using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long remain = money;

        for(int i = 1; i <= count; i++)
        {
            remain -= (long)price * (long)i;
        }
        return (remain < 0) ? (remain * (-1)) : 0;
    }
}