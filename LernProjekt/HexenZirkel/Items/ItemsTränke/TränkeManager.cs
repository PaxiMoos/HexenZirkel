using System;

namespace HexenZirkel.Items;

public class TränkeManager
{
    public List<Tränke> TränkeListe = new List<Tränke>();

    public void Main()
    {        
        Tränke heilTrank = new TrankDerHeilung(Tränke.Größe.Groß);
        Tränke sträkeTrank = new TrankDerStärke(Tränke.Größe.Klein);
        Tränke schnelligkeitsTrank = new TrankDerSchnelligkeit(Tränke.Größe.Mittel);

        TränkeListe.Add(heilTrank);
        TränkeListe.Add(sträkeTrank);
        TränkeListe.Add(schnelligkeitsTrank);

        foreach (Tränke trank in TränkeListe)
        {
            trank.TrankInfo();
        }
    }
}
