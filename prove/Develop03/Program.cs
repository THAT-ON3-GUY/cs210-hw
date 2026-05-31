using System;
using System.Runtime.CompilerServices;

class Program
{
    private bool _continue = true;
    static void Main(string[] args)
    {
        string choice;
        Console.Clear();
        Scripture testScripture = new Scripture("1 Nephi", 1, 2, "Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians.");
        testScripture.ShowScripture();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        choice = Console.ReadLine();

        while(choice.ToLower() != "quit")
        {
            bool wordsRemain = testScripture.needHidden();
            Console.Clear();
            testScripture.ShowScripture();

            if (!wordsRemain)
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            choice = Console.ReadLine();
        }
    }
}