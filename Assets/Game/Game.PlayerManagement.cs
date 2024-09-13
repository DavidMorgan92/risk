#nullable enable

using System;
using System.Linq;
using UnityEngine;

public partial class Game : MonoBehaviour
{
    private Player[]? players;

    public string[] GetPlayerNames() => players?.Select(p => p.name ?? string.Empty).ToArray() ?? Array.Empty<string>();

    public void SetNumberOfPlayers(int numberOfPlayers)
    {
        if (state != GameState.Initial)
            throw new InvalidStateException("Trying to set number of players", requiredState: GameState.Initial);

        if (players is not null)
            throw new Exception("Trying to set number of players when number has already been set");

        Debug.Log($"Setting number of players to {numberOfPlayers}");

        players = Enumerable.Range(1, numberOfPlayers).Select(MakePlayer).ToArray();
    }

    private Player MakePlayer(int index)
    {
        return new Player
        {
            name = $"Player {index}"
        };
    }
}
