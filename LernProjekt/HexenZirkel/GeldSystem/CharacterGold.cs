using System;

namespace HexenZirkel.GeldSystem;

public class CharacterGold
{
    public int Gold { get; set; }
    public int Silber { get; set; }
    public int Kupfer { get; set; }

    public CharacterGold()
    {
        Gold = 0;
        Silber = 0;
        Kupfer = 0;
    }
}
