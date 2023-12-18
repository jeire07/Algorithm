using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int limit = 3000;
        bool[] isPrime = new bool[limit + 1];

        // 초기화: 모든 수를 소수로 가정
        for (int i = 2; i <= limit; i++)
        {
            isPrime[i] = true;
        }

        // 에라토스테네스의 체 알고리즘
        for (int i = 2; i <= Math.Sqrt(limit); i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= limit; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }
        
        for(int i = 0; i < nums.Length - 2; i++)
        {
            for(int j = i + 1; j < nums.Length - 1; j++)
            {
                for(int k = j + 1; k < nums.Length; k++)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    System.Console.WriteLine($"{nums[i]} {nums[j]} {nums[k]}");
                    
                    answer += isPrime[sum] ? 1 : 0;
                }
            }
        }
        
        return answer;
    }
}