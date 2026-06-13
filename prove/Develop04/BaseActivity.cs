using System;
using System.Threading;

public class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    protected bool TimeRemaining()
    {
        return DateTime.Now < _endTime;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"=== {_name} Activity ===\n");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How many seconds for this activity: ");
        _duration = int.Parse(Console.ReadLine());
        _endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("\nGet ready to begin...");
        ShowSpinner(3);
        Console.Clear();
    }

    public void EndActivity()
    {
        Console.Clear();
        Console.WriteLine("\nWell done!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "—", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
            i++;
        }
        Console.Write(" \b");
    }

    public void RunCountDown(string message, int seconds)
    {
        Console.Write($"{message} ");
        int remaining = seconds;
        while (remaining >= 0)
        {
            Console.Write($"{remaining,2}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
            remaining--;
        }
        Console.WriteLine();
    }
}