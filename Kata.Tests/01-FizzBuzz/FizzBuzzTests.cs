namespace Kata.FissBuzz.Tests;
public class FizzBuzzTests
{

    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]    
    [InlineData(5, "Buzz")]   
    [InlineData(15, "FizzBuzz")]
    [InlineData(100, "Buzz")]


    public void TestFissBuzz(int input ,string expected)
    {
        
        // Arrange
        var fissBuzz = new FissBuzz();
        // Act
        var actFissBuzz = fissBuzz.GetFissBuzz(input);
        // Assert
        actFissBuzz.Should().Be(expected);
    }
}

