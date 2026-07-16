public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string name, string description, DateTime date, DateTime time, Address location, string rsvpEmail)
        : base(name, description, date, time, location)
    {
        _rsvpEmail = rsvpEmail;
        _eventType = "Reception";
    }

    public override void PrintFullDetails()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        base.PrintFullDetails();
        Console.WriteLine($"RSVP Email: {_rsvpEmail}");
    }

    public override void PrintShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        base.PrintShortDescription();
    }
}