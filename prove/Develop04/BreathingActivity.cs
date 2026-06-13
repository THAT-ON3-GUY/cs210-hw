class Breathing : BaseActivity
{
    public Breathing(string description) : base("Breathing", description)
    {
    }

    public void RunActivity()
    {
        StartActivity();
        RunCountDown("Breath In", 4);
        RunCountDown("Breath out", 6);
    }


}