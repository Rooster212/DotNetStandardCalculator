# DotNetStandardCalculator
A little library to parse mathmatical calculations as a string implemented in .NET Standard.

## Implementation

This calcultor utilises the [Shunting Yard algorithm](https://en.wikipedia.org/wiki/Shunting-yard_algorithm) to convert a calculation in Infix notation into Reverse-Polish notation. The result of this is then calculated and returned to the caller.

There is an set of tests in `DotNetStandardCalculatorTests` which should be expanded significantly before this is used in any production setting.

## Usage
```csharp
// result == 3
var result = StandardCalculator.Calculate("1 + 2");
```

## References

[Reverse-polish notation calculator algorithm implementation examples](https://rosettacode.org/wiki/Parsing/RPN_calculator_algorithm)

[Shunting-yard algorithm - Wikipedia](https://en.wikipedia.org/wiki/Shunting-yard_algorithm)

## Libraries

[XUnit](https://github.com/xunit/xunit)
