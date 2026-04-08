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

    public virtual void TrankBeschreibung()
    {
        if (TrankGröße == Größe.Groß)
        {
            Wirkung = "Der Heiltrank heilt euch um 80 LebensPunkte!";
            Preis = Geld.Gold = "1 Gold";
        }

        else if (TrankGröße == Größe.Mittel)
        {
            Wirkung = "Der Heiltrank heilt euch um 50 LebensPunkte!";
            Preis = Geld.Silber = "60 Silber";
        }

        else if (TrankGröße == Größe.Klein)
        {
            Wirkung = "Der Heiltrank heilt dich um 20 LebensPunkte!";
            Preis = Geld.Kupfer = "70 Kupfer";
        }
    }
}
