using System;

namespace Lesson3FrogJump
{
    public class Solution {
        public int solution(int X, int Y, int D)
        {
            if(X <= Y)
            {
                return (int)Math.Ceiling(((double)Y - X) / D);
            }
            return 0;
        }

    }
}
