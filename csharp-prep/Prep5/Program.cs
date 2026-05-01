using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string num = Console.ReadLine();
        int favoriteNum = int.Parse(num);
        return favoriteNum;
    }

    static int PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        string year = Console.ReadLine();
        birthYear = int.Parse(year);
        return birthYear;
    }

    static int SquareNumber(int favoriteNum)
    {   int squared = favoriteNum * favoriteNum;
        return squared;
    }

    static void DisplayResult(string name, int squared, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
        Console.WriteLine($"{name}, you will turn {2026-birthYear} this year.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNum = PromptUserNumber();
        int birthYear;
        birthYear = PromptUserBirthYear(out birthYear);
        int squared = SquareNumber(favoriteNum);
        DisplayResult(name, squared, birthYear);
    }
}