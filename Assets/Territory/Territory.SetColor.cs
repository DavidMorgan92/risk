#nullable enable

using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(SpriteRenderer))]
public partial class Territory : MonoBehaviour
{
    private SpriteRenderer? spriteRenderer;

    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void SetColor(Color color)
    {
        if (spriteRenderer != null)
            spriteRenderer.color = color;
    }
}
