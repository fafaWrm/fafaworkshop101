using System;

namespace Kata.FissBuzz.Tests;
public class FizzBuzzTests
{
    private string output = @"1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz"; 
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(100, "Buzz")]
    public void TestFissSingleNumber(int input, string expected)
    {
        // Arrange
        var fissBuzz = new FissBuzz();
        // Act
        var actFissBuzz = fissBuzz.GetFissBuzz(input);
        //// Assert
        actFissBuzz.Should().Be(expected);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(101)]    
    public void TestFissBuzzThrowArgumentException(int input)
    {
        // Arrange
        var fissBuzz = new FissBuzz();
        // Act
        var exception = Assert.Throws<ArgumentException>(() => fissBuzz.PrintFizzBuzz(input));

        exception.Should().Be(
            string.Format(
                "entered number is [{0}], which does not meet rule, entered number should be between 1 to 100.",
                input.ToString()));
    }

    [Fact]
    public void TestFissBuzz()
    {
        // Arrange
        var fissBuzz = new FissBuzz();
        // Act
        var actFissBuzz = fissBuzz.PrintFizzBuzz();
        //// Assert
        actFissBuzz.Should().Be(output);
    }
}

