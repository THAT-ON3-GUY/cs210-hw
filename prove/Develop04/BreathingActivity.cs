using System;

class Breathing : BaseActivity
{
    private static string _description =
        "This activity will help you relax by walking you through breathing in and " +
        "out slowly. Clear your mind and focus on your breathing.";

    public Breathing() : base("Breathing", _description)
    {
    }

    public void RunActivity()
    {
        StartActivity();

        while (TimeRemaining())
        {
            RunCountDown("Breathe in...", 4);
            if (!TimeRemaining()) break;
            RunCountDown("Breathe out...", 6);
        }

        EndActivity();
    }
}