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

        [Test]
        public void TestDistance()
        {
            var d = new Distance();
            var expectedAns = 3.771236;
            var actualAns = d.averagePlaneDistance(1, 2, 3, 4, 5, 6);
            Assert.AreEqual(expectedAns, actualAns);
        }

        [Test]
        public void TestMostPop()
        {
            var m = new MostPop();
            var arr = new int[] { 2,3,4,3,2,1};
            var inty = 3;
            var expectedAns = 2;
            var actualAns = m.mostPopularNumber(arr,inty);
            Assert.AreEqual(expectedAns, actualAns);
        }


        [Test]
        public void TestTask1()
        {
            var m = new Task1();
            var A = new string[] {"pim","pom" };
            var B = new string[] { "999999999","777888999"};
            var P = "88999";
            var expectedAns = "pom";
            var actualAns = m.solution( A,  B,  P);
            Assert.AreEqual(expectedAns, actualAns);
        }

        [Test]
        public void TestTask2()
        {
            var m = new Task2();
            var S = "00-44 48 5555 8361";
            var expectedAns = "004-448-555-583-61";
            var actualAns = m.solution(S);
            Assert.AreEqual(expectedAns, actualAns);
        }

        [Test]
        public void TestTask3()
        {
            //var m = new Task3();
            //var S = "00-44 48 5555 8361";
            //var expectedAns = "004-448-555-583-61";
            //var actualAns = m.solution(S);
            //Assert.AreEqual(expectedAns, actualAns);
        }

        [Test]
        public void TestTask4()
        {
            var m = new Task4();
            int N = 3;
            int[] A =  new int[] { 1,3};
            int[] B =  new int[] {2,2};
            var expectedAns = true;
            var actualAns = m.solution(N,  A,  B);
            Assert.AreEqual(expectedAns, actualAns);
        }


        [Test]
        public void TestRTask3()
        {
            var m = new Rtask3();
            int S = 2;
            int[] A = new int[] { 2,1, 3 };
            var expectedAns = 3;
            var actualAns = m.solution( A, S);
            Assert.AreEqual(expectedAns, actualAns);
        }

        [Test]
        public void TestRTask1()
        {
            var m = new RTask1();
            string[] T = new string[] { "test1a", "test2", "test1b", "test1c", "test3" };
            string[] R = new string[] { "Wrong answer", "OK", "Runtime error", "OK", "Time limit exceeded" };
            var expectedAns = 33;
            var actualAns = m.solution(T,R);
            Assert.AreEqual(expectedAns, actualAns);
        }


    }
}
