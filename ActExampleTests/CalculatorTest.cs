using ActExample;
using FluentAssertions;

namespace ActExampleTests;

public class CalculatorTest
{
    [Fact]
    public void Add()
    {
        // Arrange
        const int a = 1;
        const int b = 2;

        var calculator = new Calculator();

        // Act
        var result = calculator.Add(a, b);

        // Assert
        result.Should().Be(3);
    }
}