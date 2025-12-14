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
        if (_sun.GetStarType() == "Red Giant" || _sun.GetStarType() == "Blue Giant" ||_sun.GetStarType() == "Red Supergiant" || _sun.GetStarType() == "Blue Supergiant")
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
        GenName();
        GenFeatures();
        Console.WriteLine($"The Planet {_name}");
        Console.WriteLine($"Star: A Class {_sun.GetStarClass()} {_sun.GetStarType()}");
        Console.WriteLine($"Classification: {_category}");
        Console.WriteLine($"Type: {_planetType}");
        Console.WriteLine($"Size: {_size}");
        Console.WriteLine($"Habitability Index: {_habitability}");
        Console.WriteLine($"Atmosphere: {_atmosphere}");
        Console.WriteLine($"Liquid: {_liquid}");
        Console.WriteLine($"Temperature: {_temp}");
        Console.WriteLine($"Light Level: {_light}");
        Console.WriteLine($"Biomes:");
        foreach (Biome b in _features)
        {
            Console.WriteLine($"- {b.GetBiome(this)}");
        }
        foreach (Life l in _life)
        {
            l.Print();
        }

        


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
        if (_habitability < 70)
        {
            Biome b = new Biome("Unknown");
            _features.Add(b);
            GenLife(b);
        }
        else
        {
            int biomeCount = r.Next(1,4);
            for (int i = 0; i< biomeCount; i++)
            {
                Biome b = new Biome("Unknown");
                _features.Add(b);
                GenLife(b);
            }
        }
    }
    public void GenLife(Biome b)
    {
        int lifeRoll = r.Next(0, 100);

        if (lifeRoll < _habitability) 
        {
            PlantLife plant = new PlantLife(b, this);
            plant.GenerateLife();
            _life.Add(plant);
        }

        if (lifeRoll < _habitability - 20)
        {
            AnimalLife animal = new AnimalLife(b, this);
            animal.GenerateLife();
            _life.Add(animal);
        }

        if (lifeRoll < _habitability - 80)
        {
            SentientLife civ = new SentientLife(b, this);
            civ.GenerateLife();
            _life.Add(civ);
        }
    }
    public void GenName()
    {
        string[] prefixes = { "Zim", "Zo", "Gim", "Gar", "Vo", "Nu", "Buu" };
        string[] suffixes = { "tan", "tor", "gos", "th", "ta", "los", "nix" };
        _name = prefixes[r.Next(prefixes.Length)] + suffixes[r.Next(suffixes.Length)];
    }
    public string GetName()
    {
        return _name;
    }
    public int GenHab()
    {
        int hab;
        if (_planetType == "Terran World" || _planetType == "Ocean World" || _planetType == "Jungle World") 
        {
            hab = 100;
        }
        else if (_planetType == "Desert World" || _planetType == "Tundra World" )
        {
            hab = 90;
        }
        else if (_planetType == "Cryovolcanic World")
        {
            hab = 70;
        }
        else
        { hab = 0;}
        return hab;
    }
    public string GetTemp() { return _temp; }
    public string GetAtmosphere() { return _atmosphere; }
    public string GetLiquid() { return _liquid; }
    public string GetPlanetType() {return _planetType;}


}
