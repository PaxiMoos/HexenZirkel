using HexenZirkel.Charactere;
using HexenZirkel.Items;

Spieler spieler = new Spieler("Lilly");
TrankDerHeilung heilTrank = new TrankDerHeilung(Tränke.Größe.Groß);
spieler.inventar.ItemsHinzufügen(heilTrank);
spieler.inventar.InventarAnzeigen();
