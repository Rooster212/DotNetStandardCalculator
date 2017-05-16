using DotNetStandardCalculator;
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
            var result = StandardCalculator.CalculateFromString(infixSum);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("10 + 3 * 5", 25)]
        [InlineData("10 / 2 + 5", 10)]
        [InlineData("10 / 2 + 5 * 10", 55)]
        public void OperatorPrecedenceWorks(string infixSum, double expected)
        {
            var result = StandardCalculator.CalculateFromString(infixSum);
            Assert.Equal(expected, result);
        }
    }
}
