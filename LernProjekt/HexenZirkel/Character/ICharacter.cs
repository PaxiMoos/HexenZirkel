using System;

namespace HexenZirkel.Character;

public interface ICharacter
{
    public string? Name { get; set; }
    public string? Aussehen { get; set; }
    public int Level { get; set; }

}
