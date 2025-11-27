using System;
using System.IO;

class Profile
{
    private string _profileName;
    private int _score;
    private int _evilPoints;
    private Levels _levels;
    private List<Goal> _goals = new List<Goal>();
    public Profile ()
    {
        _profileName = "NoName";
        _score = 0;
        _evilPoints = 0;
        _levels = new Levels();
    }
    public void SetProfileName(string p)
    {
        _profileName = p;
    }
    public string GetProfileName()
    {
        return _profileName;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public int GetScore()
    {
        return _score;
    }
    public void SetEvil(int e)
    {
        _evilPoints = e;
    }
    public int GetEvilPoints()
    {
        return _evilPoints;
    }
    public Levels GetLevels()
    {
        return _levels;
    }
    public void AddPoints(int points)
    {
        _score+= points;
        _levels.AddXP(points);
    }
    public void AddBonusPoints(int bonus)
    {
        _score+= bonus;
        _levels.AddXP(bonus);
    }
    public void SetTotal(int total)
    {
        _score = total;
    }
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            int i = 1;
            Console.WriteLine("\nGoals:");
            foreach (Goal g in _goals)
            {
                g.ListGoal(i);
                i++;
            }
        }
        else
        {
            Console.WriteLine("\nYou don't have any goals. Shame on you!");
        }
    }
    public void RecordEvent()
    {
        ListGoals();
        Console.Write("\nWhich goal did you accomplish? ");
        int option = -1;
        try
        {
            option = int.Parse(Console.ReadLine())-1;
        }
        catch
        {
            option = -1;
        }
        if (option >= 0)
        {

            int xp = GetGoals()[option].RecordEvent(_goals);
            if (GetGoals()[option].GetStatus() == false)
            {
                AddPoints(xp);
                if (GetGoals()[option].GetGoalType() == "Evil Goal")
                {
                    _evilPoints++;
                }
                Console.WriteLine($"You have earned a total of {_score} points.");  
            }
            if (GetGoals()[option].GetStatus() == true)
            {
                Console.WriteLine("This goal has already been accomplished.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
    public void SaveProfile()
    {
        Console.Write($"\nWhat is the name for this profile file? ");
        string filename = Console.ReadLine() + ".txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{GetProfileName()}; {GetScore()}; {GetEvilPoints()}; {_levels.GetLevel()}; {_levels.GetCurrentXP()}; {_levels.GetThresh()}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
    public void LoadProfile()
    {
        Console.Write($"\nWhat is the name for this profile file? ");
        string filename = Console.ReadLine() + ".txt";
        
        if (File.Exists(filename))
        {
            string[] text = File.ReadAllLines(filename);
            string[] line1 = text[0].Split("; ");
            string p = line1[0];
            SetProfileName(p);
            int totalScore = int.Parse(line1[1]);
            SetTotal(totalScore);
            int evil = int.Parse(line1[2]);
            SetEvil(evil);
            int ll = int.Parse(line1[3]);
            int lxp = int.Parse(line1[4]);
            int lt = int.Parse(line1[5]);
            _levels.SetLevel(ll);
            _levels.SetCurrentXP(lxp);
            _levels.SetThresh(lt);
            text = text.Skip(1).ToArray();
            foreach (string line in text)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                int points = int.Parse(entries[2]);
                bool status = Convert.ToBoolean(entries[3]);

                if (entries[0] == "Simple Goal")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, points, status);
                    AddGoal(sGoal);
                }
                if (entries[0] == "Eternal Goal")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, points, status);
                    AddGoal(eGoal);
                }
                if (entries[0] == "Checklist Goal")
                {
                    int goalNum = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int marks = int.Parse(entries[7]);
                    ChecklistGoal clGoal = new ChecklistGoal(type, name, points, status, goalNum, bonusPoints, marks);
                    AddGoal(clGoal);
                }
                if (entries[0] == "Evil Goal")
                {
                    EvilGoal evGoal = new EvilGoal(type, name, points, status);
                    AddGoal(evGoal);
                }
            }
        }
    

        
    }
}