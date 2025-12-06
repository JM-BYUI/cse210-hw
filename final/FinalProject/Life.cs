using System;
public abstract class Life
{
    private List<string> _plantTypes;
    private List<string> _animalTypes;
    private string _spread;
    private string _name;
    private string _desc;
    private Biome _habitat;
    public Life (Biome b, Planet p)
    {
        _habitat = b;
        
    }
    public abstract void GenerateLife();
    public abstract void GetLifeType();
}