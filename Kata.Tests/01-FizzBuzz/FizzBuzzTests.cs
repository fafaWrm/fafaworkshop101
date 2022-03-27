
using Kata.FissBuzz;
public class FizzBuzzTests
{
    [Fact]
    public void TestFissBuzz()
    {
       
        // Arrange
        var fissBuzz = new FissBuzz();
        // Act
        var actual = fissBuzz.SayHelloWorld();
        // Assert
        actual.Should().Be("Hello World!");
    }
}

