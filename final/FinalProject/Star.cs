using System;
using Microsoft.VisualBasic;

class Star
{
    private string _name;
    private string _class;
    private string _type;
    private string _color;
    private int _heat; 
    private int _size;
    private List<(string type, string name, int size, int temp)> _commonStars = new List<(string type, string name, int size, int temp)>
    {
        ("G", "Yellow Star", 3, 3),
        ("K", "Orange Dwarf", 2, 3),
        ("M", "Red Dwarf", 2, 2),
    };
    private List<(string type, string name, int size, int temp)> _uncommonStars = new List<(string type, string name, int size, int temp)>
    {
        ("L", "Brown Dwarf", 1, 1),
        ("D", "White Dwarf", 1, 2),
        ("M", "Red Giant", 4, 5),
        ("B", "Blue Giant", 4, 5),
        ("A/F", "White Star", 3, 4)
        
    };
    private List<(string type, string name, int size, int temp)> _rareStars = new List<(string type, string name, int size, int temp)>
    {
        ("M", "Red Supergiant", 5, 6),
        ("O", "Blue Supergiant", 5, 6),
        ("N/A", "Neutron Star", 0, 0),
        ("N/A", "Black Hole", 0, 0)
    };

    public void GenStar()
    {
        Random r = new Random();
        int rarity = r.Next(10);
        if (rarity < 5)
        {
            int c = r.Next(3);
            _class = _commonStars[c].type;
            _type = _commonStars[c].name;
            string[] color = _commonStars[c].name.Split(' ');
            _color = color[0];
            _size = _commonStars[c].size;
            _heat = _commonStars[c].temp;

        }
        else if (rarity >= 5 && rarity < 9)
        {
            int c = r.Next(5);
            _class = _uncommonStars[c].type;
            _type = _uncommonStars[c].name;
            string[] color = _uncommonStars[c].name.Split(' ');
            _color = color[0];
            _size = _uncommonStars[c].size;
            _heat = _uncommonStars[c].temp;
        }
        else if (rarity >= 9)
        {
            int c = r.Next(4);
            _class = _rareStars[c].type;
            _type = _rareStars[c].name;
            string[] color = _rareStars[c].name.Split(' ');
            _color = color[0];
            _size = _rareStars[c].size;
            _heat = _rareStars[c].temp;
        }
        _name = NameGen();
        
    }
    public string NameGen()
    {
        return "Sol";
    }
    public int GetHeat()
    {
        return _heat;
    }
    public int GetSize()
    {
        return _size;
    }
    public string GetName()
    {
        return _name;
    } 
    public string GetStarClass()
    {
        return _class;
    }
    public string GetStarType()
    {
        return _type;
    }
    public string GetColor()
    {
        return _color;
    }

}