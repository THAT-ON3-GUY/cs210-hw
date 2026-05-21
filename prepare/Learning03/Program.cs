using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction standard = new Fraction();
        Console.WriteLine($"{standard.GetFractionString()}");
        Console.WriteLine($"{standard.GetDecimalValue()}");

        Fraction top = new Fraction(5);
        Console.WriteLine($"{top.GetFractionString()}");
        Console.WriteLine($"{top.GetDecimalValue()}");

        Fraction custom = new Fraction(4, 5);
        Console.WriteLine($"{custom.GetFractionString()}");
        Console.WriteLine($"{custom.GetDecimalValue()}");

        Random random = new Random();
        Fraction generated = new Fraction();
        for (int i = 0; i < 20; i++)
        {
            int topNum = random.Next(1, 21);
            int bottomNum = random.Next(1, 21);
            generated.SetTop(topNum);
            generated.SetBottom(bottomNum);
            Console.WriteLine($"Fraction {i + 1}: string: {generated.GetFractionString()} Number: {generated.GetDecimalValue()}");
        }
    }
}