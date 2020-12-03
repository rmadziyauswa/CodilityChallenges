using System;
using Lesson2CyclicRotation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class CyclicRotationUnitTest
    {
        [TestMethod]
        public void CyclicRotationUnitTest_Must_Always_Pass()
        {
            //Arrange
            Solution sol = new Solution();
            var numTests = 3;
            var listOfArrays = new List<int[]> {
                new int[] { 3, 8, 9, 7, 6 },
                new int[] { 0, 0, 0 },
                new int[] { 1, 2, 3, 4 }
            };
            var listOfKs = new List<int> { 3,1,4};
            var listOfExpectedAnswers = new List<int[]> {
                new int[] { 9, 7, 6, 3, 8 },
                new int[] { 0, 0, 0 },
                new int[] { 1, 2, 3, 4 }
            };

            //Act
            for (int i = 0; i < numTests; i++)
            {
                var actualAnswer = sol.solution(listOfArrays[i], listOfKs[i]);
                //Assert
                Assert.IsTrue(listOfExpectedAnswers[i].SequenceEqual(actualAnswer));
            }
        }
    }
}
