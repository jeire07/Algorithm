using System;
using System.Collections.Generic;

public class Pos
{
    public int Y;
    public int X;
    public int MoveCnt;

    public Pos(int y, int x, int moveCount)
    {
        this.Y = y;
        this.X = x;
        this.MoveCnt = moveCount;
    }
}

public class Solution
{
    public int solution(string[] maps)
    {
        int answer = -1;
        Pos startPos = FindChar(maps, 'S');
        Pos leverPos = FindChar(maps, 'L');

        int moveCount1 = BFS(maps, startPos, 'L');
        int moveCount2 = -1;

        if (moveCount1 != -1)
            moveCount2 = BFS(maps, leverPos, 'E');

        if (moveCount2 != -1)
            answer = moveCount1 + moveCount2;

        return answer;
    }

    public Pos FindChar(string[] maps, Char findChar)
    {
        Pos pos = new Pos(0, 0, 0);

        for (pos.Y = 0; pos.Y < maps.Length; pos.Y++)
        {
            pos.X = maps[pos.Y].IndexOf(findChar);
            if (pos.X > -1) break;
        }

        return pos;
    }

    
    public int BFS(string[] maps, Pos startPos, Char findChar)
    {
        bool[,] boolArrays = new bool[maps.Length, maps[0].Length];
        int[] dirY = new int[4] { 1, -1, 0, 0 };
        int[] dirX = new int[4] { 0, 0, 1, -1 };

        var queue = new Queue<Pos>();
        queue.Enqueue(startPos);

        while (queue.Count > 0)
        {
            Pos currPos = queue.Dequeue();

            for (int i = 0; i < 4; i++)
            {
                Pos movePos = new Pos(currPos.Y + dirY[i], currPos.X + dirX[i], currPos.MoveCnt + 1);

                // out of map
                if (movePos.Y < 0 || movePos.Y >= maps.Length ||
                    movePos.X < 0 || movePos.X >= maps[0].Length)
                    continue;

                // wall or already passed
                if (maps[movePos.Y][movePos.X] == 'X' || boolArrays[movePos.Y, movePos.X])
                    continue;

                // arrival
                if (maps[movePos.Y][movePos.X] == findChar)
                    return movePos.MoveCnt;

                boolArrays[movePos.Y, movePos.X] = true;
                queue.Enqueue(movePos);
            }
        }

        return -1;
    }
}