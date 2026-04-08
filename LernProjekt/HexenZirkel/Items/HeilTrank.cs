using System;
using HexenZirkel.GeldSystem;

namespace HexenZirkel.Items;

public class HeilTrank : Tränke
{
    

    public HeilTrank(Größe trankGröße)
    {
        trankGröße = TrankGröße;
        Name = "Heiltrank";
        TrankBeschreibung();
    }

    public override void TrankBeschreibung()
    {
        if (TrankGröße == Größe.Groß)
        {
            Wirkung = "Der Heiltrank heilt euch um 80 LebensPunkte!";
            Preis = Geld.Gold = 1;
        }

        else if (TrankGröße == Größe.Mittel)
        {
            Wirkung = "Der Heiltrank heilt euch um 50 LebensPunkte!";
            Preis = Geld.Silber = 60;
        }

        Wirkung = "Der Heiltrank heilt dich um 20 LebensPunkte!";
        Preis = Geld.Kupfer = 70;
    }
}
