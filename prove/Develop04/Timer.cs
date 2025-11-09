using System;

public class Timer : Animation
{
    public Timer(int c, string t) : base(c, t)
    {

    }
    public void run()
    {
        Console.WriteLine(); 
        for (int i = getCounter(); i > 0; i--)
        {
            string message = getText();
            Console.Write($"{message} {i}");
            Thread.Sleep(1000);
            string wipe = new string('\b', (message.Length + 10)); 
            Console.Write(wipe);
        }
    }
}