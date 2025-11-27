using System;
public class EternalGoal : Goal
{
    private bool _status;
    public EternalGoal(string type, string name, int xp) : base(type, name, xp)
    {
        _status = false;
    }
    public EternalGoal(string type, string name, int xp, bool status) : base(type, name, xp)
    {
        _status = status;
    }
    public override void ListGoal(int i)
    {
        Console.WriteLine($"[ ] {i}. {GetName()}");
    }
    public override string SaveGoal()
    {
        return ($"{GetGoalType()}; {GetName()}; {GetXP()}; {_status}");
    }
    public override string LoadGoal()
    {
       return ($"{GetGoalType()}; {GetName()}; {GetXP()}; {_status}");
    }
    public override int RecordEvent(List<Goal> goals)
    {
        Console.WriteLine($"You earned {GetXP()} points!");
        return GetXP();

    }
    public override bool GetStatus()
    {
       return false;
    }
}