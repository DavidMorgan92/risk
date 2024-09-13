#nullable enable

using UnityEngine.UIElements;

public class PlayerListItem
{
    private readonly Label label;

    public PlayerListItem(VisualElement visualElement)
    {
        label = visualElement.Q<Label>();
    }

    public void SetLabel(string text)
    {
        label.text = text;
    }
}
