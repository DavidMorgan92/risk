#nullable enable

using UnityEngine;

public class GameStateChooseCountries : GameStateMonoBehaviour
{
    public override GameState State => GameState.ChooseCountries;

    public GameObject? uiController;

    private void OnEnable()
    {
        if (uiController != null)
            uiController.SetActive(true);
    }
}
