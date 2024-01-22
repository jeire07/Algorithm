using System;

public class Solution
{
    public int[] solution(string[] wallpaper)
    {
        int minX = wallpaper[0].Length - 1;
        int minY = wallpaper.Length - 1;
        int maxX = 0;
        int maxY = 0;

        for(int y = 0; y < wallpaper.Length; y++)
        {
            for(int x = 0; x <  wallpaper[0].Length; x++)
            {
                if(wallpaper[y][x] == '#')
                {
                    if(y < minY) minY = y;
                    if(y > maxY) maxY = y;
                    if(x < minX) minX = x;
                    if(x > maxX) maxX = x;
                }
            }
        }

        return new int[4] { minY, minX, maxY + 1, maxX + 1 };
    }
}