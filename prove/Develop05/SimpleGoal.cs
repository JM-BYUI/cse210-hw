using System;
public class SimpleGoal : Goal
{
    public bool _status;
    public SimpleGoal(string type, string name, int xp) : base(type, name, xp)
    {
        _status = false;
    }
    public SimpleGoal(string type, string name, int xp, bool status) : base(type, name, xp)
    {
        _status = status;
    }
    public override bool GetStatus()
    {
        return _status;
    }
    public override void ListGoal(int i)
    {
        if (_status == false)
        {
            Console.WriteLine($"[ ] {i}. {GetName()}");
        }
        else if (_status == true)
        {
            Console.WriteLine($"[X] {i}. {GetName()}");
            
        }  
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
        _status = true;
        Console.WriteLine($"You earned {GetXP()} points!");
        return GetXP();

    }
}