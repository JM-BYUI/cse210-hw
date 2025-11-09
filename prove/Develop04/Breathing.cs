using System;

public class Breathing : Activity
{
    private string _breatheIn = "Breathe in...";
    private string _breatheOut = "Breathe out...";
    private string _desc = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    public Breathing(string activityName, int length) : base(activityName, length)
    {
    }
    public void run()
    {
        Console.WriteLine($"Welcome to the {getName} activity.");
        Console.WriteLine($"\n{_desc}");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int l = int.Parse(Console.ReadLine());
        setLength(l);
        act(l);


    }
    public void act(int seconds)
    {
        Spinner s = new Spinner(5, "Get ready...");
        s.run();
        int secondsSpent = 0;
        Console.WriteLine();
        while (secondsSpent < seconds)
        {
            for (int i = 3; i > 0; i--)
            {
                Console.Write($"{_breatheIn}{i}");
                Thread.Sleep(1000);
                string wipe = new string('\b', (_breatheIn.Length + 2));
                Console.Write(wipe);
                secondsSpent++;
            }
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_breatheOut}{i}");
                Thread.Sleep(1000);
                string wipe = new string('\b', (_breatheOut.Length + 2));
                Console.Write(wipe);
                secondsSpent++;
            }
        }
    }  
}