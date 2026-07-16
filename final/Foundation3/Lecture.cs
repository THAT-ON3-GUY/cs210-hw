public class Lecture : Event
{
    public string _speaker { get; set; }
    public int _capacity { get; set; }

    public Lecture(string name, string description, DateTime date, DateTime time, Address location, string speaker, int capacity)
        : base(name, description, date, time, location)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void PrintFullDetails()
    {
        base.PrintFullDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }

    public override void PrintShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        base.PrintShortDescription();
    }
}