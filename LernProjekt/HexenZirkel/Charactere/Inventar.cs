using System;

namespace HexenZirkel.Charactere;

public class Inventar
{
    public List<IAlleItems> inventar = new List<IAlleItems>();

    public void ItemsHinzufügen(IAlleItems item)
    {
        inventar.Add(item);
    }

    public void ItemEntfernen(IAlleItems item)
    {
        inventar.Remove(item);
    }

    public void InventarAnzeigen()
    {
        System.Console.WriteLine("Inventar: ");
        
        foreach (IAlleItems item in inventar)
        {
            System.Console.WriteLine(item.Name);
        }
    }
}
