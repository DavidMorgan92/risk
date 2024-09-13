#nullable enable

using UnityEngine;

public partial class Territory : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        if (adjacentTerritories is null)
            return;

        foreach (var adjacentTerritory in adjacentTerritories)
            Gizmos.DrawLine(transform.position, adjacentTerritory.transform.position);
    }
}
