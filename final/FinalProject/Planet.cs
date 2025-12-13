using System;
public class Planet
{
    private static Random r = new Random();
    private Star _sun = new Star();
    private List<Feature> _features = new List<Feature>();
    private List<Life> _life = new List<Life>();
    private List<string> _planetsOther = new List<string> //planets orbitting Neutron Stars or Black Holes
    {
    };
    private List<string> _planetsCold = new List<string> //planets orbitting White/Red/Brown dwarves
    {
    };
    private List<string> _planetsWarm = new List<string> //planets orbitting Giants
    {
    };
    private List<string> _planetsHot = new List<string> //planets orbitting supergiants
    {
    };
    
    private List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)> _planetsBH = new List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)>
    {
        ("Barren World", "Rocky", r.Next(3), "None", "None", "Freezing", "Dark"),
        ("Metallic World", "Rocky", r.Next(3), "None", "None", "Freezing", "Dark"),
        ("Frozen World", "Rocky", r.Next(3), "None", "Frozen", "Freezing", "Dark"),
        ("Cryovolcanic World", "Rocky", r.Next(3), "None", "Frozen", "Freezing", "Dark"),
        ("Volcanic World", "Rocky", r.Next(3), "Thin", "Magma", "Extremely Hot", "Dim"),
        ("Ice Giant", "Gas", r.Next(2, 4), "Dense", "None", "Freezing", "Dark")
        
    };
    private List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)> _planetsNS = new List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)>
    {
        ("Barren World", "Rocky", r.Next(3), "None", "None", "Freezing", "Dim"),
        ("Metallic World", "Rocky", r.Next(3), "None", "None", "Freezing", "Dim"),
        ("Frozen World", "Rocky", r.Next(3), "None", "Frozen", "Freezing", "Dark"),
        ("Cryovolcanic World", "Rocky", r.Next(3), "None", "Frozen", "Freezing", "Dark"),
        ("Volcanic World", "Rocky", r.Next(3), "Thin", "Magma", "Extremely Hot", "Dim"),
        ("Ice Giant", "Gas", r.Next(2, 4), "Dense", "None", "Freezing", "Dark"),
        ("Irradiated World", "Rocky", r.Next(3), "Irradiated", "None", "Freezing", "Dim")
        
    };
    private List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)> _planetsDwarf = new List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)>
    {
        ("Barren World", "Rocky", r.Next(3), "None", "None", "Cold", "Dim"),
        ("Metallic World", "Rocky", r.Next(3), "None", "None", "Cold", "Dim"),
        ("Frozen World", "Rocky", r.Next(3), "None", "Frozen", "Freezing", "Dim"),
        ("Cryovolcanic World", "Rocky", r.Next(3), "None", "Frozen", "Freezing", "Dim"),
        ("Volcanic World", "Rocky", r.Next(3), "Thin", "Magma", "Extremely Hot", "Dim"),
        ("Tundra World", "Rocky", r.Next(3), "Full", "Cold Oceans", "Chilly", "Average")
        
    };
    private List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)> _planetsMed = new List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)>
    {
        ("Barren World", "Rocky", r.Next(3), "None", "None", "Warm", "Average"),
        ("Metallic World", "Rocky", r.Next(3), "None", "None", "Warm", "Average"),
        ("Frozen World", "Rocky", r.Next(3), "None", "Frozen", "Frozen", "Dim"),
        ("Cryovolcanic World", "Rocky", r.Next(3), "None", "Cold", "Cold", "Dim"),
        ("Volcanic World", "Rocky", r.Next(3), "Thin", "Magma", "Extremely Hot", "Average"),
        ("Gas Giant", "Gas", r.Next(2, 4), "Dense", "None", "Cold", "Dim"),
        ("Irradiated World", "Rocky", r.Next(3), "Irradiated", "None", "Cold", "Bright"),
        ("Tundra World", "Rocky", r.Next(3), "Full", "Cold Oceans", "Chilly", "Average"),
        ("Desert World", "Rocky", r.Next(3), "Full", "Sparse", "Warm", "Bright"),
        ("Jungle World", "Rocky", r.Next(3), "Full", "Oceans", "Warm", "Average"),
        ("Terran World", "Rocky", r.Next(3), "Full", "Oceans", "Temperate", "Average")
    };
    private List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)> _planetsGiant = new List<(string type, string category, int size, string atmosphere, string liquid, string temp, string light)>
    {
        ("Barren World", "Rocky", r.Next(3), "None", "None", "Warm", "Bright"),
        ("Metallic World", "Rocky", r.Next(3), "None", "None", "Freezing", "Bright"),
        ("Cryovolcanic World", "Rocky", r.Next(3), "None", "Cold", "Freezing", "Dim"),
        ("Volcanic World", "Rocky", r.Next(3), "Thin", "Magma", "Extremely Hot", "Bright"),
        ("Gas Giant", "Gas", r.Next(2, 4), "Dense", "None", "Hot", "Average"),
        ("Irradiated World", "Rocky", r.Next(3), "Irradiated", "None", "Hot", "Bright"),
        ("Desert World", "Rocky", r.Next(3), "Full", "Sparse", "Warm", "Bright"),
        
    };
    private string _size;
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
    }
    public bool HasLife()
    {
        return false;
    }
    public int GetHabitability()
    {
        return _habitability;
    }
    public string GetSize()
    {
        return _size;
    }
    public void GenName()
    {
        
    }
    public string GetName()
    {
        return _name;
    }

}