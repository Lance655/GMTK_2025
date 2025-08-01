using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Container prevContainer = null;
    private Container currentContainer = null;

    void Update()
    {
        // Raycast from mouse position
        Vector3 mousePos = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

        // Get container component if hit
        if (hit.collider != null)
        {
            currentContainer = hit.collider.GetComponentInParent<Container>();
        }
        else
        {
            currentContainer = null;
        }

        // Highlight the newly hovered container, unhighlight previous
        if (prevContainer != currentContainer)
        {
            if (prevContainer != null)
                prevContainer.Highlight(false);

            if (currentContainer != null)
                currentContainer.Highlight(true);

            prevContainer = currentContainer;
        }

        // Toggle container open/close on F key
        if (Input.GetKeyDown(KeyCode.F) && currentContainer != null)
        {
            currentContainer.Toggle();
        }
    }
}
