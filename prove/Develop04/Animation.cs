using System;
public class Animation
{
    private int _counter;
    private string _text;
    public Animation(int c, string t)
    {
        _counter = c;
        _text = t;
    }
    public int getCounter()
    {
        return _counter;
    }
    public string getText()
    {
        return _text;
    }
}