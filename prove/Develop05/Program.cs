using System.IO;
//For my extra feature I've added a shop system. This system saves shop items in reference to the user.
//The system is built this way so a user can create unique rewards to work towards based on their needs the same way,
//that goals can be customized to meet their needs. This shop system allows items to be set with both point and level costs.
//These cost also work with a minimum level system that make it so you can't get bigger rewards until higher levels.
//But at the same time those bigger rewards might set you back a few levels.
class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static User _user;

    static void Main(string[] args)
    {
        Console.Write("Enter your username: ");
        string name = Console.ReadLine();

        if (File.Exists($"{name}_user.txt"))
        {
            _user = User.LoadUserData($"{name}_user.txt");
            Console.WriteLine($"Welcome back, {name}!");
        }
        else
        {
            _user = new User(name);
            Console.WriteLine($"New profile created for {name}!");
        }

        if (File.Exists($"{name}_goals.txt"))
        {
            _goals = MakeGoals.LoadGoals($"{name}_goals.txt");
            Console.WriteLine("Goals loaded.");
        }

        bool running = true;
        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": DisplayGoals(); break;
                case "2": _goals.Add(MakeGoals.PromptNewGoal()); break;
                case "3": RecordEvent(); break;
                case "4": DisplayScore(); break;
                case "5": _user.DisplayShopList(); ShopMenu(); break;
                case "6": _user.CreateShopItem(); break;
                case "7": Save(name); break;
                case "8": running = false; Save(name); break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine($"\n=== Eternal Quest === | {_user.GetUsername()} | Level {_user.GetLevel()} | {_user.GetPoints()} pts | XP: {_user.GetXP()}/100");
        Console.WriteLine("1. View goals");
        Console.WriteLine("2. Add new goal");
        Console.WriteLine("3. Record an event");
        Console.WriteLine("4. View score");
        Console.WriteLine("5. Visit shop");
        Console.WriteLine("6. Add custom reward to shop");
        Console.WriteLine("7. Save");
        Console.WriteLine("8. Quit");
        Console.Write("Choice: ");
    }

    static void DisplayGoals()
    {
        Console.WriteLine("\n--- Your Goals ---");
        if (_goals.Count == 0) { Console.WriteLine("No goals yet."); return; }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    static void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Which goal did you complete? (number): ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index < 0 || index >= _goals.Count) { Console.WriteLine("Invalid."); return; }

        int pts = _goals[index].RecordEvent();
        _user.AddPoints(pts);
        _user.AddXP(pts / 10);
    }

    static void DisplayScore()
    {
        Console.WriteLine($"\nScore: {_user.GetPoints()} points | Level: {_user.GetLevel()} | XP: {_user.GetXP()}/100");
    }

    static void ShopMenu()
    {
        Console.Write("Enter item number (or 0 to cancel): ");
        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice == -1) return;

        Console.WriteLine("1. Buy");
        Console.WriteLine("2. Use");
        Console.Write("Choice: ");
        string action = Console.ReadLine();

        switch (action)
        {
            case "1": _user.BuyItemAtIndex(choice); break;
            case "2": _user.UseItemAtIndex(choice); break;
            default: Console.WriteLine("Invalid choice."); break;
        }
    }

    static void Save(string name)
    {
        MakeGoals.SaveGoals(_goals, $"{name}_goals.txt");
        _user.SaveUserData($"{name}_user.txt");
        Console.WriteLine("Saved!");
    }
}