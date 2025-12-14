using System;
class PlantLife: Life
{
    private string _plantType;
    private string _color;
    public PlantLife(Biome b, Planet p) : base(b, p)
    {
    }
    public override void GenerateLife()
    {
        Random r = new Random();
        string[] types = { "Giant Fungi", "Bioluminescent Moss", "Carnivorous Flowers", "Shimmering Lichen", "Thin Trees", "Delicious Berries"};
        string[] colors = { "Red", "Green", "Blue", "Yellow", "Purple", "White"};

        _plantType = types[r.Next(types.Length)];
        _color = colors[r.Next(colors.Length)];
    }
    public string GetThis()
    {
        return $"{_color} {_plantType}";
    }
    public override void Print()
    {
        Console.WriteLine($"- {_color} {_plantType}");
    }
}