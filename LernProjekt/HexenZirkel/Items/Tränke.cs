using System;
using HexenZirkel.GeldSystem;

namespace HexenZirkel.Items;

public abstract class Tränke
{
    public string? Name { get; set; }
    public string? Wirkung { get; set; }
    public int Preis { get; set; }
    public Größe TrankGröße { get; set; }

    public WarenKosten Geld = new WarenKosten();

    public enum Größe
    {
        Groß,
        Mittel,
        Klein
    }

    public abstract void TrankBeschreibung();
}
