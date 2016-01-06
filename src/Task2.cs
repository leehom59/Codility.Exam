namespace Geekors.Codility.Exam
{
    public class Task2
    {
        bool Swapped = false;
        public bool solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int LeftIdx = 0;
            int RightIdx = A.Length - 1;

            while (LeftIdx < RightIdx + 1)
            {
                if ((LeftIdx < A.Length - 1) && A[LeftIdx] > A[LeftIdx + 1])
                {
                    if (Swapped) return false;
                    //find right
                    while (RightIdx > LeftIdx)
                    {
                        if (RightIdx > 0 && A[RightIdx] <= A[RightIdx - 1])
                        {
                            Swap(A, LeftIdx, RightIdx);
                            break;
                        }
                        else
                            RightIdx--;
                    }
                }
                else
                    LeftIdx++;
            }

            return true;
        }

        void Swap(int[] A, int SourceIdx, int TargetIdx)
        {
            int Temp = A[SourceIdx];
            A[SourceIdx] = A[TargetIdx];
            A[TargetIdx] = Temp;
            Swapped = true;
        }
    }
}
