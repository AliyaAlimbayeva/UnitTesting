using NUnit.Framework;
using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Test
{
    [TestFixture()]
    public class FizzBuzzTest
    {
        [Test()]
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(9, ExpectedResult = "Fizz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        [TestCase(25, ExpectedResult = "Buzz")]
        public string ReturnsCorrectWordForSingleNumber(int num)
        {
            return FizzBuzz.IsFizzBuzz(num);
        }
        [Test()]
        [TestCase(1, 150)]
        [TestCase(-5, 100)]
        [TestCase(-1, 5)]
        public void InvalidRangeThrowsException(int start, int end)
        {
            Assert.That(() => FizzBuzz.PrintNumbers(start, end), Throws.ArgumentException);
        }
    }
}