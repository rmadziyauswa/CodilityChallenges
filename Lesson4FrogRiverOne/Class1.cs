using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4FrogRiverOne
{
    public class Solution
    {
        public int solution(int X, int[] A)
        {
            var listOfIndicesWithX = Enumerable.Range(0, A.Length - 1).Where(i => A[i] == X);
            var requiredInts = Enumerable.Range(1, X).ToList<int>();
            foreach (var index in listOfIndicesWithX)
            {
                var listToIndex = A.Where((v, i) => i <= index).ToList<int>();
                var countOfRequiredInts = listToIndex.Where(v => requiredInts.Contains(v)).Distinct().Count();
                if(countOfRequiredInts == requiredInts.Count())
                {
                    return index;
                }
                
            }
            return -1;
        }
    }
}
