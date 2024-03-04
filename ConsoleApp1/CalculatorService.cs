namespace XunitService;

public class CalculatorService
{
    public int AddTwoNumbers(int a, int b)
    {
        return a + b;
    }

    public double AddTwoDoubles(double a, double b)
    {
        return a + b;
    }

    public List<int> GetRandomNumbers()
    {
        var list = new List<int> { 10, 22, 63, 94, 25, 46, 79, 80, 91 };
        return list;
    }
    public bool IsOdd(int number)
    {
        if (number % 2 != 0)
            return true;
        return false;
    }
}