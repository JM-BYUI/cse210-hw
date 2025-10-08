using System;

class Prompts
{
    public string Q1 = "What was something good that happened today?";
    public string Q2 = "What's something that you should work on?";
    public string Q3 = "What's something funny or interesting that someone told you today?";
    public string Q4 = "Did you read, watch, or listen to anything today? What was it?";
    public void Display()
    {
        Random r = new Random();
        int rnum = r.Next(1, 5);
        if (rnum == 1)
        {
            Console.WriteLine(Q1);
        }
        if (rnum == 2)
        {
            Console.WriteLine(Q2);
        }
        if (rnum == 3)
        {
            Console.WriteLine(Q3);
        }
        if (rnum == 4)
        {
            Console.WriteLine(Q4);
        }

    }
}