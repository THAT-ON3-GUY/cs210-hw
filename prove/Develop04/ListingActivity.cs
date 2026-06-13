using System;
using System.Collections.Generic;

class Listing : BaseActivity
{
    private static string _description =
        "This activity will help you reflect on the good things in your life by having " +
        "you list as many things as you can in a certain area.";

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base("Listing", _description)
    {
    }

    public void RunActivity()
    {
        StartActivity();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("Start thinking...");
        RunCountDown("", 5);

        int count = 0;
        Console.WriteLine("\nStart listing! Press Enter after each item.\n");

        while (TimeRemaining())
        {
            Console.Write($"  Item {count + 1}: ");
            string input = Console.ReadLine();
            if (input != null)
                count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        ShowSpinner(2);
        EndActivity();
    }
}