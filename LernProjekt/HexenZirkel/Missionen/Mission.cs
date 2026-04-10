using System;

namespace HexenZirkel.Missionen;

public class Mission : IMission
{
    public string? MissionsName { get; set; }
    public string? MissionsLevel { get; set; } = "1";
    public string? MissionsSchwierigkeit { get; set; }


    public void MissionBeschreibung()
    {
        switch (MissionsLevel)
        {
            case "1":
                System.Console.WriteLine(
                    "Deine Mission: \n\n" +
                    "Erzuge einen kleinen Trank der Heilung.\n" +
                    "Zutaten: \n" +
                    "2x Auge des Weinenden Ogers\n" +
                    "1x Blut eines Steinbocks\n" + 
                    "1x Klares Wasser\n"
                );
            break;
        }
    }

    public void MissionAnnehmenOderAblehnen()
    {
        
    }
}
