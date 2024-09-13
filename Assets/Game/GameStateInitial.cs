#nullable enable

using UnityEngine;

public class GameStateInitial : GameStateMonoBehaviour
{
    public override GameState State => GameState.Initial;

    public GameObject? uiController;

    private void OnEnable()
    {
        if (uiController != null)
            uiController.SetActive(true);
    }

    private void OnDisable()
    {
        if (uiController != null)
            uiController.SetActive(false);
    }
}
