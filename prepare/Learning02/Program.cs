using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2026;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Chef";
        job2._company = "Cafe Brown";
        job2._startYear = 2018;
        job2._endYear = 2024;

        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Jayden Pope";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}