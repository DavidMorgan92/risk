#nullable enable

using UnityEngine;

public partial class Game : MonoBehaviour
{
    private void OnValidate()
    {
        ApplyContinentColorsToTerritories();
    }

    private void ApplyContinentColorsToTerritories()
    {
        if (continents is null)
            return;

        foreach (var continent in continents)
            ApplyContinentColorsToTerritories(continent);
    }

    private void ApplyContinentColorsToTerritories(Continent continent)
    {
        if (continent.territories is null)
            return;
    
        foreach (var territory in continent.territories)
            territory.SetColor(continent.color);
    }
}
