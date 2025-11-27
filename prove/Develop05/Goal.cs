using System;

public abstract class Goal
{
    private string _goalType;
    private string _name;

    private int _xp;
    public Goal(string type, string name, int xp)
    {
        _goalType = type;
        _name = name;
        _xp = xp;
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetXP()
    {
        return _xp;
    }
    public abstract void ListGoal(int i);
    public abstract bool GetStatus();
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract int RecordEvent(List<Goal> goals);

}