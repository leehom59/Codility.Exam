using System;

namespace Geekors.Codility.Exam
{
    public class Task1
    {
        public int solution(int A, int B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int SquCnt = 0;
            if (A > B) return 0;
            for (int i = A; i <= B ; i++)
            {
                double r = Math.Log(i, 2) % 1.0;
                if (r == 0.0) SquCnt++;
            }

            return SquCnt;
        }
    }
}
