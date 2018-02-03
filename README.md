# DotNetStandardCalculator

[![Build Status](https://travis-ci.org/Rooster212/DotNetStandardCalculator.svg?branch=master)](https://travis-ci.org/Rooster212/DotNetStandardCalculator)

A little library to parse mathematical calculations as a string implemented in .NET Standard.

## Implementation

This calcultor utilises the [Shunting Yard algorithm](https://en.wikipedia.org/wiki/Shunting-yard_algorithm) to convert a calculation in Infix notation into Reverse-Polish notation. The result of this is then calculated and returned to the caller.

There is an set of tests in `DotNetStandardCalculatorTests`, using [NUnit](http://nunit.org/).

Currently the library supports numbers in the range supported by the [`double` type (±5.0 × 10<sup>−324</sup> <i>to</i> ±1.7 × 10<sup>308</sup>)](https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/double). There is an issue open to expand this support if required (#2).

## Usage
```csharp
// 3
var addResult = StandardCalculator.Calculate("1 + 2");

// 1
var subtractResult = StandardCalculator.Calculate("5 - 4");

// 6
var multiplyResult = StandardCalculator.Calculate("2 * 3");

// 9
var multipleResult = StandardCalculator.Calculate("45 / 5");

// 25
var powerOfResult = StandardCalculator.Calculate("5 ^ 2");

// 20
var parenthesesExample = StandardCalculator.Calculate("5 * (2 + 2)");

// 125
var complexSumResult1 = StandardCalculator.Calculate("5^2 * (6 + 4 - 5)");

// 70
var complexSumResult2 = StandardCalculator.Calculate("(6 * 10) / (5 * 2) + 4^3");
```

## References

[Reverse-polish notation calculator algorithm implementation examples](https://rosettacode.org/wiki/Parsing/RPN_calculator_algorithm)

[Shunting-yard algorithm - Wikipedia](https://en.wikipedia.org/wiki/Shunting-yard_algorithm)
