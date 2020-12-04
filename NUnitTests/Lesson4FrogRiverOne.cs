using System.Collections.Generic;
using System.Linq;
using Lesson4FrogRiverOne;
using NUnit.Framework;

namespace NUnitTests
{
    public class Lesson4FrogRiverOne
    {
        [Test]
        public void Test1()
        {
            var sol = new Solution();
            var listOfXs = new List<int> { 5 };
            var listOfArrays = new List<int[]> { new int[] {1,3,1,4,2,3,5,4 } };
            var listOfExpecteds = new List<int> { 6 };
            for (int i = 0; i < listOfXs.Count; i++)
            {
                var actualAnswer = sol.solution(listOfXs[i], listOfArrays[i]);
                Assert.AreEqual(actualAnswer, listOfExpecteds[i]);
            }
        }
    }
}
