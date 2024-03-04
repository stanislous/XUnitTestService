using XunitService;
using XunitService.Models;

namespace XUnitTestProject;
public class CalculatorTest
{
    private CalculatorService _calc = new();

    [Fact]
    public void Should_Add_Two_Numbers_Return_Number()
    {
        // given
        var a = 4;
        var b = 5;
        var expectedVal = 9;
        // when
        var actualVal = _calc.AddTwoNumbers(a, b);
        // then
        Assert.Equal(expectedVal, actualVal);
    }

    [Fact]
    public void Should_Add_Two_Doubles_Return_Doubles()
    {
        // given
        var a = 4.32;
        var b = 5.22;
        var expectedVal = 9.54;
        // when
        var actualVal = _calc.AddTwoDoubles(a, b);
        // then
        Assert.Equal(expectedVal, actualVal, 1);
    }

    [Fact]
    public void Should_NotContains_Zero()
    {
        //Arrange
        //Act
        var actualNumbers = _calc.GetRandomNumbers();
        //Assert
        Assert.All(actualNumbers, n => Assert.NotEqual(0, n));
        //Both are correct
        //Assert.DoesNotContain(0, actualNumbers);
    }

    [Fact]
    public void ShouldOddNumberReturnTrue()
    {
        //Arrange
        var oddNumber = 3;
        //Act
        var actualValue = _calc.IsOdd(oddNumber);
        //Assert
        Assert.True(actualValue);
    }
    
    [Theory]
    [InlineData(1, true)]
    [InlineData(2, false)]
    [InlineData(123, true)]
    public void ShouldTestForOddOrEvenNumber(int value, bool expected)
    {
        //Arrange
        //Act
        var actualValue = _calc.IsOdd(value);
        //Assert
        Assert.Equal(expected, actualValue);
    }
}