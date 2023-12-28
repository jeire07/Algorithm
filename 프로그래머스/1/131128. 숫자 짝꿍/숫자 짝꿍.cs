using System;
using System.Linq;
using System.Text;

public class Solution
{
	public string solution(string X, string Y)
	{
		StringBuilder sb = new StringBuilder();

		int[] xDigits = new int[10];
		int[] yDigits = new int[10];

		foreach(char c in X)
            xDigits[c - '0']++;
			
		foreach(char c in Y)
            yDigits[c - '0']++;
        
		for (int i = 9; i >= 0; i--)
		{
			int count = xDigits[i] < yDigits[i] ? xDigits[i] : yDigits[i];

			for (int j = 0; j < count; j++)
                sb.Append(i);
		}

		if (sb.Length == 0)
			return "-1";

		if (sb.ToString().ToCharArray().Where<Char>(x => x == '0').Count() == sb.Length)
			return "0";

		return sb.ToString();
	}
}