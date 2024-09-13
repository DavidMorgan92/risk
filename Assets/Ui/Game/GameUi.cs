#nullable enable

using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class GameUi : MonoBehaviour
{
    public VisualTreeAsset? playerListItemTemplate;

    private void OnEnable()
    {
        var playerNames = Game.GetInstance().GetPlayerNames();
        InitializePlayerNamesListView(playerNames);
    }

    private void InitializePlayerNamesListView(string[] playerNames)
    {
        if (playerListItemTemplate == null)
            return;

        var document = GetComponent<UIDocument>();
        var playersListView = (ListView)document.rootVisualElement.Q("Players");

        playersListView.makeItem = () =>
        {
            var playerListItemTemplateInstance = playerListItemTemplate.Instantiate();
            var playerListItem = new PlayerListItem(playerListItemTemplateInstance);
            playerListItemTemplateInstance.userData = playerListItem;
            return playerListItemTemplateInstance;
        };

        playersListView.bindItem = (item, index) =>
        {
            var playerListItem = item.userData as PlayerListItem;
            playerListItem?.SetLabel(playerNames[index]);
        };

        playersListView.itemsSource = playerNames;
    }
}
