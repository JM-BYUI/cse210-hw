using System;

public class Listing : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the holy ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _newList = new List<string>();
    private string _desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    public Listing(string activityName, int length) : base(activityName, length)
    {
    }
    public string getPrompt()
    {
        var random = new Random();
        int ranNum = random.Next(_prompts.Count());
        return _prompts[ranNum];
    }
    public List<string> getNewList()
    {
        return _newList;
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
        Console.WriteLine();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine(getPrompt());
        Timer t = new Timer(5, "You may begin in:");
        t.run();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _newList.Add(Console.ReadLine());
        }
        Console.WriteLine($"\nYou listed {_newList.Count} items!");
    }
}