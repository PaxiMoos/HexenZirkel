using System;

namespace HexenZirkel.Missionen;

public class Mission : IMission
{
    public string? MissionsName { get; set; }
    public string? MissioneLevel { get; set; }
    public string? MissionsSchwierigkeit { get; set; }


    public void MissionBeschreibung()
    {
        
    }

    public void MissionAnnehmenOderAblehnen()
    {
        
    }
}
