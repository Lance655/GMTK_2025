using UnityEngine;

public class Container : MonoBehaviour
{
    [Header("References")]
    public GameObject outlineEffect;  // Assign your outline child GameObject here
    public CircleCollider2D myCollider;
    private Animator animator;
    private bool isOpen = false;

    void Awake()
    {
        animator = GetComponent<Animator>();
        myCollider = GetComponent<CircleCollider2D>();

        if (outlineEffect != null)
            outlineEffect.SetActive(false);  // Hide outline initially
    }

    public void Highlight(bool value)
    {
        if (outlineEffect != null)
            outlineEffect.SetActive(value);
    }

    public void Toggle()
    {
        isOpen = !isOpen; 

        if (animator != null)
        {
            animator.SetFloat("direction", isOpen ? 1f : -1f);
            animator.Play("Container_Open", -1, isOpen ? 0f : 1f);
        }

        // Disable collider if open to allow clicks to pass through
        if (myCollider != null)
        {
            myCollider.enabled = !isOpen;
        }
    }

    public bool IsOpen => isOpen;
}
