using System;

public class Menu
{
    private string _menuScreen = "Main Options: \n 1. Create New Goal \n 2. List Goals \n 3. Save Profile \n 4. Load Profile \n 5. Record Event \n 6. View Profile \n 7. Quit \n\nSelect an option from the menu: ";
    private string _input;
    private int _choice = 0;
    public int Choice()
    {
        Console.Write(_menuScreen);
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