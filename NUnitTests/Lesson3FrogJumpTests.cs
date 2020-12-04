using System.Collections.Generic;
using System.Linq;
using Lesson3FrogJump;
using NUnit.Framework;

namespace NUnitTests
{
    public class Lesson3FrogJumpTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var sol = new Solution();
            var listOfXs = new List<int> {10,20 };
            var listOfYs = new List<int> { 85,100};
            var listOfDs = new List<int> {30,5 };
            var listOfExpecteds = new List<int> { 3,16};
            for (int i = 0; i < listOfXs.Count; i++)
            {
                var actualAnswer = sol.solution(listOfXs[i], listOfYs[i], listOfDs[i]);
                Assert.AreEqual(actualAnswer, listOfExpecteds[i]);
            }
        }
    }
}