using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest;

public class CalculatorService
{
    [Fact]
    public void Should_Be_Always_True()
    {
        Assert.NotEqual(4, 2);
    }
}

