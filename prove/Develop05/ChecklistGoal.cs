using System;
public class ChecklistGoal : Goal
{
    private int _goalNum;
    private bool _status;
    private int _bonus;
    private int _marks;
    public ChecklistGoal(string type, string name, int xp, int goalNum, int bonus) : base(type, name, xp)
    {
        _status = false;
        _goalNum = goalNum;
        _bonus = bonus;
        _marks = 0;
    }
    public ChecklistGoal(string type, string name, int xp, bool status, int goalNum, int bonus, int marks) : base(type, name, xp)
    {
        _status = status;
        _goalNum = goalNum;
        _bonus = bonus;
        _marks = marks;
    }
    public int GetGoalNum()
    {
        return _goalNum;
    }
    public void MarkOff()
    {
        _marks++;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override bool GetStatus()
    {
        return _status;
    }
    public override void ListGoal(int i)
    {
        if (_status == false)
        {
            Console.WriteLine($"[ ] {i}. {GetName()} - {_marks}/{_goalNum}");
        }
        else if (_status == true)
        {
            Console.WriteLine($"[X] {i}. {GetName()} - {_marks}/{_goalNum}");
            
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
        MarkOff();
        if (_marks >= _goalNum)
        {
            _status = true;
            Console.WriteLine($"You have completed the {GetName()} checklist. You have earned {GetXP()+_bonus} points!");
            return GetXP()+_bonus;

        }
        else
        {
            Console.WriteLine($"You have earned {GetXP()} points. You have {_goalNum-_marks} tasks left in the {GetName()} checklist.");
            return GetXP();
        }
    }
}