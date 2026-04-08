using HexenZirkel;
using HexenZirkel.Items;

TränkeManager manager = new TränkeManager();
Tränke heilTrank = new TrankDerHeilung(Tränke.Größe.Groß);
Tränke sträkeTrank = new TrankDerStärke(Tränke.Größe.Klein);
Tränke schnelligkeitsTrank = new TrankDerSchnelligkeit(Tränke.Größe.Mittel);

manager.TränkeListe.Add(heilTrank);
manager.TränkeListe.Add(sträkeTrank);
manager.TränkeListe.Add(schnelligkeitsTrank);

foreach (Tränke trank in manager.TränkeListe)
{
    trank.TrankInfo();
}