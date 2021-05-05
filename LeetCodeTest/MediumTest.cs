using NUnit.Framework;
using System.Linq;
using ExpectedObjects;
using LeetCodeAlgorithm.Medium;

namespace LeetCodeTest
{
    [TestFixture]
    public class MediumTest
    {
        [Test]
        [TestCase(new int[] { 4, 2, 3 }, true)]
        [TestCase(new int[] { 4, 2, 1 }, false)]
        [TestCase(new int[] { 3, 4, 2, 3 }, false)]
        [TestCase(new int[] { 5, 7, 1, 8 }, true)]
        [TestCase(new int[] { -1, 4, 2, 3 }, true)]
        [TestCase(new int[] { 1, 4, 1, 2 }, true)]
        public void Non_decreasingArrayTest(int[] givenArr, bool expectedResult)
        {
            //Action
            var actualResult = Non_decreasingArray.CheckPossibility(givenArr);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

}