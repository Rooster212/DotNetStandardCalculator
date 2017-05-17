using Xunit;

namespace DotNetStandardCalculatorTests
{
    public class StandardCalculatorTests
    {
        [Theory]
        [InlineData("1 + 2", 3)]
        [InlineData("3 * 2", 6)]
        [InlineData("6 / 2", 3)]
        [InlineData("6 - 3", 3)]
        public void SimpleCalculator(string infixSum, double expected)
        {
            TestCommon.AssertCalculateEqualsValue(infixSum, expected);
        }

        [Theory]
        [InlineData("10 + 3 * 5", 25)]
        [InlineData("10 / 2 + 5", 10)]
        [InlineData("10 / 2 + 5 * 10", 55)]
        public void OperatorPrecedenceWorks(string infixSum, double expected)
        {
            TestCommon.AssertCalculateEqualsValue(infixSum, expected);
        }

        [Theory]
        [InlineData("(10 / 2) + 5", 10)]
        [InlineData("(10 + 2) / 2", 6)]
        [InlineData("10 * (60 + 3)", 630)]
        [InlineData("10 * (60 - 3)", 570)]
        [InlineData("(10 + 50) * (60 - 10)", 3000)]
        public void ParentheseWorkAsExpected(string infixSum, double expected)
        {
            TestCommon.AssertCalculateEqualsValue(infixSum, expected);
        }
    }
}
