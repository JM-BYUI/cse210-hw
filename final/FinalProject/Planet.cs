using System;
public class Planet
{
    private static Random r = new Random();
    private Star _sun = new Star();
    private List<Feature> _features = new List<Feature>();
    private List<Life> _life = new List<Life>();
    private List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)> _planetsBH = new List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)>
    {
        ("Barren World", "Rocky", r.Next(3), "None", "None", "Freezing", "Dark"),
        ("Metallic World", "Rocky", r.Next(3), "None", "None", "Freezing", "Dark"),
        ("Frozen World", "Rocky", r.Next(3), "Thin", "Frozen", "Frozen Surface", "Dark"),
        ("Cryovolcanic World", "Rocky", r.Next(3), "Thin", "Frozen", "Geothermal", "Dark"),
        ("Volcanic World", "Rocky", r.Next(3), "Thin", "Magma", "Extremely Hot", "Dim"),
        ("Ice Giant", "Gas", r.Next(2, 4), "Dense", "None", "Freezing", "Dark")
        
    };
    private List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)> _planetsNS = new List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)>
    {
        ("Barren World", "Rocky", r.Next(3), "None", "None", "Freezing", "Dim"),
        ("Metallic World", "Rocky", r.Next(3), "None", "None", "Freezing", "Dim"),
        ("Frozen World", "Rocky", r.Next(3), "Thin", "Frozen", "Frozen Surface", "Dark"),
        ("Cryovolcanic World", "Rocky", r.Next(3), "Thin", "Frozen", "Geothermal", "Dark"),
        ("Volcanic World", "Rocky", r.Next(3), "Thin", "Magma", "Extremely Hot", "Dim"),
        ("Ice Giant", "Gas", r.Next(2, 4), "Dense", "None", "Freezing", "Dark"),
        ("Irradiated World", "Rocky", r.Next(3), "Irradiated", "None", "Freezing", "Dim")
        
    };
    private List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)> _planetsDwarf = new List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)>
    {
        ("Barren World", "Rocky", r.Next(3), "None", "None", "Cold", "Dim"),
        ("Metallic World", "Rocky", r.Next(3), "None", "None", "Cold", "Dim"),
        ("Frozen World", "Rocky", r.Next(3), "Thin", "Frozen", "Frozen Surface", "Dim"),
        ("Cryovolcanic World", "Rocky", r.Next(3), "Thin", "Frozen", "Geothermal", "Dim"),
        ("Volcanic World", "Rocky", r.Next(3), "Thin", "Magma", "Extremely Hot", "Average"),
        ("Tundra World", "Rocky", r.Next(3), "Full", "Cold Oceans", "Chilly", "Average")
        
    };
    private List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)> _planetsMed = new List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)>
    {
        ("Barren World", "Rocky", r.Next(3), "None", "None", "Warm", "Average"),
        ("Metallic World", "Rocky", r.Next(3), "None", "None", "Warm", "Average"),
        ("Frozen World", "Rocky", r.Next(3), "Thin", "Frozen", "Frozen Surface", "Dim"),
        ("Cryovolcanic World", "Rocky", r.Next(3), "Thin", "Cold", "Geothermal", "Dim"),
        ("Volcanic World", "Rocky", r.Next(3), "Thin", "Magma", "Extremely Hot", "Average"),
        ("Gas Giant", "Gas", r.Next(2, 4), "Dense", "None", "Cold", "Dim"),
        ("Irradiated World", "Rocky", r.Next(3), "Irradiated", "None", "Cold", "Bright"),
        ("Tundra World", "Rocky", r.Next(3), "Full", "Cold Oceans", "Chilly", "Average"),
        ("Desert World", "Rocky", r.Next(3), "Full", "Sparse", "Warm", "Bright"),
        ("Jungle World", "Rocky", r.Next(3), "Full", "Oceans", "Warm", "Average"),
        ("Ocean World", "Rocky", r.Next(3), "Full", "Surface", "Temperate", "Average"),
        ("Terran World", "Rocky", r.Next(3), "Full", "Oceans", "Temperate", "Average")
    };
    private List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)> _planetsGiant = new List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)>
    {
        ("Barren World", "Rocky", r.Next(3), "None", "None", "Warm", "Blinding"),
        ("Metallic World", "Rocky", r.Next(3), "None", "None", "Freezing", "Bright"),
        ("Cryovolcanic World", "Rocky", r.Next(3), "Thin", "Cold", "Geothermal", "Average"),
        ("Volcanic World", "Rocky", r.Next(3), "Thin", "Magma", "Extremely Hot", "Blinding"),
        ("Gas Giant", "Gas", r.Next(2, 4), "Dense", "None", "Hot", "Bright"),
        ("Irradiated World", "Rocky", r.Next(3), "Irradiated", "None", "Hot", "Blinding"),
        ("Desert World", "Rocky", r.Next(3), "Full", "Sparse", "Warm", "Bright"),
        
    };
    private string _planetType;
    private string _category; 
    private string _size;
    private string _atmosphere;
    private string _liquid;
    private string _temp;
    private string _light;
    private int _habitability;
    private string _name;
    public Planet ()
    {
        _size = "None";
        _habitability = 0;
        _name = "None";
    }
    public void GenPlanet()
    {
        _sun.GenStar();
        _name = "default";
        if (_sun.GetStarType() == "Neutron Star")
        {
            int c = r.Next(_planetsNS.Count());
            _planetType = _planetsNS[c].type;
            _atmosphere = _planetsNS[c].atmosphere;
            _category = _planetsNS[c].atmosphere;
            _light = _planetsNS[c].light;
            _temp = _planetsNS[c].temp;
            _liquid = _planetsNS[c].liquid;
            _size = GenSize(_planetsNS[c].size);
        }
        if (_sun.GetStarType() == "Black Hole")
        {
            int c = r.Next(_planetsBH.Count());
            _planetType = _planetsBH[c].type;
            _atmosphere = _planetsBH[c].atmosphere;
            _category = _planetsBH[c].atmosphere;
            _light = _planetsBH[c].light;
            _temp = _planetsBH[c].temp;
            _liquid = _planetsBH[c].liquid;
            _size = GenSize(_planetsBH[c].size);
        }
        if (_sun.GetStarType() == "White Dwarf" || _sun.GetStarType() == "Red Dwarf" ||_sun.GetStarType() == "Brown Dwarf")
        {
            int c = r.Next(_planetsDwarf.Count());
            _planetType = _planetsDwarf[c].type;
            _atmosphere = _planetsDwarf[c].atmosphere;
            _category = _planetsDwarf[c].atmosphere;
            _light = _planetsDwarf[c].light;
            _temp = _planetsDwarf[c].temp;
            _liquid = _planetsDwarf[c].liquid;
            _size = GenSize(_planetsDwarf[c].size);
        }
        if (_sun.GetStarType() == "White Star" || _sun.GetStarType() == "Yellow Star" ||_sun.GetStarType() == "Orange Star")
        {
            int c = r.Next(_planetsMed.Count());
            _planetType = _planetsMed[c].type;
            _atmosphere = _planetsMed[c].atmosphere;
            _category = _planetsMed[c].atmosphere;
            _light = _planetsMed[c].light;
            _temp = _planetsMed[c].temp;
            _liquid = _planetsMed[c].liquid;
            _size = GenSize(_planetsMed[c].size);
        }
        if (_sun.GetStarType() == "Red Giant" || _sun.GetStarType() == "Blue Giant" ||_sun.GetStarType() == "Red")
        {
            int c = r.Next(_planetsGiant.Count());
            _planetType = _planetsGiant[c].type;
            _atmosphere = _planetsGiant[c].atmosphere;
            _category = _planetsGiant[c].atmosphere;
            _light = _planetsGiant[c].light;
            _temp = _planetsGiant[c].temp;
            _liquid = _planetsGiant[c].liquid;
            _size = GenSize(_planetsGiant[c].size);
        }
        GenHab();

    }
    public bool HasLife()
    {
        return false;
    }
    public int GetHabitability()
    {
        return _habitability;
    }
    public string GenSize(int n)
    {
        switch(n)
        {
            case 0:
                return "Dwarf"; 
            case 1:
                return "Medium";
            case 2:
                return "Large";
            case 3:
                return "Giant";
            default:
                return "Dwarf";
        }
    }
    public string GetSize()
    {
        return _size;
    }
    public void GenFeatures()
    {
        
    }
    public void GenLife()
    {
    }
    public void GenName()
    {
        
    }
    public string GetName()
    {
        return _name;
    }
    public int GenHab()
    {
        int hab = 100;
        switch(_atmosphere)
        {
            case "None":
                hab -= 50;
                break;
            case "Thin":
                hab -= 20;
                break;
            case "Full":
                break;
            case "Dense":
                hab -= 10;
                break;
            case "Irradiated":
                hab -= 60;
                break;
            default:
                break;
        }
        switch(_light)
        {
            case "Dark":
                hab -= 20;
                break;
            case "Dim":
                hab -= 10;
                break;
            case "Average":
                break;
            case "Bright":
                break;
            case "Blinding":
                hab -= 20;
                break;
            default:
                break;
        }
        switch(_liquid)
        {
            case "None":
                hab -= 40;
                break;
            case "Frozen":
                hab -= 10;
                break;
            case "Magma":
                hab -= 50;
                break;
            case "Sparse":
                hab -= 10;
                break;
            case "Cold Oceans":
                break;
            case "Oceans":
                hab += 10;
                break;
            case "Surface":
                hab += 20;
                break;
            default:
                break;
        }
        switch(_temp)
        {
            case "Freezing":
                hab -= 40;
                break;
            case "Frozen Surface":
                hab -= 20;
                break;
            case "Geothermal":
                break;
            case "Cold":
                hab -= 20;
                break;
            case "Chilly":
                break;
            case "Temperate":
                hab +=10;
                break;
            case "Warm":
                break;
            case "Hot":
                hab -= 20;
                break;
            case "Extremely Hot":
                hab -= 30;
                break;
            default:
                break;
        }
        switch (hab)
        {
            case >= 100:
                hab = 100;
                break;
            case <= 0:
                hab = 0;
                break;
            default:
                break;
        }
        return hab;
    }

}