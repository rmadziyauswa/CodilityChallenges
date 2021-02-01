using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4FrogRiverOne
{
    public class Rtask3
    {
        public int solution(int[] A, int S)
        {
            var result = 0;
            var greatest = 1000000000;
            var contList = new List<int[]>();
            for (int k = 0; k < A.Length; k++)
            {
                for (int i = k; i < A.Length; i++)
                {
                    var contArray = new List<int>();
                    for (int j = k; j <= i; j++)
                    {
                        contArray.Add(A[j]);
                    }

                    contList.Add(contArray.ToArray());
                }
            }
      

            foreach (var item in contList)
            {
                if(GetMean(item) == (double)S)
                {
                    result++;
                }
            }

            if(result > greatest)
            {
                result = greatest;
            }
            return result;
        }

        public double GetMean(int[] A)
        {
            return A.Average();
        }
    }
}
