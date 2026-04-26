using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is Your Grade Percentage? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter = "";
        int secondDigit = grade % 10;

        if (grade >= 90)
        {
           letter = "A";
        }
        else if (grade >= 80)
        {
            
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        if (secondDigit >= 7 && !(grade > 90 || grade < 60))
        {
            letter = letter + "+";
        }
        else if(secondDigit < 3 && !(grade < 60))
        {
            letter = letter + "-";
        }

        Console.WriteLine($"You got an {letter}!");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You've passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately you didn't pass the class, don't give up! You can do this!");
        }
    }
}