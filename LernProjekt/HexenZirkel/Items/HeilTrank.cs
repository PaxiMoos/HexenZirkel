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
}
