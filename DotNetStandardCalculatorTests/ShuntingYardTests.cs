using DotNetStandardCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DotNetStandardCalculatorTests
{
    public class ShuntingYardTests
    {
        [Theory]
        [InlineData("1 + 2", new[] { "1", "2", "+" })]
        [InlineData("6 + 5", new[] { "6", "5", "+" })]
        [InlineData("6 + 5 + 4 + 3", new[] { "6", "5", "+", "4", "+", "3", "+"})]
        public void SimpleAdditionShunting(string infix, string[] expected)
        {
            var result = ShuntingYard.GetRPNAsArrayFromString(infix);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1 - 2", new[] { "1", "2", "-" })]
        [InlineData("6 - 5", new[] { "6", "5", "-" })]
        [InlineData("6 - 5 - 4 - 3", new[] { "6", "5", "-", "4", "-", "3", "-" })]
        public void SimpleSubtractionShunting(string infix, string[] expected)
        {
            var result = ShuntingYard.GetRPNAsArrayFromString(infix);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1 * 2", new[] { "1", "2", "*" })]
        [InlineData("2 * 1", new[] { "2", "1", "*" })]
        [InlineData("64 * 3", new[] { "64", "3", "*" })]
        [InlineData("64 * 3 * 12", new[] { "64", "3", "*", "12", "*" })]
        public void SimpleMultiplicationShunting(string infix, string[] expected)
        {
            var result = ShuntingYard.GetRPNAsArrayFromString(infix);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1 / 2", new[] { "1", "2", "/" })]
        [InlineData("2 / 1", new[] { "2", "1", "/" })]
        [InlineData("5 / 3", new[] { "5", "3", "/" })]
        [InlineData("51 / 11 / 2", new[] { "51", "11", "/", "2", "/" })]
        public void SimpleDivideShunting(string infix, string[] expected)
        {
            var result = ShuntingYard.GetRPNAsArrayFromString(infix);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("51 + 11 / 2", new[] { "51", "11", "2", "/", "+" })]
        [InlineData("6 * 2 / 6", new[] { "6", "2", "*", "6", "/" })]
        [InlineData("100 - 5 * 3", new[] { "100", "5", "3", "*", "-" })]
        public void SimpleMultipleOperationShunting(string infix, string[] expected)
        {
            var result = ShuntingYard.GetRPNAsArrayFromString(infix);
            Assert.Equal(expected, result);
        }
    }
}
