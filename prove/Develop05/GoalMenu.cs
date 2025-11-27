using System;
public class GoalMenu
{

    private string _menuScreen1 = "Goal Options: \n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal \n 4. ";
    private string _evil = "Evil";
    private string _menuScreen2 = " Goal \n 5. Back to Menu \n\nSelect an option from the menu: ";
    private string _input;
    private int _choice = 0;
    public int GoalChoice()
    {
        var currentColor = Console.ForegroundColor;
        Console.Write(_menuScreen1);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write (_evil);
        Console.ForegroundColor = currentColor;
        Console.Write(_menuScreen2);
        _input = Console.ReadLine();
        _choice = 0;
        try
        {
            _choice = int.Parse(_input);
        }
        catch (FormatException)
        {
            _choice = 0;
        }
        return _choice;
    }
}