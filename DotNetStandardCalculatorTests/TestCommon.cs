using DotNetStandardCalculator;
using NUnit.Framework;

namespace DotNetStandardCalculatorTests
{
    internal static class TestCommon
    {
        internal static double AssertCalculateEqualsValue(string infixSum, double expected)
        {
            var result = StandardCalculator.CalculateFromString(infixSum);
            Assert.That(expected, Is.EqualTo(result));
            return result;
        }
    }
}
