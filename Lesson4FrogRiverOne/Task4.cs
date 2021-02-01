using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4FrogRiverOne
{
    public class Task4
    {
        public bool solution(int N, int[] A, int[] B)
        {
            var result = true;
            for (int i = 1; i < N; i++)
            {
                var j = i + 1;

                var iInA = FindAllIndices(A, i);
                var jInA = FindAllIndices(A, j);

                var iInB = FindAllIndices(B, i);
                var jInB = FindAllIndices(B, j);

                if(!(
                    IsConnected(iInA,jInB) ||
                    IsConnected(iInB,jInA)
                    ))
                {
                    result = false;
                }
            }
            return result;
        }

        public int[] FindAllIndices(int[] myarr,int s)
        {
            int[] v = myarr.Select((b, i) => b == s ? i : -1).Where(i => i != -1).ToArray();
            return v;
        }

        public bool IsConnected(int[] x, int[] y)
        {
            var result = false;
            if(x.Length > y.Length)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    try
                    {
                        if (y.Contains(x[i]))
                        {
                            result = true;
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
            }
            else
            {
                for (int i = 0; i < y.Length; i++)
                {
                    try
                    {
                        if (x.Contains(y[i]))
                        {
                            result = true;
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
            }
      
            return result;
        }
    }
}
