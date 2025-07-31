using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnMouseDown() {
        // add functinoality to only delete if the container is opened
        // another idea: check whether child container or sushi was clicked from the Item Game object instead?
        Destroy(gameObject);
    }
}
