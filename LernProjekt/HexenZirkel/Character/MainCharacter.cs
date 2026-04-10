using System;

namespace HexenZirkel.Character;

public class MainCharacter : ICharacter
{
    public string? Name { get; set; }
    public string? Aussehen { get; set; }
    public int Level { get; set; }

    public MainCharacter(string name)
    {
        Aussehen = "Hexe";
        Name = name;
        Level = 1;
    }
}
