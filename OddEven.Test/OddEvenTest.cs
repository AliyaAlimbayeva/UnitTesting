using NUnit.Framework;

namespace OddEven.Test
{
    public class Tests
    {
        [Test]
        [TestCase(1, ExpectedResult = "Odd")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(5, ExpectedResult = "5")]
        [TestCase(6, ExpectedResult = "Even")]
        [TestCase(9, ExpectedResult = "Odd")]
        [TestCase(17, ExpectedResult = "17")]
        public string PrintsOddEvenForSingleNumber(int number)
        {
            return OddEven.GetDefOddEven(number);
        }

        [Test]
        [TestCase(1, 150)]
        [TestCase(-10, 10)]
        public void InvalidRangeThrowsException(int start, int end)
        {
            Assert.That(() => OddEven.PrintNumbers(start, end), Throws.ArgumentException);
        }

        [Test]
        [TestCase(1, 2," Odd 2")]
        [TestCase(1, 5, " Odd 2 3 Even 5")]
        public void PrintsOddEvenForRange(int start, int end, string exceptedResult)
        {
            string result = OddEven.PrintNumbers(start, end);
            Assert.That(result.Equals(exceptedResult));
        }
    }
}