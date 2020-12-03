using System;
using Lesson2CyclicRotation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CyclicRotationUnitTest
    {
        [TestMethod]
        public void CyclicRotationUnitTest_Must_Always_Pass()
        {
            int[] array1 = new int[] { 3, 8, 9, 7, 6 };
            int k1 = 3;
            int[] expectedAns1 = new int[] { 9, 7, 6, 3, 8 };

            Solution sol = new Solution();
            var actualAnswer1 = sol.solution(array1, k1);
            Assert.AreEqual<int[]>(expectedAns1, actualAnswer1);

        }
    }
}
