using ConsoleApp1;

namespace TestProject;
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
}