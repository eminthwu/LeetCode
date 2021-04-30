using NUnit.Framework;
using LeetCodeAlgorithm;

namespace LeetCodeTest
{
    [TestFixture]
    public class EasyTest
    {
        [Test]
        //[TestCase(new int[] { 3, 2, 2, 3 },3, 2)]
        public void RemoveElementTest()
        {
            //Arrange
            //var givenArray = new int[] { 3, 2, 2, 3 };
            var givenArray = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var givenVal = 2;
            var expectedResult = 5;

            //Action
            int outputLengh = RemoveElement.RemoveElement(givenArray, givenVal);

            //Assert
            Assert.AreEqual(outputLengh, expectedResult);
        }
    }

}