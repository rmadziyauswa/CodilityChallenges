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

            var array1 = new int[] { 3, 8, 9, 7, 6 };
            var k1 = 3;
            var expectedAns1 = new int[] { 9, 7, 6, 3, 8 };

            var array2 = new int[] { 0, 0, 0 };
            var k2 = 1;
            var expectedAns2 = new int[] { 0, 0, 0 };

            var array3 = new int[] { 1, 2, 3, 4 };
            var k3 = 4;
            var expectedAns3 = new int[] { 1, 2, 3, 4 };

            //Act
            var actualAnswer1 = sol.solution(array1, k1);
            var actualAnswer2 = sol.solution(array2, k2);
            var actualAnswer3 = sol.solution(array3, k3);

            //Assert
            Assert.IsTrue(expectedAns1.SequenceEqual(actualAnswer1));
            Assert.IsTrue(expectedAns2.SequenceEqual(actualAnswer2));
            Assert.IsTrue(expectedAns3.SequenceEqual(actualAnswer3));

        }
    }
}
