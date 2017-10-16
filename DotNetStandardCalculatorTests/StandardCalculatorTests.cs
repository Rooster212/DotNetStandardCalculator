using NUnit.Framework;

namespace DotNetStandardCalculatorTests
{
    public class StandardCalculatorTests
    {
        [Test]
        [TestCase("1 + 2", 3)]
        [TestCase("3 * 2", 6)]
        [TestCase("6 / 2", 3)]
        [TestCase("6 - 3", 3)]
        public void SimpleCalculator(string infixSum, double expected)
        {
            TestCommon.AssertCalculateEqualsValue(infixSum, expected);
        }

        [Test]
        [TestCase("10 + 3 * 5", 25)]
        [TestCase("10 / 2 + 5", 10)]
        [TestCase("10 / 2 + 5 * 10", 55)]
        public void OperatorPrecedenceWorks(string infixSum, double expected)
        {
            TestCommon.AssertCalculateEqualsValue(infixSum, expected);
        }

        [Test]
        [TestCase("(10 / 2) + 5", 10)]
        [TestCase("(10 + 2) / 2", 6)]
        [TestCase("10 * (60 + 3)", 630)]
        [TestCase("10 * (60 - 3)", 570)]
        [TestCase("(10 + 50) * (60 - 10)", 3000)]
        public void ParentheseWorkAsExpected(string infixSum, double expected)
        {
            TestCommon.AssertCalculateEqualsValue(infixSum, expected);
        }

        [Test]
        [TestCase("4^3 * (60 - 3)", 3648)]
        [TestCase("4^2 * (6^2 - 3)", 528)]
        [TestCase("2^2 + 3", 7)]
        public void PowerOfOperatorWorks(string infixSum, double expected)
        {
            TestCommon.AssertCalculateEqualsValue(infixSum, expected);
        }
    }
}
