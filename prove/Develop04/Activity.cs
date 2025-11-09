using System;

public class Activity
{
    private string _activityName;
    private int _length;
    public Activity(string name, int time)
    {
        _activityName = name;
        _length = time;
    }
    public void getName()
    {
        Console.WriteLine($"Welcome to {_activityName}");
    }
    public void setName(string n)
    {
        _activityName = n;
    }
    public int getLength()
    {
        return _length;
    }
    public void setLength(int t)
    {
        _length = t;
    }

}