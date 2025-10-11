using System;

class Prompts
{
    public static string[] _prompts = {
        "What was something good that happened today?",
        "What's something that you should work on?",
        "What's something funny or interesting that someone told you today?",
        "Did you read, watch, or listen to anything today? What was it?",
        "What's the name of someone you talked to today?"
        };
    public List<string> _promptList = new List<string>(_prompts);
    public Prompts()
    {

    }

    public void Display()
    {
        var ran = new Random();
        int prompt_num = ran.Next(_promptList.Count);
        Console.WriteLine(_promptList[prompt_num]);

    }

    public string GetPrompt()
    {
        var ran = new Random();
        int prompt_num = ran.Next(_promptList.Count);
        return _promptList[prompt_num];
    }
    
}