using NUnit.Framework;
using LeetCodeAlgorithm;
using System.Linq;
using ExpectedObjects;

namespace LeetCodeTest
{
    [TestFixture]
    public class EasyTest
    {
        [Test]
        [TestCase(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 }, 2)]
        [TestCase(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 4, 0, 3 }, 5)]
        [TestCase(new int[] { }, 0, new int[] { }, 0)]
        [TestCase(new int[] { 1 }, 1, new int[] { }, 0)]
        [TestCase(new int[] { 2 }, 3, new int[] { 2 }, 1)]
        public void RemoveElementTest(int[] givenArr, int givenVal, int[] expectedArr, int expectedVal)
        {
            //Arrange
            //var givenArray = new int[] { 3, 2, 2, 3 };
            //var givenArray = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            //var givenVal = 2;
            //var expectedResult = 5;

            //Action
            int outputLengh = Easy.RemoveElement(givenArr, givenVal);

            //Assert
            Assert.AreEqual(outputLengh, expectedVal);
            expectedArr.ToExpectedObject().ShouldEqual(givenArr.Take(outputLengh).ToArray());
        }

        [Test]
        [TestCase(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
        public void RunningSumOf1dArrayTest(int[] givenArr, int[] expectedArr)
        {
            //Action
            int[] outputArr = Easy.RunningSum(givenArr);

            //Assert
            expectedArr.ToExpectedObject().ShouldEqual(outputArr);
        }

        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumTest(int[] nums, int target, int[] expected)
        {
            int[] actual = Easy.TwoSum(nums, target);

            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }

}