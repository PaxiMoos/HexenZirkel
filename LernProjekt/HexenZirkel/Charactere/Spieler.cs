using System;
using HexenZirkel.GeldSystem;

namespace HexenZirkel.Charactere;

public class Spieler : Character
{
    public Inventar inventar = new Inventar();
    public Spieler(string? name)
    {
        Name = name;
        Level = 1;
    }
}
