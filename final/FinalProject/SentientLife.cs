using System;
class SentientLife: Life
{
    private string _name;
    private string _tech;
    private List<string> _techs = new List<string>
    {
        "Stone Age", "Bronze Age", "Iron Age", "Medieval", "Industrial", "Modern", "Spacefaring"
    };

    public SentientLife(Biome b, Planet p) : base(b, p)
    {
        Random r = new Random();
        int n = r.Next(1);
        if (n == 0)
        {
            PlantLife plant = new PlantLife(b, p);
            plant.GenerateLife();
            _name = plant.GetThis();
        }
        else if (n == 1)
        {
            AnimalLife animal = new AnimalLife(b, p);
            animal.GenerateLife();
            _name = animal.GetThis();
        }

    }
    public override void GenerateLife()
    {
        Random r = new Random();
        _tech = _techs[r.Next(_techs.Count())];
    }
    public override void Print()
    {
        Console.WriteLine($"Intelligent Life: {_tech} {_name}.");
    }
}