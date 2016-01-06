namespace Geekors.Codility.Exam
{
    public class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    }
    public class Task3
    {
        int rootValue = 0;
        public int solution(Tree T)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int defaultVisible = 1;
            rootValue = T.x;
            return defaultVisible + Calc(T);
        }

        int Calc(Tree T)
        {
            int sum = 0;
            if (T.l == null && T.r == null)
                return 0;
            if (T.l != null)
                if (T.l.x > T.x && T.l.x >= rootValue)
                    sum += 1 + Calc(T.l);
                else
                    sum += 0 + Calc(T.l);
            if (T.r != null)
                if (T.r.x > T.x && T.r.x >= rootValue)
                    sum += 1 + Calc(T.r);
                else
                    sum += 0 + Calc(T.r);

            return sum;
        }
        
    }
}
