using System;

namespace HexenZirkel.Items;

public class TrankDerSchnelligkeit : Tränke
{
    public TrankDerSchnelligkeit(Größe trankGröße)
    {
        TrankGröße = trankGröße;
        Name = "Trank der Schnelligkeit";
        TrankBeschreibung();
    }

    public override void TrankBeschreibung()
    {
        if (TrankGröße == Größe.Groß)
        {
            Wirkung = "Der Trank der Schnelligkeit verleiht euch 25 GeschickPunkte!";
            Preis = Geld.Gold = "2 Gold";
        }

        else if (TrankGröße == Größe.Mittel)
        {
            Wirkung = "Der Trank der Schnelligkeit verleiht euch 10 GeschikPunkte!";
            Preis = Geld.Silber = "80 Silber";
        }

        else if (TrankGröße == Größe.Klein)
        {
            Wirkung = "Der Trank der Schnelligkeit verleiht euch 5 GeschickPunkte!";
            Preis = Geld.Kupfer = "30 Silber";
        }
    }
}
