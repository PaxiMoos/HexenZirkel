using System;
using HexenZirkel.GeldSystem;

namespace HexenZirkel.Charactere;

public abstract class Character
{
    public string? Name { get; set; }
    public int Level { get; set; } 
    public CharacterGold geldBeutel = new CharacterGold();    
}
