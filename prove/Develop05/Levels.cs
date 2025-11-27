using System;

class Levels
{
    private int _level;
    private int _currentXP;
    private int _threshold;
    public Levels ()
    {
        _level = 1;
        _currentXP = 0;
        _threshold = 1000;
    }
    public bool AddXP(int xp)
    {
        bool levelUp = false;
        _currentXP += xp;
        if (_currentXP >= _threshold)
        {
            _level++;
            levelUp = true;
            _currentXP -= _threshold;
            _threshold += 500;
            Console.WriteLine($"LEVEL UP! You are now level {_level}!");
        }
        return levelUp;
    }
    public void SetLevel(int l)
    {
        _level = l;
    }
    public int GetLevel()
    {
        return _level;
    }
    public void SetThresh(int t)
    {
        _threshold = t;
    }
    public int GetThresh()
    {
        return _threshold;
    }
    public void SetCurrentXP(int c)
    {
        _currentXP = c;
    }
    public int GetCurrentXP()
    {
        return _currentXP;
    }
}