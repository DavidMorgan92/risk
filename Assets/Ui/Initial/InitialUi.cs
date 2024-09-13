#nullable enable

using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class InitialUi : MonoBehaviour
{
    private void OnEnable()
    {
        InitializeReadyButton();
    }

    private void InitializeReadyButton()
    {
        var document = GetComponent<UIDocument>();
        var readyButton = (Button)document.rootVisualElement.Q("Ready");

        readyButton.clicked += SetNumberOfPlayersAndMoveGameToChooseCountriesState;
    }

    private void SetNumberOfPlayersAndMoveGameToChooseCountriesState()
    {
        var document = GetComponent<UIDocument>();
        var numberOfPlayersSlider = (SliderInt)document.rootVisualElement.Q("NumberOfPlayers");

        var game = Game.GetInstance();
        game.SetNumberOfPlayers(numberOfPlayersSlider.value);
        game.SetState(GameState.ChooseCountries);
    }
}
