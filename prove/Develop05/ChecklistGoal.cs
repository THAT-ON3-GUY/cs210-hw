public class ChecklistGoal : Goal
{
    private int _timesComplete;
    private int _limit;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int reward, int limit, int bonusPoints)
        : base(name, description, reward)
    {
        _timesComplete = 0;
        _limit = limit;
        _bonusPoints = bonusPoints;
    }

    public int GetProgress() { return _timesComplete; }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("This goal is already complete!");
            return 0;
        }
        _timesComplete++;
        int earned = _reward;
        if (_timesComplete >= _limit)
        {
            _isComplete = true;
            earned += _bonusPoints;
            Console.WriteLine($"Checklist complete! You earned {_reward} + {_bonusPoints} bonus points!");
        }
        else
        {
            Console.WriteLine($"Progress! You earned {_reward} points. ({_timesComplete}/{_limit})");
        }
        return earned;
    }

    public override string GetStatus()
    {
        string check = _isComplete ? "X" : " ";
        return $"[{check}] {_name} -- Completed {_timesComplete}/{_limit} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_name},{_description},{_reward},{_limit},{_bonusPoints},{_timesComplete}";
    }
}