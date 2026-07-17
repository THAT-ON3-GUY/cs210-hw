public class Swimming : Activity
{
    private int _laps; // number of laps swum

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 0.05; // Assuming each lap is 0.05 miles
    }

    public override void DisplaySummary()
    {
        Console.WriteLine("Swimming Summary:");
        base.DisplaySummary();
    }
}