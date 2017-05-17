using DotNetStandardCalculator;
using Xunit;

namespace DotNetStandardCalculatorTests
{
    public class UtilitiesTests
    {
        [Theory]
        [InlineData("1+2+3", new[] { "1", "+", "2", "+", "3" })]
        [InlineData("101 + 2 + 51", new[] { "101", "+", "2", "+", "51" })]
        [InlineData("10+(6/3+3)", new[] { "10", "+", "(", "6", "/", "3", "+", "3", ")" })]
        [InlineData("(10 + 50) * (60 - 10)", new[] { "(", "10", "+", "50", ")", "*", "(", "60", "-", "10", ")" })]
        [InlineData("9 + (3 * 55) / 6", new[] { "9", "+", "(", "3", "*", "55", ")", "/", "6" })]
        public void SplitTests(string input, string[] expected)
        {
            var splitString = Utilities.Split(input);

            Assert.Equal(expected, splitString);
        }
    }
}
