using HexenZirkel.Character;
using HexenZirkel.Gebäude;

MainCharacter spieler = new MainCharacter(name:"Lily");
MainGebäude hexenHaus = new MainGebäude(name:"HexenHaus");

spieler?.mainGebäude?.Betreten();
hexenHaus.mission.MissionBeschreibung();
