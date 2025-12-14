using System;
public class Biome : Feature
{
    private List<string> _oceanBiomes = new List<string>
    {
        "Kelp Forest", "Coral Reef", "Abyssal Trenches", "Ice Sheets"
    };
    private List<string> _earthBiomes = new List<string>
    {
        "Sand Dunes", "Salt Flats", "Badlands", "Rolling Hills", "Ancient Forest", "Thick Jungle", "Taiga", "Ice Sheets", "Mountain Valleys"
    };

    public Biome (string n) : base(n)
    {}
    public string GetBiome(Planet p)
    {
        string liquid = p.GetLiquid();
        string temp = p.GetTemp();
        string type = p.GetPlanetType();
        if (type == "Volcanic World")
        {
            return "Lava Fields";
        }
        else if (type == "Cryovolcanic World")
        {
            return "Hydrothermic Vents";
        }
        else if (type == "Frozen World")
        {
            return "Ice Sheets";
        }
        else if (type == "Terran World")
        {
            int n = new Random().Next(2);
            switch (n)
            {
                case 0:
                    return _earthBiomes[new Random().Next(_earthBiomes.Count)];
                case 1:
                    return _oceanBiomes[new Random().Next(_oceanBiomes.Count)];
                default:
                    return _earthBiomes[new Random().Next(_earthBiomes.Count)];
            }
        }
        else if (type == "Ocean World")
        {
            return _oceanBiomes[new Random().Next(_oceanBiomes.Count)];
        }
        else if (type == "Gas Giant" || type == "Ice Giant")
        {
            return "Cloud Seas";
        }
        else if (type == "Jungle World")
        {
            int n = new Random().Next(2);
            switch (n)
            {
                case 0:
                    return _earthBiomes[new Random().Next(4, 6)];
                case 1:
                    return _oceanBiomes[new Random().Next(_oceanBiomes.Count)];
                default:
                    return _earthBiomes[new Random().Next(4, 6)];
            }
            
        }
        else if (type == "Desert World")
        {
            return _earthBiomes[new Random().Next(3)];
        }
        else if (type == "Tundra World")
        {
            return _earthBiomes[new Random().Next(6, 8)];
        }
        else
        {
            int n = new Random().Next(2);
            switch (n)
            {
                case 0:
                    return "Mountains";
                case 1:
                    return "Wasteland";
                default:
                    return "Wasteland";
            }

        }
        
    }

}