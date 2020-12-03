using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2CyclicRotation
{
    public class Solution
    {
        public int[] solution(int[] A, int K)
        {
            var result = A.ToList();
            var lastIndex = A.Length - 1;
            for (int i = 0; i < K; i++)
            {
                var elementToMove = result[lastIndex];
                result.RemoveAt(lastIndex);
                result = result.Prepend(elementToMove).ToList();
            }
            return result.ToArray();
        }
    }
}
