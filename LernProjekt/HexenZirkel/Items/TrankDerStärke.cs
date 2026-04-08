using System;

namespace HexenZirkel.Items;

public class TrankDerStärke : Tränke
{
    public TrankDerStärke(Größe trankGröße)
    {
        TrankGröße = trankGröße;
        Name = "Trank der Sträke";
        TrankBeschreibung();
    }

    public override void TrankBeschreibung()
    {
        if (TrankGröße == Größe.Groß)
        {
            Wirkung = "Der Trank der Stärke verleiht euch 30 StärkePunkte!";
            Preis = Geld.Gold = "3 Gold";
        }

        else if (TrankGröße == Größe.Mittel)
        {
            Wirkung = "Der Trank der Stärke verleiht euch 15 StärkePunkte!";
            Preis = Geld.Silber = "1 Gold";
        }

        else if (TrankGröße == Größe.Klein)
        {
            Wirkung = "Der Trank der Stärke verleiht euch 5 StärkePunkte!";
            Preis = Geld.Kupfer = "30 Silber";
        }
    }
}
