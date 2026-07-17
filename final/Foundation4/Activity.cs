public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();

    public DateTime GetDate()
    {
        return _date;
    }
    public int GetDuration()
    {
        return _minutes;
    }
    public double GetSpeed()
    {
        double hours = _minutes / 60.0;
        return GetDistance() / hours;
    }

    public double GetPace()
    {
        return _minutes / GetDistance();
    }

    public virtual void DisplaySummary()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
        Console.WriteLine($"Duration: {_minutes} minutes");
        Console.WriteLine($"Distance: {GetDistance():F2} miles");
        Console.WriteLine($"Speed: {GetSpeed():F2} mph");
        Console.WriteLine($"Pace: {GetPace():F2} min/mile");
    }
    public virtual void DisplaySummary(string activityType)
    {
        Console.WriteLine($"Activity Type: {activityType}");
        DisplaySummary();
    }
}