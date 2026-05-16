using System;
public class PromptGen
{
    Random _randomNum = new Random();

    public List<string> _promptList = new List<string>()
    {
        "What was the best part of today? ",
        "What are 3 things you're grateful for? ",
        "What's a hard thing that happened that you should talk about? ",
        "What's something new or fun you learned today? ",
        "How did you grow today? ",
        "What's did you do today that felt good or fun? ",
        "How was the lord involved in your day today? ",
        "What's something you want to add to your prayer tonight? "
    };
    public string DisplayPrompt()
    {

        int randomPrompt = _randomNum.Next(0,8);
        string chosenPrompt = _promptList[randomPrompt];
        Console.WriteLine($"{chosenPrompt}");
        return chosenPrompt;
    }
}