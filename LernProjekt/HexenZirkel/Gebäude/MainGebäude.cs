using System;
using HexenZirkel.Character;
using HexenZirkel.Missionen;

namespace HexenZirkel.Gebäude;

public class MainGebäude : IGebäude
{
    public string? Name { get; set; }
    public int GebäudeLevel { get; set; }
    public Mission mission = new Mission();

    public MainGebäude(string name)
    {
        Name = name;
        GebäudeLevel = 1;
    }

    public void Betreten()
    {
        System.Console.WriteLine($"{Name} wird betreten...");
        System.Console.WriteLine("");
    }

    public void Verlassen()
    {
        System.Console.WriteLine($"{Name} wird verlassen...");
    }
}
