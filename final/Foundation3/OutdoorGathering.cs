public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, DateTime time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
        _eventType = "Outdoor Gathering";
    }

    public override void PrintFullDetails()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        base.PrintFullDetails();
        Console.WriteLine($"Weather: {_weather}");
    }

    public override void PrintShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        base.PrintShortDescription();
    }
}