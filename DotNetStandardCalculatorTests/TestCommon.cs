using DotNetStandardCalculator;
using Xunit;

namespace DotNetStandardCalculatorTests
{
    internal static class TestCommon
    {
        internal static double AssertCalculateEqualsValue(string infixSum, double expected)
        {
            var result = StandardCalculator.CalculateFromString(infixSum);
            Assert.Equal(expected, result);
            return result;
        }
    }
}
