public class Event
{
    public string _name { get; set; }
    public string _description { get; set; }
    public DateTime _date { get; set; }
    public DateTime _time { get; set; }
    public Address _location { get; set; }

    public string _eventType { get; set; } = "General Event";

    public Event(string name, string description, DateTime date, DateTime time, Address location)
    {
        _name = name;
        _description = description;
        _date = date;
        _time = time;
        _location = location;
    }

   public void PrintStandardDetails()
    {
        Console.WriteLine($"Event Name: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
        Console.WriteLine($"Time: {_time.ToShortTimeString()}");
        Console.WriteLine($"Location: {_location.GetFullAddress()}");
    }

    virtual public void PrintFullDetails()
    {
        Console.WriteLine($"Event Name: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
        Console.WriteLine($"Time: {_time.ToShortTimeString()}");
        Console.WriteLine($"Location: {_location.GetFullAddress()}");
        // Additional details can be added here
    }

    virtual public void PrintShortDescription()
    {
        Console.WriteLine($"Event Name: {_name}");
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
    }
}