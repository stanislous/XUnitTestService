using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace TestProject.Tests.Unit;

class CalculatorServiceTest
{
    private CalculatorService calc;
    public CalculatorServiceTest()
    {
        calc = new CalculatorService();
    }

    [Fact]
    public void Should_Add_Two_Numbers_Return_Number()
    {
        // given
        var a = 4;
        var b = 5;
        var expectedVal = 9;
        // when
        var actualVal = calc.AddTwoNumbers(a, b);
        // then
        Assert.Equals(expectedVal, actualVal);
    }
    
    [Fact]
    public void Should_Add_Two_Doubles_Return_Doubles()
    {
        // given
        var a = 4.3;
        var b = 5.2;
        var expectedVal = 9.5;
        // when
        var actualVal = calc.AddTwoDboubles(a, b);
        // then
        Assert.Equals(expectedVal, actualVal);
    }
}

