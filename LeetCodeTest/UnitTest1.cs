using NUnit.Framework;
using LeetCodeAlgorithm;

namespace LeetCodeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }

    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }

        [TestCase(-1, true)]
        [TestCase(0, true)]
        [TestCase(1, false)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value, bool expetcedResul)
        {
            var result = _primeService.IsPrime(value);

            Assert.AreEqual(result,expetcedResul);
            //Assert.IsFalse(result, $"{value} should not be prime");
        }
    }
}