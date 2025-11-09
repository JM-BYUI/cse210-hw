using System;

public class Spinner : Animation
{
    private List<string> _animations = new List<string>
    {
        "\\",
        "-",
        "/",
        "|",
        "\\",
        "-",
        "/",
        "|",

    };
    public Spinner(int c, string t) : base(c, t)
    {

    }
    public void run()
    {
        Console.WriteLine(); 
        for (int i = getCounter(); i > 0; i--)
        {
            string message = getText();
            int symbol = 0;
            if (i < _animations.Count)
            {
                symbol = i;
            }
            else
            {
                symbol = i % _animations.Count;
            }
            Console.Write($"{message} {_animations[symbol]}");
            Thread.Sleep(500);
            string wipe = new string('\b', (message.Length + 5)); 
            Console.Write(wipe);
        }
    }
}