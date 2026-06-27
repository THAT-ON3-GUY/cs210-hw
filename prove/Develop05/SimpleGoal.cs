public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int reward)
        : base(name, description, reward) { }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("This goal is already complete!");
            return 0;
        }
        _isComplete = true;
        Console.WriteLine($"Goal complete! You earned {_reward} points!");
        return _reward;
    }

    public override string GetStatus()
    {
        return _isComplete ? $"[X] {_name}" : $"[ ] {_name}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_name},{_description},{_reward},{_isComplete}";
    }
}