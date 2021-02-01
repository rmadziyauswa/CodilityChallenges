using System;

namespace Lesson4FrogRiverOne
{
    public class MostPop
    {
        public int mostPopularNumber(int[] arr,int inty)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == inty)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
