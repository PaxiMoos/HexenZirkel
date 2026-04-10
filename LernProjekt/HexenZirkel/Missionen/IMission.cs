using System;

namespace HexenZirkel.Missionen;

public interface IMission
{
    public string? MissionsName {get; set;}
    public string? MissionsLevel {get; set;}
    public string? MissionsSchwierigkeit {get; set;}

    public void MissionBeschreibung();
    public void MissionAnnehmenOderAblehnen();
}
