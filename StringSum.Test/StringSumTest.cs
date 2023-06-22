using NUnit.Framework;

namespace StringSum.Test
{
    public class Tests
    {
        [Test]
        [TestCase("123", "456", ExpectedResult = "579")]
        [TestCase("9","5", ExpectedResult = "14")]
        public string ShouldReturnSum(string n1, string n2)
        {
            string result = StringSum.Sum(n1, n2);
            return result;
        }

        [Test]
        public void TestThrowArgumentNullException()
        {
            string stringValueOne = "34d";
            string stringValueTwo = "12f";

            Assert.That(() => StringSum.Sum(stringValueOne, stringValueTwo), Throws.ArgumentException);
        }
    }
}