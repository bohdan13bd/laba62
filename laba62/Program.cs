using System;

class MathOperations
{
    public static T Add<T>(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x + y;
    }

    public static T Subtract<T>(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x - y;
    }

    public static T Multiply<T>(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x * y;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Додавання чисел
        int sumInt = MathOperations.Add(5, 10);
        double sumDouble = MathOperations.Add(3.5, 2.5);
        Console.WriteLine($"Sum of integers: {sumInt}");
        Console.WriteLine($"Sum of doubles: {sumDouble}");

        // Віднімання чисел
        int diffInt = MathOperations.Subtract(10, 5);
        double diffDouble = MathOperations.Subtract(3.5, 2.5);
        Console.WriteLine($"Difference of integers: {diffInt}");
        Console.WriteLine($"Difference of doubles: {diffDouble}");

        // Множення чисел
        int productInt = MathOperations.Multiply(5, 10);
        double productDouble = MathOperations.Multiply(3.5, 2.5);
        Console.WriteLine($"Product of integers: {productInt}");
        Console.WriteLine($"Product of doubles: {productDouble}");
    }
}
