using System;
class Planet
{
    private Star _sun = new Star();
    private PlanetType _planetType = new PlanetType();
    private List<Feature> _features = new List<Feature>();
    private List<Life> _life = new List<Life>();
    private int _size;
    private int _habitability;
    private string _name;
public Planet ()
    {
    }
    public void GenPlanet()
    {
        _sun.GenStar();
        Console.WriteLine($"{_sun.GetColor()}");
    }

}