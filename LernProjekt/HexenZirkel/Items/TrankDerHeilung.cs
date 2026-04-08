using System;
using HexenZirkel.GeldSystem;

namespace HexenZirkel.Items;

public class TrankDerHeilung : Tränke
{
    public TrankDerHeilung(Größe trankGröße)
    {
        TrankGröße = trankGröße;
        Name = "Trank der Heilung";
        TrankBeschreibung();
    }

    public override void TrankBeschreibung()
    {
        if (TrankGröße == Größe.Groß)
        {
            TrankGröße = Größe.Groß;
            Wirkung = "Der Heiltrank heilt euch um 80 LebensPunkte!";
            Preis = Geld.Gold = "1 Gold";
        }

        else if (TrankGröße == Größe.Mittel)
        {
            TrankGröße = Größe.Mittel;
            Wirkung = "Der Heiltrank heilt euch um 50 LebensPunkte!";
            Preis = Geld.Silber = "60 Silber";
        }

        else if (TrankGröße == Größe.Klein)
        {
            TrankGröße = Größe.Klein;
            Wirkung = "Der Heiltrank heilt dich um 20 LebensPunkte!";
            Preis = Geld.Kupfer = "70 Kupfer";
        }
    }
}
