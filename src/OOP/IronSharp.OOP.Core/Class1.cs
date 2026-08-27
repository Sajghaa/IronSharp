namespace IronSharp.OOP.Core;

public static class Calculator
{

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int SumAll(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        return total;
    }

    public static string FormatResult(int value, string prefix = "Result: ")
    {
        return $"{prefix}{value}";
    }

    public static bool TryDivide(int dividend, int divisor, out int result)
    {
        if (divisor == 0)
        {
            result = 0;
            return false;
        }
        result = dividend / divisor;
        return true;
    }
}