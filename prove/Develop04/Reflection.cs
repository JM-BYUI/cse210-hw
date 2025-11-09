using System;
public class Reflection : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    private List<string> _answers = new List<string>();
    private string _desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    public Reflection(string activityName, int length) : base(activityName, length)
    {
    }
    public string getPrompt()
    {
        var random = new Random();
        int ranNum = random.Next(_prompts.Count());
        return _prompts[ranNum];
    }
    public string getQuestion()
    {
        var random = new Random();
        int ranNum = random.Next(_questions.Count());
        return _questions[ranNum];
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
    public void act (int seconds)
    {
        Spinner s = new Spinner(5, "Get ready...");
        s.run();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(getPrompt());
        Console.WriteLine("When you have thought of an answer, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience:");
        Timer t = new Timer(5, "You may begin in:");
        t.run();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {getQuestion()} ");
            _answers.Add(Console.ReadLine());
            Spinner s2 = new Spinner(2, "");
            s2.run();
        }
        Console.WriteLine($"\nYou answered {_answers.Count} questions!");
        
        
    }
}