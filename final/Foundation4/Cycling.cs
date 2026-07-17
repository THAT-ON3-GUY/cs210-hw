public class Cycling : Activity
{
    private double _speed; // in miles per hour

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double hours = base.GetDuration() / 60.0;
        return _speed * hours;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine("Cycling Summary:");
        base.DisplaySummary();
    }
}