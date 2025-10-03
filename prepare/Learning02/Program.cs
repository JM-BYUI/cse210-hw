using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Lays";
        job1._jobTitle = "Chip Tester";
        job1._startYear = 1999;
        job1._endyear = 2004;
        Job job2 = new Job();
        job2._company = "PepsiCo";
        job2._jobTitle = "Soda Tester";
        job2._startYear = 2005;
        job2._endyear = 2011;
        Resume r = new Resume();
        r._name = "Todd Muncherson";
        r._jobs.Add(job1);
        r._jobs.Add(job2);
        r.Display();
    }
}