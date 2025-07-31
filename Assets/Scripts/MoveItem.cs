using UnityEngine;

public class MoveItem : MonoBehaviour
{
    public float rightSpeed = 1;
    public float leftSpeed = 10.0f;
    public bool goingLeft = false;
    private float rightBoundX = 12f;
    private float leftBoundX = -15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goingLeft)
        {
            transform.Translate(Vector3.left * leftSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * rightSpeed * Time.deltaTime);
        }

        if (transform.position.x < leftBoundX || transform.position.x > rightBoundX)
        {
            Destroy(gameObject);
        }
    }
    
}
