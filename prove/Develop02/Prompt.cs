using System;
public class PromptGen
{
    Random _randomNum = new Random();

    public List<string> _promptList = new List<string>();

    public void DisplayPrompt()
    {
        int _randomPrompt = _randomNum.Next(1,6);
        Console.WriteLine($"{_promptList[_randomPrompt]}");
    }
}