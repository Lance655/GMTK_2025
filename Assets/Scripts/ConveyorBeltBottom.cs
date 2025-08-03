using UnityEngine;

public class ConveyorBeltBottom : MonoBehaviour
{
    private Vector3 startPos;
    public float offset = 12.46f;
    public float rightSpeed = 0.7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= startPos.x + offset)
        {
            transform.position = startPos;
        }

        transform.Translate(Vector3.right * rightSpeed * Time.deltaTime);
    }
    
}
