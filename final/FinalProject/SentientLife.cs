using System;
class SentientLife: Life
{
    private List<string> _plantTypes;
    public SentientLife(Biome b, Planet p) : base(b, p)
    {
        
    }
    public override void GenerateLife()
    {}
    public override void GetLifeType()
    {}
}