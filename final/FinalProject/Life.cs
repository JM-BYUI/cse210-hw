using System;
public abstract class Life
{
    private Biome _habitat;
    public Life (Biome b, Planet p)
    {
        _habitat = b;
        
    }
    public abstract void GenerateLife();
    public abstract void Print();
}