#nullable enable

using UnityEngine;

public partial class Game : MonoBehaviour
{
    private GameState state = GameState.None;

    private void Start()
    {
        SetState(GameState.Initial);
    }

    public GameState GetState()
    {
        return state;
    }

    public void SetState(GameState newState)
    {
        Debug.Log($"Moving to {newState} state");

        state = newState;

        var stateScripts = GetComponents<GameStateMonoBehaviour>();

        foreach (var stateScript in stateScripts)
        {
            stateScript.enabled = stateScript.State == newState;
        }
    }
}
