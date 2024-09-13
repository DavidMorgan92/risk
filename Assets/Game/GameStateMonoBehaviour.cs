#nullable enable

using UnityEngine;

public abstract class GameStateMonoBehaviour : MonoBehaviour
{
    public abstract GameState State { get; }
}
