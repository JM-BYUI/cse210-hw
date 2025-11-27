using System;

public class EvilGoal : Goal
{
    public bool _status;
    public EvilGoal(string type, string name, int xp) : base(type, name, xp)
    {
        _status = false;
    }
    public EvilGoal(string type, string name, int xp, bool status) : base(type, name, xp)
    {
        _status = status;
    }
    public override bool GetStatus()
    {
        return _status;
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
        Console.WriteLine($"You have lost {GetXP()} points, but your evil power increases...");
        return GetXP();

    }
}