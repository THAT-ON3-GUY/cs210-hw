public static class MakeGoals
{
    public static Goal CreateGoal(string line)
    {
        string[] parts = line.Split(",");
        string type = parts[0];

        switch (type)
        {
            case "SimpleGoal":
                SimpleGoal sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4])) sg.RecordEvent();
                return sg;

            case "EternalGoal":
                EternalGoal eg = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                int times = int.Parse(parts[5]);
                for (int i = 0; i < times; i++) eg.RecordEvent();
                return eg;

            case "ChecklistGoal":
                ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                int progress = int.Parse(parts[6]);
                for (int i = 0; i < progress; i++) cg.RecordEvent();
                return cg;

            default:
                throw new Exception($"Unknown goal type: {type}");
        }
    }

    public static void SaveGoals(List<Goal> goals, string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Goal g in goals)
            {
                sw.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public static List<Goal> LoadGoals(string filename)
    {
        List<Goal> goals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            goals.Add(CreateGoal(line));
        }
        return goals;
    }

    public static Goal PromptNewGoal()
    {
        Console.WriteLine("\nWhat type of goal?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Goal name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Point reward: ");
        int reward = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                return new SimpleGoal(name, desc, reward);
            case "2":
                Console.Write("Multiplier (1 for none): ");
                int mult = int.Parse(Console.ReadLine());
                return new EternalGoal(name, desc, reward, mult);
            case "3":
                Console.Write("How many times to complete: ");
                int limit = int.Parse(Console.ReadLine());
                Console.Write("Bonus points on completion: ");
                int bonus = int.Parse(Console.ReadLine());
                return new ChecklistGoal(name, desc, reward, limit, bonus);
            default:
                Console.WriteLine("Invalid choice, creating Simple Goal.");
                return new SimpleGoal(name, desc, reward);
        }
    }
}