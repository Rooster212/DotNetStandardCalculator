using DotNetStandardCalculator;
using Xunit;

namespace DotNetStandardCalculatorTests
{
    public class UtilitiesTests
    {
        [Theory]
        [InlineData("1+2+3", new[] { "1", "+", "2", "+", "3" })]
        [InlineData("101 + 2 + 51", new[] { "101", "+", "2", "+", "51" })]
        public void SplitTests(string input, string[] expected)
        {
            var splitString = Utilities.Split(input);

            Assert.Equal(expected, splitString);
        }
    }
}
