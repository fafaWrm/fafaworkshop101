namespace Kata.FissBuzz.Tests;
public class FizzBuzzTests
{

    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(3, "Fizz")]    
    [InlineData(5, "Buzz")]   
    [InlineData(15, "FizzBuzz")]


    public void TestFissBuzz(int input ,string expected)
    {
       
        // Arrange
        var fissBuzz = new FissBuzz();
        // Act
        var actual = fissBuzz.GetFissBuzz(input);
        // Assert
        actual.Should().Be(expected);
    }
}

