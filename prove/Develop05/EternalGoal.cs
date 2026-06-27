public class EternalGoal : Goal
{
    private int _multiplier;
    private int _timesRecorded;

    public EternalGoal(string name, string description, int reward, int multiplier = 1)
        : base(name, description, reward)
    {
        _multiplier = multiplier;
        _timesRecorded = 0;
    }

    public override int RecordEvent()
    {
        _timesRecorded++;
        int earned = _reward * _multiplier;
        Console.WriteLine($"Recorded! You earned {earned} points. (Recorded {_timesRecorded} times)");
        return earned;
    }

    public override string GetStatus()
    {
        return $"[ ] {_name} (recorded {_timesRecorded} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_name},{_description},{_reward},{_multiplier},{_timesRecorded}";
    }
}