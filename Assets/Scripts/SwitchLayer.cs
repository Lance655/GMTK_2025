using UnityEngine;

public class SwitchLayer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public int newSortingOrder = 1;

    public void Switch()
    {
        spriteRenderer.sortingOrder = newSortingOrder;
        // Debug.Log("Switched layer!");
    }

}
