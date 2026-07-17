using System;

class Program
{
    static void Main(string[] args)
    {
        Activity swimming = new Swimming(DateTime.Now, 30, 20); // 20 laps in 30 minutes
        Activity running = new Running(DateTime.Now, 45, 5); // 5 miles in 45 minutes
        Activity cycling = new Cycling(DateTime.Now, 60, 15); // 15 mph in 60 minutes

        List<Activity> activities = new List<Activity>
        {
            swimming,
            running,
            cycling
        };

        foreach (Activity activity in activities)
        {
            activity.DisplaySummary();
            Console.WriteLine(); // Add a blank line between summaries
        }
    }
}