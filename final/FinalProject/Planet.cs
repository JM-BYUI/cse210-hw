using System;
public class Planet
{
    private Star _sun = new Star();
    private List<Feature> _features = new List<Feature>();
    private List<Life> _life = new List<Life>();
    private List<string> _gasses = new List<string>
    {
        "Carbon Dioxide", "Methane", "Oxygen", "Helium"
    };
    private List<string> _liquids = new List<string>
    {
        "Water", "Methane"
    };
    private string _size;
    private int _habitability;
    private string _name;
    private string _category;
    private string _liquid;
    private string _atmosphere;
public Planet ()
    {
        _size = "None";
        _atmosphere = "None";
        _habitability = 0;
        _name = "None";
    }
    public void GenPlanet()
    {
        Random r = new Random();
        _sun.GenStar();
        _name = "default";
        int sunSize = _sun.GetSize();
        int rNum = r.Next(10);
        switch (sunSize)
        {
            case 0:
                if (rNum <= 7)
                {
                    _category = "Rocky";
                }
                else
                {
                    _category = "Gas";
                }
                break;
            case 1:
                if (rNum <= 8)
                {
                    _category = "Rocky";
                }
                else
                {
                    _category = "Gas";
                }
                break;
            case 2:
                if (rNum <= 7)
                {
                    _category = "Rocky";
                }
                else
                {
                    _category = "Gas";
                }
                break;
            case 3:
                if (rNum <= 6)
                {
                    _category = "Rocky";
                }
                else
                {
                    _category = "Gas";
                }
                break;
            case 4:
                if (rNum <= 5)
                {
                    _category = "Rocky";
                }
                else
                {
                    _category = "Gas";
                }
                break;
            case 5:
                if (rNum <= 7)
                {
                    _category = "Rocky";
                }
                else
                {
                    _category = "Gas";
                }
                break;  
            default:
                _category = "Rocky";
                break;
        }
        int sunTemp =_sun.GetHeat();
        int rAtmo = r.Next(10);
        int rLiq = r.Next(10);
        if (_category == "Rocky")
        {
            switch(sunTemp)
            {
                case 0: // Black Hole or Neutron
                    if (rAtmo >= 8)
                    {
                        _atmosphere = $"Thin, {_gasses[r.Next(5)]}";
                    }
                    else
                    {
                        _atmosphere = "None";

                    }
                    if (rLiq >= 8 && _atmosphere != "None")
                    {
                        _liquid = $"Frozen {_liquids[r.Next(2)]}";
                    }
                    else
                    {
                        _liquid = "None";
                    }
                    break;
                case 1: // Red Dwarf, Brown Dwarf, or White Dwarf
                    if (rAtmo <= 3)
                    {
                        _atmosphere = "None";
                    }
                    else if (rAtmo <= 6)
                    {
                        _atmosphere = $"Thin, {_gasses[r.Next(5)]}";
                    }
                    else
                    {
                        _atmosphere = _gasses[r.Next(5)];
                    }
                    if (rLiq <= 3 || _atmosphere == "None")
                    {
                        _liquid = "None";
                    }
                    else if (rLiq <= 7)
                    {
                        _liquid = $"Frozen {_liquids[r.Next(2)]}";
                    }
                    else if (rLiq <=8)
                    {
                        _liquid = $"Sparse {_liquids[r.Next(2)]}";
                    }
                    else
                    {
                        _liquid = $"{_liquids[r.Next(2)]} Oceans";
                    }
                    break;
                case 2: // Yellow/Orange/White Star
                    if (rAtmo <= 3)
                    {
                        _atmosphere = "None";
                    }
                    else if (rAtmo <= 6)
                    {
                        _atmosphere = $"Thin, {_gasses[r.Next(5)]}";
                    }
                    else
                    {
                        _atmosphere = _gasses[r.Next(5)];
                    }
                    if (rLiq <= 2 || _atmosphere == "None")
                    {
                        _liquid = "None";
                    }
                    else if (rLiq <= 5)
                    {
                        _liquid = $"Sparse {_liquids[r.Next(2)]}";
                    }
                    else if (rLiq <=7)
                    {
                        _liquid = $"Frozen {_liquids[r.Next(2)]}";
                    }
                    else
                    {
                        _liquid = $"{_liquids[r.Next(2)]} Oceans";
                    }
                    break;
                case 3: // Giant
                    if (rAtmo <= 5)
                    {
                        _atmosphere = "None";
                    }
                    else if (rAtmo <= 7)
                    {
                        _atmosphere = $"Thin, {_gasses[r.Next(5)]}";
                    }
                    else
                    {
                        _atmosphere = _gasses[r.Next(4)];
                    } 
                    if (rLiq >= 8 && _atmosphere != "None")
                    {
                        _liquid = $"Sparse {_liquids[r.Next(2)]}";
                    }
                    else
                    {
                        _liquid = "None";
                    }
                    break;
                case 4: // Supergiant
                    _atmosphere = "None";
                    _liquid = "None";
                    break;
                default: 
                    break;
            }
        }
        else
        {
            _atmosphere = _gasses[r.Next(5)];
        }
        int rSize = 0;
            if (_category == "Rocky")
            {
                rSize = r.Next(4);
            }
            else if (_category == "Gas")
            {
                rSize = r.Next(2, 5);
                
            }
            switch (rSize)
            {
                case 0:
                    _size = "Dwarf";
                    break;
                case 1:
                    _size = "Small";
                    break;
                case 2:
                    _size = "Medium";
                    break;
                case 3:
                    _size = "Large";
                    break;
                case 4:
                    _size = "Massive";
                    break;
                default:
                    break;
            }
        Console.WriteLine($"Planet Name: {_name}\nSun: {_sun.GetName()}, Type {_sun.GetStarClass()} {_sun.GetStarType()} \nSize: {_size}\nType: {_category} \nAtmosphere: {_atmosphere}\nLiquid: {_liquid}\n");
    }
    public int GetHabitability()
    {
        return _habitability;
    }
    public string GetSize()
    {
        return _size;
    }
    public string GetName()
    {
        return _name;
    }

}