using DotNetStandardCalculator;
using NUnit.Framework;
using NUnit;

namespace DotNetStandardCalculatorTests
{
    public class UtilitiesTests
    {
        [Test]
        [TestCase("1+2+3", new[] { "1", "+", "2", "+", "3" })]
        [TestCase("101 + 2 + 51", new[] { "101", "+", "2", "+", "51" })]
        [TestCase("10+(6/3+3)", new[] { "10", "+", "(", "6", "/", "3", "+", "3", ")" })]
        [TestCase("(10 + 50) * (60 - 10)", new[] { "(", "10", "+", "50", ")", "*", "(", "60", "-", "10", ")" })]
        [TestCase("9 + (3 * 55) / 6", new[] { "9", "+", "(", "3", "*", "55", ")", "/", "6" })]
        [TestCase("9^3 + (3 * 55) / 6", new[] { "9", "^", "3", "+", "(", "3", "*", "55", ")", "/", "6" })]
        public void SplitTests(string input, string[] expected)
        {
            var splitString = Utilities.Split(input);

            Assert.That(expected, Is.EqualTo(splitString));
        }
    }
}
