using System;
using HexenZirkel.GeldSystem;

namespace HexenZirkel.Items;

public abstract class Tränke
{
    public string? Name { get; set; }
    public string? Wirkung { get; set; }
    public string? Preis { get; set; }
    public Größe TrankGröße { get; set; }

    public WarenKosten Geld = new WarenKosten();

    public enum Größe
    {
        Groß,
        Mittel,
        Klein
    }

    public abstract void TrankBeschreibung();
    public void TrankInfo()
    {
        System.Console.WriteLine("TrankInfo: ");

        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"Größe: {TrankGröße}");
        System.Console.WriteLine($"Wirkung: {Wirkung}");
        System.Console.WriteLine($"Preis: {Preis}\n");
    }

}
