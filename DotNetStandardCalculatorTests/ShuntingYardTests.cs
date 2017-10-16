using DotNetStandardCalculator;
using NUnit.Framework;

namespace DotNetStandardCalculatorTests
{
    public class ShuntingYardTests
    {
        [Test]
        [TestCase("1 + 2", new[] { "1", "2", "+" })]
        [TestCase("6 + 5", new[] { "6", "5", "+" })]
        [TestCase("6 + 5 + 4 + 3", new[] { "6", "5", "+", "4", "+", "3", "+"})]
        public void SimpleAdditionShunting(string infix, string[] expected)
        {
            AssertInfixConvertsToExpected(infix, expected);
        }

        [Test]
        [TestCase("1 - 2", new[] { "1", "2", "-" })]
        [TestCase("6 - 5", new[] { "6", "5", "-" })]
        [TestCase("6 - 5 - 4 - 3", new[] { "6", "5", "-", "4", "-", "3", "-" })]
        public void SimpleSubtractionShunting(string infix, string[] expected)
        {
            AssertInfixConvertsToExpected(infix, expected);
        }

        [Test]
        [TestCase("1 * 2", new[] { "1", "2", "*" })]
        [TestCase("2 * 1", new[] { "2", "1", "*" })]
        [TestCase("64 * 3", new[] { "64", "3", "*" })]
        [TestCase("64 * 3 * 12", new[] { "64", "3", "*", "12", "*" })]
        public void SimpleMultiplicationShunting(string infix, string[] expected)
        {
            AssertInfixConvertsToExpected(infix, expected);
        }

        [Test]
        [TestCase("1 / 2", new[] { "1", "2", "/" })]
        [TestCase("2 / 1", new[] { "2", "1", "/" })]
        [TestCase("5 / 3", new[] { "5", "3", "/" })]
        [TestCase("51 / 11 / 2", new[] { "51", "11", "/", "2", "/" })]
        public void SimpleDivideShunting(string infix, string[] expected)
        {
            AssertInfixConvertsToExpected(infix, expected);
        }

        [Test]
        [TestCase("51 + 11 / 2", new[] { "51", "11", "2", "/", "+" })]
        [TestCase("6 * 2 / 6", new[] { "6", "2", "*", "6", "/" })]
        [TestCase("100 - 5 * 3", new[] { "100", "5", "3", "*", "-" })]
        public void SimpleMultipleOperationShunting(string infix, string[] expected)
        {
            AssertInfixConvertsToExpected(infix, expected);
        }

        [Test]
        [TestCase("5 * 6 + 1 * (3 + 2)", new[] { "5", "6", "*", "1", "3", "2", "+", "*", "+" })]
        [TestCase("9 + (3 * 55) / 6", new[] { "9", "3", "55", "*", "6", "/", "+" })]
        public void ParenthesesShunting(string infix, string[] expected)
        {
            AssertInfixConvertsToExpected(infix, expected);
        }

        [Test]
        [TestCase("2 ^ 3", new[] { "2", "3", "^"})]
        [TestCase("6^2 + 5 * (5+4)", new[] { "6", "2", "^", "5", "5", "4", "+", "*", "+" })]
        public void PowerOfOperatorShunting(string infix, string[] expected)
        {
            AssertInfixConvertsToExpected(infix, expected);
        }

        private void AssertInfixConvertsToExpected(string infix, string[] expected)
        {
            var split = Utilities.Split(infix);
            var result = ShuntingYard.GetRPNAsArrayFromString(split);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
