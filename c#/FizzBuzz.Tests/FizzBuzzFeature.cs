using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzFeature
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void GivenAValueDivisibleByThree_ShouldReturnFizz(int testValue)
        {
            var result = FizzBuzz.GetTheFizz(testValue);

            Assert.AreEqual("Fizz", result);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(35)]
        public void GivenAValueDivisibleByFive_ShouldReturnBuzz(int testValue)
        {
            var result = FizzBuzz.GetTheFizz(testValue);

            Assert.AreEqual("Buzz", result);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void GivenAValueDivisibleByFiveAndThree_ShouldReturnFizzBuzz(int testValue)
        {
            var result = FizzBuzz.GetTheFizz(testValue);

            Assert.AreEqual("FizzBuzz", result);
        }

        [TestCase(2)]
        [TestCase(8)]
        [TestCase(13)]
        [TestCase(16)]
        public void GivenAValueNotDivisibleByFiveOrThree_ShouldReturnTheValue(int testValue)
        {
            var result = FizzBuzz.GetTheFizz(testValue);

            Assert.AreEqual(testValue.ToString(), result);
        }
    }
}
