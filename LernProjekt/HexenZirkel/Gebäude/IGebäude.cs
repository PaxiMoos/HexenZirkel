using System;
using HexenZirkel.Character;

namespace HexenZirkel.Gebäude;

public interface IGebäude
{
    public string? Name { get; set; }
    public int GebäudeLevel { get; set; }

    public void Betreten();
    public void Verlassen();
}
