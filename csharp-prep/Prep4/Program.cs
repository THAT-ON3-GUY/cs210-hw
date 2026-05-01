using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        string input = "";
        int inputNum = 1;
        int sum = 0;
        double average = 0;
        int largest = 0;

        Console.WriteLine("Give me a series of numbers, type 0 when finished.");
        do
        {
            input = Console.ReadLine();
            inputNum = int.Parse(input);
            numbers.Add(inputNum);
        } while (inputNum != 0);

        foreach (int digit in numbers)
        {
            sum = sum + digit;
        }
        Console.WriteLine($"The sum is: {sum}");

        average = sum / (double)(numbers.Count-1);
        Console.WriteLine($"The average is: {average}");

        foreach (int digit in numbers)
        {
            if (digit > largest)
            {
                largest = digit;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}