using System;
using HexenZirkel.Character;

namespace HexenZirkel.Gebäude;

public class MainGebäude : IGebäude
{
    public string? Name { get; set; }
    public int GebäudeLevel { get; set; }

    public MainGebäude(string name)
    {
        Name = name;
        GebäudeLevel = 1;
    }

    public void Betreten()
    {
        System.Console.WriteLine($"{Name} wird betreten...");
    }

    public void Verlassen()
    {
        System.Console.WriteLine($"{Name} wird verlassen...");
    }
}
