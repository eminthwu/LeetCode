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
    }

}