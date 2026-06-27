public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected bool _isComplete;
    protected int _reward;

    public Goal(string name, string description, int reward)
    {
        _name = name;
        _description = description;
        _reward = reward;
        _isComplete = false;
    }

    public string GetName() { return _name; }
    public string GetDescription() { return _description; }
    public bool IsComplete() { return _isComplete; }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string GetStringRepresentation();
}