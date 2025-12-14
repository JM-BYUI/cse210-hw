using System;
class AnimalLife: Life
{
    private string _diet;
    private string _classification;
    public AnimalLife(Biome b, Planet p) : base(b, p)
    {}   
    public override void GenerateLife()
    {
        Random r = new Random();
        string[] diets = { "Herbivores", "Carnivores", "Scavengers"};
        string[] classes = { "Insectoid", "Reptilian", "Mammalian", "Avian", "Crustacean", "Blob" };

        _diet = diets[r.Next(diets.Length)];
        _classification = classes[r.Next(classes.Length)];
    }
    public string GetThis()
    {
        return $"{_classification} {_diet}";
    }
    public override void Print()
    {
        Console.WriteLine($"- {_classification} {_diet}");
    }
}