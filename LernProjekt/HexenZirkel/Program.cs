using HexenZirkel.Character;
using HexenZirkel.Gebäude;

MainCharacter spieler = new MainCharacter("Lily");
IGebäude hexenHaus = new MainGebäude("HexenHaus");

spieler?.mainGebäude?.Betreten();
